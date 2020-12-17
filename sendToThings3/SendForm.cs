using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace sendToThings3
{
    public partial class SendForm : Form
    {

        KeyboardHook hook = new KeyboardHook();
        //[DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        
        // private static extern IntPtr CreateRoundRectRgn
        // (
        //     int nLeftRect,     // x-coordinate of upper-left corner
        //     int nTopRect,      // y-coordinate of upper-left corner
        //     int nRightRect,    // x-coordinate of lower-right corner
        //     int nBottomRect,   // y-coordinate of lower-right corner
        //     int nWidthEllipse, // width of ellipse
        //     int nHeightEllipse // height of ellipse
        // );


        public SendForm()
        {
            InitializeComponent();
            //Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 10, 10));

            // register the event that is fired after the key press.
            hook.KeyPressed +=
                new EventHandler<KeyPressedEventArgs>(Hook_KeyPressed);
            // register the combination as hot key.
            hook.RegisterHotKey(sendToThings3.ModifierKeys.Control | sendToThings3.ModifierKeys.Alt,
                Keys.OemPeriod);

            p_text.Visible = true;
            p_message.Enabled = false;
            p_message.Visible = false;

        }

        //override onshow
        protected override void OnShown(EventArgs e)
        {
            tb_title.Select();
        }


        private void Hook_KeyPressed(object sender, KeyPressedEventArgs e)
        {
            // show the keys pressed in a label.
            if (this.Visible)
            {
                this.Hide();
                return;
            }

            this.Show();
            tb_title.Select();

        }



        /**
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }

            base.WndProc(ref m);
        }
        **/


        private void SendForm_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.S && e.Control || e.KeyCode == Keys.Enter && e.Control)
            {
                SaveNote();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }

            if (e.KeyCode == Keys.Escape)
            {
                CancelNote();

                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void SendForm_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyData == Keys.Tab)
            { 
                p_text.Visible = false;
                p_message.Enabled = true;
                p_message.Visible = true;
            }
        }

        private void Btn_send_Click(object sender, EventArgs e)
        {
            SaveNote();
        }

        private void Btn_cancel_Click(object sender, EventArgs e)
        {
            CancelNote();
        }

        private void SaveNote()
        {
            if (!string.IsNullOrEmpty(tb_title.Text))
            {
                if ((tb_message.TextLength + tb_title.TextLength) < 2000)
                {

                    this.Hide();

                    switch (Utils.SendMail(tb_title.Text, tb_message.Text))
                    {
                        case Utils.MailStatus.Ok:
                        {
                            tb_title.Clear();
                            tb_message.Clear();
                            break;
                        }
                        case Utils.MailStatus.NetworkError:
                        {
                            this.Show();
                            MessageBox.Show("Something went wrong sending the mail\nCheck your Network or Mail settings");
                            break;
                        }
                        case Utils.MailStatus.SettingsError:
                        {
                            new Settings().Show();
                            MessageBox.Show("Missing Settings");
                            break;
                        }
                    }

                    p_text.Visible = true;
                    p_message.Enabled = false;
                    p_message.Visible = false;

                }
                else
                {
                    MessageBox.Show($"Stay under 2000 characters\nRemove {(tb_message.TextLength + tb_title.TextLength) - 2001} characters");
                }

            }
        }

        private void CancelNote()
        {
            tb_title.Clear();
            tb_message.Clear();
            this.Hide();

            p_text.Visible = true;
            p_message.Enabled = false;
            p_message.Visible = false;
        }

    }
}
