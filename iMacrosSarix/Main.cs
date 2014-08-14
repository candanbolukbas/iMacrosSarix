using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace iMacrosSarix
{
    public partial class Main : Form
    {
        private class SimpleStringString
        {
            public string username { get; set; }
            public string password { get; set; }

            public SimpleStringString(string uname, string pwd)
            {
                this.username = uname;
                this.password = pwd;
            }
            public SimpleStringString(string[] user)
            {
                this.username = user[0];
                this.password = user[1];
            }
        }

        public Main()
        {
            InitializeComponent();
            cbIIMProfile.SelectedIndex = 0;
        }

        private void btStart_Click(object sender, EventArgs e) //start button
        {
            //List<SimpleStringString> users = GetUsers();
            //string IP = "10.0.30.46";

            if (tbUrl.Text != "" && lbIpList.Items.Count > 0)
            {
                lbResults.Items.Clear();
                pbProgress.Maximum = lbIpList.Items.Count;
                pbProgress.Minimum = 0;
                pbProgress.Value = 0;
                pbProgress.Step = 1;

                iMacros.App m_app = new iMacros.App();

                foreach (string IP in lbIpList.Items)
                {
                    DoWork(m_app, IP);
                    pbProgress.PerformStep();
                    label3.Text = (pbProgress.Value * 100 / pbProgress.Maximum).ToString() + " %";
                    lbResults.SelectedIndex = lbResults.Items.Count - 1;
                    lbResults.SelectedIndex = -1;
                }

                m_app.iimExit();
            }
        }

        private bool DoWork(iMacros.App m_app, string IP)
        {
            iMacros.Status s = m_app.iimInit("", false, "", "", "", 5);

            if (s == iMacros.Status.sOk || s == iMacros.Status.sInternal)
            {
                m_app.iimSet("gotourl", string.Format(tbUrl.Text, IP));
                m_app.iimSet("username", tbUsername.Text);
                m_app.iimSet("password", tbPassword.Text);
                s = m_app.iimPlay(tbIIM.Text, 300);
                string result = m_app.iimGetLastError();

                lbResults.Items.Add(IP + "\t" + result);

                return true;
            }
            else
            {
                //listBox1.Items.Add(IP + "\t " + m_app.iimGetLastError());
                return false;
            }
        }

        private List<SimpleStringString> GetUsers()
        {
            string[] lines = System.IO.File.ReadAllLines(@"C:\\Users\\cbolukbas\\Documents\\iMacros\\Datasources\\Users.csv");

            List<SimpleStringString> result = new List<SimpleStringString>();

            foreach (string s in lines)
                result.Add(new SimpleStringString(s.Split(',')));

            return result;
        }

        private void btSelectIPList_Click(object sender, EventArgs e)
        {
            ofdSelectIPList.ShowDialog();
        }

        private void ofdSelectIPList_FileOk(object sender, CancelEventArgs e)
        {
            System.IO.Stream fileStream = ofdSelectIPList.OpenFile();

            System.IO.StreamReader reader = new System.IO.StreamReader(fileStream);
            List<string> lines = reader.ReadToEnd().Split('\n').ToList();
            fileStream.Close();

            lbIpList.Items.Clear();
            foreach (string str in lines)
                lbIpList.Items.Add(str.Replace("\r", string.Empty));
        }

        private void cbIIMProfile_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbIIMProfile.SelectedItem.ToString() == "Enable SSH")
            {
                tbIIM.Text = "SarixSSH";
                tbUrl.Text = "http://{0}/setup/network/ssh";
            }
            else if (cbIIMProfile.SelectedItem.ToString() == "Set Time Server")
            {
                tbIIM.Text = "SarixTimeServer";
                tbUrl.Text = "http://{0}/setup/system/general";
            }
            else if (cbIIMProfile.SelectedItem.ToString() == "A/V Config Set to H264")
            {
                tbIIM.Text = "IXS20DN_AV_H264";
                tbUrl.Text = "http://{0}/setup/streams/custom";
            }
        }

        private void cbIIMProfile_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void Main_Resize(object sender, EventArgs e)
        {
            lbResults.Width = this.Width - 132;
            lbResults.Height = this.Height - 155;
            lbIpList.Left = this.Width - 113;
            label3.Top = this.Height - 52;
            pbProgress.Top = this.Height - 57;
            pbProgress.Width = this.Width - 67;
            lbIpList.Height = this.Height - 155;
        }

        private void btPlayOnly_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < 3; i++)
            {
                iMacros.App m_app = new iMacros.App();
                iMacros.Status s = m_app.iimInit("", false, "", "", "", 5);

                if (s == iMacros.Status.sOk || s == iMacros.Status.sInternal)
                {
                    s = m_app.iimPlay(tbIIM.Text, 300);
                }
                string result = m_app.iimGetLastError();
                System.Threading.Thread.Sleep(10000);
                m_app.iimExit();
            }
        }
    }
}
