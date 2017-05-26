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
using System.IO;

namespace Lab4PR
{
    public partial class fSendMail : MetroFramework.Forms.MetroForm
    {
        private string Login;
        private string Password;
        private List<string> AttachmentsList;
        private Dictionary<string, string> AttachmentsHTML;
        private bool isHTML = false;

        public fSendMail(string Login, string Password)
        {
            this.Login = Login;
            this.Password = Password;
            InitializeComponent();
            AttachmentsList = new List<string>();
            AttachmentsHTML = new Dictionary<string, string>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SendMail();
        }
        private void SendMail()
        {

            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            client.EnableSsl = true;
            client.Timeout = 10000;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.Credentials = new NetworkCredential(Login, Password);

            MailMessage message = new MailMessage();
            message.To.Add(toTxtBox.Text);
            message.From = new MailAddress(Login);
            message.Subject = titleTxtBox.Text;
            message.Body = msgTxtBox.Text;

            if (!(AttachmentsList.Count == 0))
            {
                AttachmentsList.ForEach(element =>
                {
                    var _attachment = new Attachment(element);
                    message.Attachments.Add(_attachment);
                });
            }

            string userToken = Login + "__Token";
            client.SendCompleted += (s, ee) =>
            {
                MessageBox.Show("Succesfull!!", "Sent!");
                Close();
            };
            try
            {
                client.SendAsync(message, userToken);

            }
            catch (Exception ex)
            {
                var response = MessageBox.Show(ex.Message, "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                switch (response)
                {
                    case DialogResult.Retry:
                        {
                            SendMail();
                        }
                        break;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog _filesDialog = new OpenFileDialog();
            if (_filesDialog.ShowDialog() == DialogResult.OK)
            {
                attachementsLabel.Text = _filesDialog.FileName.ToString().Split('/').LastOrDefault();
                AttachmentsList.Add(_filesDialog.FileName);
            }
        }

    }
}
