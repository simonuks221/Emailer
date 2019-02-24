using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace Emailer
{
    public partial class Form1 : Form
    {

        List<string> allRecipients;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            allRecipients = new List<string>();
            RecipientPanel.Visible = false;
        }

        private void SendEmailButton_Click(object sender, EventArgs e)
        {
            if (EmailTextBox.Text != "" && PasswordTextBox.Text != "")
            {
                MailMessage msg = new MailMessage();

                msg.From = new MailAddress(EmailTextBox.Text);
                msg.IsBodyHtml = true;
                msg.Subject = SubjectTextBox.Text;
                msg.Body = BodyTextBox.Text;
                msg.Priority = MailPriority.High;

                foreach(string str in allRecipients) //Add up all recipients
                {
                    msg.To.Add(str);
                }

                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                client.Credentials = new NetworkCredential(EmailTextBox.Text, PasswordTextBox.Text);
                //client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.EnableSsl = true;
                client.Send(msg);
            }
        }

        private void SetuprecipientsButton_Click(object sender, EventArgs e)
        {
            RecipientPanel.Visible = true;
        }

        private void SaveRecipientsButton_Click(object sender, EventArgs e)
        {
            string[] recipients = RecipientsTextBox.Text.Split(new[] { Environment.NewLine, " "}, StringSplitOptions.None);

            foreach(Control c in RecipientLabelsPanel.Controls)
            {
                c.Dispose();
            }

            Console.Out.WriteLine(recipients.Length);
            for(int i = 0; i < recipients.Length; i++)
            {
                Label newLabel = new Label();
                RecipientLabelsPanel.Controls.Add(newLabel);
                newLabel.Text = recipients[i];
                newLabel.Location = new Point(0, i * 17);
                newLabel.Size = new Size(179, 15);
                allRecipients.Add(recipients[i]);

                if (!IsValidEmail(recipients[i]))
                {
                    newLabel.ForeColor = Color.Red;
                }
            }
        }

        private void CloseRecipientButton_Click(object sender, EventArgs e)
        {
            RecipientPanel.Visible = false;
        }

        bool IsValidEmail(string email)
        {
            if(email.Contains("@") && email.Contains("."))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}