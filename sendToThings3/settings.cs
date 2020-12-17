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
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();

            tbSettingsThingsMail.Text = Storage.GetSetting("thingsMail");
            tbSettingsSenderMail.Text = Storage.GetSetting("senderMail");
            tbSettingsSenderPassword.Text = Storage.GetSetting("senderPassword");
            tbSettingsSmtpHost.Text = Storage.GetSetting("smtpHost");
            tbSettingsSmtpPort.Text = Storage.GetSetting("smtpPort");

        }

        private void btn_settings_save_Click(object sender, EventArgs e)
        {
            if (tbSettingsThingsMail.TextLength > 5 && tbSettingsSenderPassword.TextLength > 0 && tbSettingsSenderMail.TextLength > 0 && tbSettingsSmtpHost.TextLength > 0 && int.TryParse(tbSettingsSmtpPort.Text, out var smtpClientPortInt))
            {
                Storage.SetSetting("thingsMail", tbSettingsThingsMail.Text);

                Storage.SetSetting("smtpHost", tbSettingsSmtpHost.Text);
                Storage.SetSetting("smtpPort", smtpClientPortInt.ToString());
                Storage.SetSetting("senderMail", tbSettingsSenderMail.Text);
                Storage.SetSetting("senderPassword", tbSettingsSenderPassword.Text);
                this.Close();
            }
            else
            {
                MessageBox.Show("check your settings - fill out all fields");
            }
            
        }
    }
}
