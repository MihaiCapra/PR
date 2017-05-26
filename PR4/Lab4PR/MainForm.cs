using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Limilabs.Mail;

namespace Lab4PR
{
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        private List<OpenPop.Mime.Message> _listMailsRecieved;
        private const string HostName = "pop.gmail.com";
        private const int Port = 995;
        private const bool IsSSL = true;
        public MainForm()
        {
            InitializeComponent();
            txtBoxPassword.PasswordChar = '*';
            _listMailsRecieved = new List<OpenPop.Mime.Message>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Height = 300;
            btnSend.Visible = false;
            btnUpdate.Visible = false;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (btnLogin.Text.Equals("Log Out"))
            {
                btnLogin.Text = "Log in";
                txtBoxLogin.Enabled = true;
                txtBoxPassword.Enabled = true;
                btnSend.Visible = false;
                btnUpdate.Visible = false;
                btnUpdate.Enabled = false;
                btnUpdate.Text = "Actualizare...";
                return;
            }
            else
            {
                if (!WebHelper.CheckForInternetConnection())
                    return;
                if (!WebHelper.IsEmail(txtBoxLogin.Text))
                {
                    MessageBox.Show("Email-ul introdus este unul gresit", "Error");
                    return;
                }
                else if (!(txtBoxPassword.Text.Length > 5))
                {
                    MessageBox.Show("Parola introdusa este prea mica", "Error");
                    return;
                }

                WebHelper.LoggedSuccess += (o, ew) => this.BeginInvoke(new MethodInvoker(delegate
                {
                    btnSend.Visible = true;
                    btnUpdate.Visible = true;
                    btnLogin.Text = "Log Out";
                    txtBoxLogin.Enabled = false;
                    txtBoxPassword.Enabled = false;
                }));
                WebHelper.LooadedAllMails += (o, ew) => this.BeginInvoke(new MethodInvoker(delegate { btnUpdate.Enabled = true; btnUpdate.Text = "Inbox"; }));
                _listMailsRecieved = await WebHelper.GmailsRetrievePOPAsync(IsSSL, Port, HostName, txtBoxLogin.Text, txtBoxPassword.Text);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            var _formSendMessage = new fSendMail(txtBoxLogin.Text, txtBoxPassword.Text);
            _formSendMessage.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!(_listMailsRecieved.Count == 0))
            {
                Inbox _formShowEmails = new Inbox(_listMailsRecieved);
                _formShowEmails.Show();
            }
            else
            {
                MessageBox.Show("Posta nu contine nici un Mail");
            }
        }
    }
}
