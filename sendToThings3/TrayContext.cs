using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sendToThings3.Properties;

namespace sendToThings3
{
    class TrayContext : ApplicationContext
    {
        private sendFormular _form1 = new sendFormular();

        private NotifyIcon trayIcon;

        public TrayContext()
        {
            // Initialize Tray Icon
            trayIcon = new NotifyIcon()
            {
                Icon = Resources.icon ,
                ContextMenu = new ContextMenu(new MenuItem[] {
                    new MenuItem("New", New),
                    new MenuItem("Exit", Exit)
                }),
                Visible = true
            };


        }

        void Exit(object sender, EventArgs e)
        {
            // Hide tray icon, otherwise it will remain shown until user mouses over it
            trayIcon.Visible = false;
            Application.Exit();
        }

        void New(object sender, EventArgs e)
        {
            _form1.Show();
        }
    }
}
