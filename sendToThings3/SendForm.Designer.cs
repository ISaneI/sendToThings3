
namespace sendToThings3
{
    partial class SendForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SendForm));
            this.tb_message = new System.Windows.Forms.TextBox();
            this.tb_title = new System.Windows.Forms.TextBox();
            this.btn_send = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.p_message = new System.Windows.Forms.Panel();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.p_all = new System.Windows.Forms.Panel();
            this.p_buttons = new System.Windows.Forms.TableLayoutPanel();
            this.p_text = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.p_message.SuspendLayout();
            this.p_all.SuspendLayout();
            this.p_buttons.SuspendLayout();
            this.p_text.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_message
            // 
            this.tb_message.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_message.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_message.Location = new System.Drawing.Point(12, 0);
            this.tb_message.Multiline = true;
            this.tb_message.Name = "tb_message";
            this.tb_message.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_message.Size = new System.Drawing.Size(838, 144);
            this.tb_message.TabIndex = 5;
            this.tb_message.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SendForm_KeyDown);
            // 
            // tb_title
            // 
            this.tb_title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_title.Location = new System.Drawing.Point(12, 12);
            this.tb_title.Name = "tb_title";
            this.tb_title.Size = new System.Drawing.Size(838, 31);
            this.tb_title.TabIndex = 4;
            this.tb_title.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SendForm_KeyDown);
            this.tb_title.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.SendForm_PreviewKeyDown);
            // 
            // btn_send
            // 
            this.btn_send.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(149)))), ((int)(((byte)(247)))));
            this.btn_send.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_send.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_send.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_send.ForeColor = System.Drawing.Color.White;
            this.btn_send.Location = new System.Drawing.Point(434, 3);
            this.btn_send.Margin = new System.Windows.Forms.Padding(3, 3, 10, 10);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(418, 52);
            this.btn_send.TabIndex = 3;
            this.btn_send.Text = "send";
            this.btn_send.UseVisualStyleBackColor = false;
            this.btn_send.Click += new System.EventHandler(this.Btn_send_Click);
            this.btn_send.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SendForm_KeyDown);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tb_title);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(862, 50);
            this.panel1.TabIndex = 6;
            // 
            // p_message
            // 
            this.p_message.Controls.Add(this.tb_message);
            this.p_message.Dock = System.Windows.Forms.DockStyle.Top;
            this.p_message.Enabled = false;
            this.p_message.Location = new System.Drawing.Point(0, 83);
            this.p_message.Name = "p_message";
            this.p_message.Size = new System.Drawing.Size(862, 150);
            this.p_message.TabIndex = 7;
            this.p_message.Visible = false;
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(149)))), ((int)(((byte)(247)))));
            this.btn_cancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.Color.White;
            this.btn_cancel.Location = new System.Drawing.Point(10, 3);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(10, 3, 3, 10);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(418, 52);
            this.btn_cancel.TabIndex = 4;
            this.btn_cancel.Text = "cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.Btn_cancel_Click);
            this.btn_cancel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SendForm_KeyDown);
            // 
            // p_all
            // 
            this.p_all.AutoSize = true;
            this.p_all.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.p_all.Controls.Add(this.p_buttons);
            this.p_all.Controls.Add(this.p_message);
            this.p_all.Controls.Add(this.p_text);
            this.p_all.Controls.Add(this.panel1);
            this.p_all.Dock = System.Windows.Forms.DockStyle.Top;
            this.p_all.Location = new System.Drawing.Point(0, 0);
            this.p_all.Margin = new System.Windows.Forms.Padding(0);
            this.p_all.Name = "p_all";
            this.p_all.Size = new System.Drawing.Size(862, 298);
            this.p_all.TabIndex = 10;
            // 
            // p_buttons
            // 
            this.p_buttons.ColumnCount = 2;
            this.p_buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.p_buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.p_buttons.Controls.Add(this.btn_send, 1, 0);
            this.p_buttons.Controls.Add(this.btn_cancel, 0, 0);
            this.p_buttons.Dock = System.Windows.Forms.DockStyle.Top;
            this.p_buttons.Location = new System.Drawing.Point(0, 233);
            this.p_buttons.Margin = new System.Windows.Forms.Padding(0);
            this.p_buttons.Name = "p_buttons";
            this.p_buttons.RowCount = 1;
            this.p_buttons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.p_buttons.Size = new System.Drawing.Size(862, 65);
            this.p_buttons.TabIndex = 8;
            this.p_buttons.Visible = false;
            // 
            // p_text
            // 
            this.p_text.Controls.Add(this.label1);
            this.p_text.Dock = System.Windows.Forms.DockStyle.Top;
            this.p_text.Location = new System.Drawing.Point(0, 50);
            this.p_text.Name = "p_text";
            this.p_text.Padding = new System.Windows.Forms.Padding(5);
            this.p_text.Size = new System.Drawing.Size(862, 33);
            this.p_text.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(852, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Press TAB to add details  | CTRL + Enter or CTRL + S to send";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SendForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(862, 621);
            this.Controls.Add(this.p_all);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(400, 39);
            this.Name = "SendForm";
            this.Text = "sendToThings";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SendForm_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.p_message.ResumeLayout(false);
            this.p_message.PerformLayout();
            this.p_all.ResumeLayout(false);
            this.p_buttons.ResumeLayout(false);
            this.p_text.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_message;
        private System.Windows.Forms.TextBox tb_title;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel p_message;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Panel p_all;
        private System.Windows.Forms.TableLayoutPanel p_buttons;
        private System.Windows.Forms.Panel p_text;
        private System.Windows.Forms.Label label1;
    }
}

