
namespace sendToThings3
{
    partial class settings
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_thingsMail = new System.Windows.Forms.TextBox();
            this.btn_settings_save = new System.Windows.Forms.Button();
            this.tb_settings_sendingMail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_settings_password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
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
            // tb_thingsMail
            // 
            this.tb_thingsMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_thingsMail.Location = new System.Drawing.Point(133, 12);
            this.tb_thingsMail.Name = "tb_thingsMail";
            this.tb_thingsMail.Size = new System.Drawing.Size(345, 22);
            this.tb_thingsMail.TabIndex = 2;
            // 
            // btn_settings_save
            // 
            this.btn_settings_save.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_settings_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(149)))), ((int)(((byte)(247)))));
            this.btn_settings_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_settings_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_settings_save.ForeColor = System.Drawing.Color.White;
            this.btn_settings_save.Location = new System.Drawing.Point(12, 131);
            this.btn_settings_save.Margin = new System.Windows.Forms.Padding(3, 3, 10, 10);
            this.btn_settings_save.Name = "btn_settings_save";
            this.btn_settings_save.Size = new System.Drawing.Size(466, 44);
            this.btn_settings_save.TabIndex = 4;
            this.btn_settings_save.Text = "save";
            this.btn_settings_save.UseVisualStyleBackColor = false;
            this.btn_settings_save.Click += new System.EventHandler(this.btn_settings_save_Click);
            // 
            // tb_settings_sendingMail
            // 
            this.tb_settings_sendingMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_settings_sendingMail.Location = new System.Drawing.Point(133, 40);
            this.tb_settings_sendingMail.Name = "tb_settings_sendingMail";
            this.tb_settings_sendingMail.Size = new System.Drawing.Size(345, 22);
            this.tb_settings_sendingMail.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "SendingMail";
            // 
            // tb_settings_password
            // 
            this.tb_settings_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_settings_password.Location = new System.Drawing.Point(133, 68);
            this.tb_settings_password.Name = "tb_settings_password";
            this.tb_settings_password.PasswordChar = '*';
            this.tb_settings_password.Size = new System.Drawing.Size(345, 22);
            this.tb_settings_password.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "SendingPassword";
            // 
            // settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 185);
            this.Controls.Add(this.tb_settings_password);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_settings_sendingMail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_settings_save);
            this.Controls.Add(this.tb_thingsMail);
            this.Controls.Add(this.label1);
            this.Name = "settings";
            this.Text = "settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_thingsMail;
        private System.Windows.Forms.Button btn_settings_save;
        private System.Windows.Forms.TextBox tb_settings_sendingMail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_settings_password;
        private System.Windows.Forms.Label label3;
    }
}