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
using System.IO;

namespace PR3
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        string Url = "http://google.com";
        string postUrl = "https://requestb.in/18aotrt1";
        string postData = "POST TEST";

        public Form1()
        {
            InitializeComponent();
            optionsComboBox.SelectedIndex = 0;
            urlBox.Text = "http://google.com/";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            resultRTB.Text = "";

            if (optionsComboBox.SelectedIndex == 2){
                Url = urlBox.Text;
                urlBox.Text = postUrl;
                textBox.Text = postData;
                urlData.Visible = true;
                textBox.Visible = true;
            }
            else if (optionsComboBox.SelectedIndex != 2){
                if (urlData.Visible == true || textBox.Visible == true){
                    urlBox.Text = Url;
                    urlData.Visible = false;
                    textBox.Visible = false;
                }
            }
        }

        private void buttonExecute_Click(object sender, EventArgs e)
        {
            if (!urlBox.Text.StartsWith("http://") && !urlBox.Text.StartsWith("ftp:/") && !urlBox.Text.StartsWith("https://")) urlBox.Text = "http://" + urlBox.Text;

            if (optionsComboBox.SelectedIndex == 0)
            {
                try
                {   
                    WebRequest request = WebRequest.Create(urlBox.Text);
                    request.Credentials = CredentialCache.DefaultCredentials;
                    WebResponse response = request.GetResponse();
                    resultRTB.AppendText("Status " + ((HttpWebResponse)response).StatusDescription + "\n\n");
                    Stream dataStream = response.GetResponseStream();
                    StreamReader reader = new StreamReader(dataStream);
                    resultRTB.AppendText(reader.ReadToEnd());
                    reader.Close();
                    response.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                
            }
            else if (optionsComboBox.SelectedIndex == 1)
            {
                try
                {
                    WebRequest request = WebRequest.Create(urlBox.Text);
                    request.Credentials = CredentialCache.DefaultCredentials;
                    request.Method = "HEAD";
                    WebResponse response = request.GetResponse();
                    resultRTB.AppendText("Status " + ((HttpWebResponse)response).StatusDescription + "\n\n");
                    resultRTB.AppendText(response.Headers.ToString());
                    response.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }

            }
            else if (optionsComboBox.SelectedIndex == 2)
            {
                try
                {
                    postData = textBox.Text;
                    WebRequest request = WebRequest.Create(postUrl);
                    request.Method = "POST";
                    byte[] byteArray = Encoding.UTF8.GetBytes(postData);
                    request.ContentType = "application/x-www-form-urlencoded"; 
                    request.ContentLength = byteArray.Length;
                    Stream dataStream = request.GetRequestStream();
                    dataStream.Write(byteArray, 0, byteArray.Length);
                    dataStream.Close();
                    WebResponse response = request.GetResponse();
                    resultRTB.AppendText("Status " + ((HttpWebResponse)response).StatusDescription + "\n\n");
                    dataStream = response.GetResponseStream();
                    StreamReader reader = new StreamReader(dataStream);
                    resultRTB.AppendText(reader.ReadToEnd());
                    reader.Close();
                    dataStream.Close();
                    response.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            resultRTB.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
