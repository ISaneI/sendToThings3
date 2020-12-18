
namespace sendToThings3
{
    partial class Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.label1 = new System.Windows.Forms.Label();
            this.tbSettingsThingsMail = new System.Windows.Forms.TextBox();
            this.btn_settings_save = new System.Windows.Forms.Button();
            this.tbSettingsSenderMail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSettingsSenderPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbSettingsSmtpHost = new System.Windows.Forms.TextBox();
            this.tbSettingsSmtpPort = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Things Mail";
            // 
            // tbSettingsThingsMail
            // 
            this.tbSettingsThingsMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSettingsThingsMail.Location = new System.Drawing.Point(133, 12);
            this.tbSettingsThingsMail.Name = "tbSettingsThingsMail";
            this.tbSettingsThingsMail.Size = new System.Drawing.Size(345, 22);
            this.tbSettingsThingsMail.TabIndex = 2;
            // 
            // btn_settings_save
            // 
            this.btn_settings_save.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_settings_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(149)))), ((int)(((byte)(247)))));
            this.btn_settings_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_settings_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_settings_save.ForeColor = System.Drawing.Color.White;
            this.btn_settings_save.Location = new System.Drawing.Point(12, 160);
            this.btn_settings_save.Margin = new System.Windows.Forms.Padding(3, 3, 10, 10);
            this.btn_settings_save.Name = "btn_settings_save";
            this.btn_settings_save.Size = new System.Drawing.Size(466, 44);
            this.btn_settings_save.TabIndex = 4;
            this.btn_settings_save.Text = "save";
            this.btn_settings_save.UseVisualStyleBackColor = false;
            this.btn_settings_save.Click += new System.EventHandler(this.btn_settings_save_Click);
            // 
            // tbSettingsSenderMail
            // 
            this.tbSettingsSenderMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSettingsSenderMail.Location = new System.Drawing.Point(133, 93);
            this.tbSettingsSenderMail.Name = "tbSettingsSenderMail";
            this.tbSettingsSenderMail.Size = new System.Drawing.Size(345, 22);
            this.tbSettingsSenderMail.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mail";
            // 
            // tbSettingsSenderPassword
            // 
            this.tbSettingsSenderPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSettingsSenderPassword.Location = new System.Drawing.Point(133, 121);
            this.tbSettingsSenderPassword.Name = "tbSettingsSenderPassword";
            this.tbSettingsSenderPassword.PasswordChar = '*';
            this.tbSettingsSenderPassword.Size = new System.Drawing.Size(345, 22);
            this.tbSettingsSenderPassword.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "SMTP Server / Port";
            // 
            // tbSettingsSmtpHost
            // 
            this.tbSettingsSmtpHost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSettingsSmtpHost.Location = new System.Drawing.Point(133, 65);
            this.tbSettingsSmtpHost.Name = "tbSettingsSmtpHost";
            this.tbSettingsSmtpHost.Size = new System.Drawing.Size(228, 22);
            this.tbSettingsSmtpHost.TabIndex = 10;
            // 
            // tbSettingsSmtpPort
            // 
            this.tbSettingsSmtpPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSettingsSmtpPort.Location = new System.Drawing.Point(367, 65);
            this.tbSettingsSmtpPort.Name = "tbSettingsSmtpPort";
            this.tbSettingsSmtpPort.Size = new System.Drawing.Size(111, 22);
            this.tbSettingsSmtpPort.TabIndex = 11;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 214);
            this.Controls.Add(this.tbSettingsSmtpPort);
            this.Controls.Add(this.tbSettingsSmtpHost);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbSettingsSenderPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbSettingsSenderMail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_settings_save);
            this.Controls.Add(this.tbSettingsThingsMail);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Settings";
            this.Text = "settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSettingsThingsMail;
        private System.Windows.Forms.Button btn_settings_save;
        private System.Windows.Forms.TextBox tbSettingsSenderMail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSettingsSenderPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbSettingsSmtpHost;
        private System.Windows.Forms.TextBox tbSettingsSmtpPort;
    }
}