using System;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SimpleNotification {
    public partial class Form1 : Form {
        public Form1(string message, string imageURL, string email, string phone) {
            InitializeComponent();
            textBox_message.Text = message;
            Regex urlRegex = new Regex(@"[(http(s)?):\/\/(www\.)?a-zA-Z0-9@:%._\+~#=]{2,256}\.[a-z]{2,6}\b([-a-zA-Z0-9@:%_\+.~#?&//=]*)");
            if (urlRegex.IsMatch(imageURL)) {
                try {
                    pictureBox_Logo.Load(imageURL);
                } catch {
                    pictureBox_Logo.Visible = false;
                }
            }
            label_email2.Text = email;
            label_phone2.Text = phone;

            if (string.IsNullOrEmpty(email)) {
                label_email.Visible = false;
                label_email2.Visible = false;
            }

            if (string.IsNullOrEmpty(phone)) {
                label_phone.Visible = false;
                label_phone2.Visible = false;
            }

            // Fix for WinForms not updating ForeColor on disabled TextBoxes. Ref: https://stackoverflow.com/questions/20688408/how-do-you-change-the-text-color-of-a-readonly-textbox
            textBox_message.BackColor = textBox_message.BackColor;
        }

        private void button_close_Click(object sender, EventArgs e) {
            Environment.Exit(0);
        }

        private void label_email2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            string mailtoUrl = $"mailto:{label_email2.Text}";
            Process.Start(new ProcessStartInfo(mailtoUrl) { UseShellExecute = true });
        }
    }
}
