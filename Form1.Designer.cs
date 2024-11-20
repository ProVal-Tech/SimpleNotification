namespace SimpleNotification {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.pictureBox_Logo = new System.Windows.Forms.PictureBox();
            this.textBox_message = new System.Windows.Forms.TextBox();
            this.label_email = new System.Windows.Forms.Label();
            this.button_close = new System.Windows.Forms.Button();
            this.label_phone = new System.Windows.Forms.Label();
            this.label_phone2 = new System.Windows.Forms.Label();
            this.label_email2 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_BISLogo
            // 
            this.pictureBox_Logo.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_Logo.Name = "pictureBox_BISLogo";
            this.pictureBox_Logo.Size = new System.Drawing.Size(156, 150);
            this.pictureBox_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Logo.TabIndex = 0;
            this.pictureBox_Logo.TabStop = false;
            // 
            // textBox_message
            // 
            this.textBox_message.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_message.Enabled = false;
            this.textBox_message.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.textBox_message.ForeColor = System.Drawing.Color.DimGray;
            this.textBox_message.Location = new System.Drawing.Point(162, 12);
            this.textBox_message.Margin = new System.Windows.Forms.Padding(0);
            this.textBox_message.Multiline = true;
            this.textBox_message.Name = "textBox_message";
            this.textBox_message.ReadOnly = true;
            this.textBox_message.Size = new System.Drawing.Size(326, 83);
            this.textBox_message.TabIndex = 1;
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_email.ForeColor = System.Drawing.Color.DimGray;
            this.label_email.Location = new System.Drawing.Point(159, 97);
            this.label_email.Margin = new System.Windows.Forms.Padding(0);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(41, 13);
            this.label_email.TabIndex = 2;
            this.label_email.Text = "Email:";
            this.label_email.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(413, 115);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(75, 23);
            this.button_close.TabIndex = 4;
            this.button_close.Text = "Close";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // label_phone
            // 
            this.label_phone.AutoSize = true;
            this.label_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_phone.ForeColor = System.Drawing.Color.DimGray;
            this.label_phone.Location = new System.Drawing.Point(159, 112);
            this.label_phone.Margin = new System.Windows.Forms.Padding(0);
            this.label_phone.Name = "label_phone";
            this.label_phone.Size = new System.Drawing.Size(47, 13);
            this.label_phone.TabIndex = 5;
            this.label_phone.Text = "Phone:";
            // 
            // label_phone2
            // 
            this.label_phone2.AutoSize = true;
            this.label_phone2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_phone2.ForeColor = System.Drawing.Color.DimGray;
            this.label_phone2.Location = new System.Drawing.Point(200, 112);
            this.label_phone2.Name = "label_phone2";
            this.label_phone2.Size = new System.Drawing.Size(96, 13);
            this.label_phone2.TabIndex = 6;
            this.label_phone2.Text = "1-000-000-0000";
            // 
            // label_email2
            // 
            this.label_email2.AutoSize = true;
            this.label_email2.Location = new System.Drawing.Point(201, 96);
            this.label_email2.Name = "label_email2";
            this.label_email2.Size = new System.Drawing.Size(122, 13);
            this.label_email2.TabIndex = 7;
            this.label_email2.TabStop = true;
            this.label_email2.Text = "default@replaceme.com";
            this.label_email2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.label_email2_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 150);
            this.ControlBox = false;
            this.Controls.Add(this.label_email2);
            this.Controls.Add(this.label_phone2);
            this.Controls.Add(this.label_phone);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.label_email);
            this.Controls.Add(this.textBox_message);
            this.Controls.Add(this.pictureBox_Logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_Logo;
        private System.Windows.Forms.TextBox textBox_message;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Label label_phone;
        private System.Windows.Forms.Label label_phone2;
        private System.Windows.Forms.LinkLabel label_email2;
    }
}

