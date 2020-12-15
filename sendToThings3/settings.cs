using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sendToThings3
{
    public partial class settings : Form
    {
        public settings()
        {
            InitializeComponent();

            tb_thingsMail.Text = Storage.GetSetting("thingsMail");
            tb_settings_sendingMail.Text = Storage.GetSetting("senderMail");
            tb_settings_password.Text = Storage.GetSetting("senderPassword");
        }

        private void btn_settings_save_Click(object sender, EventArgs e)
        {
            if (tb_thingsMail.TextLength > 5)
            {
                Storage.SetSetting("thingsMail", tb_thingsMail.Text);
                Storage.SetSetting("senderMail", tb_settings_sendingMail.Text);
                Storage.SetSetting("senderPassword", tb_settings_password.Text);
                this.Close();
            }
            else
            {
                MessageBox.Show("check your mail");
            }
            
        }
    }
}
