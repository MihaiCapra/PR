using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;

namespace linkChecker
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {   
        public Form1()
        {
            InitializeComponent();
            urlTextBox.Text = "http://google.com";
        }

        private void buttonExecute_Click(object sender, EventArgs e)
        {
            try
            {   
                if (resultRTB.Text != "")  resultRTB.Text="";
                if (!urlTextBox.Text.StartsWith("http://") && !urlTextBox.Text.StartsWith("ftp:/") && !urlTextBox.Text.StartsWith("https://")) urlTextBox.Text = "http://" + urlTextBox.Text;
                if (resultLabel.Text != "Result:") resultLabel.Text = "Result:";
                WebRequest request = WebRequest.Create(urlTextBox.Text);
                WebResponse response = request.GetResponse();
                Stream stream = response.GetResponseStream();
                StreamReader reader = new StreamReader(stream);
                string status = ((HttpWebResponse)response).StatusDescription;
                resultRTB.Text = "Checking>.. " + urlTextBox.Text + " Status " + status + "\n";

                string pattern = @"(((http|https|ftp)+\:/\/)[&#95;a-z0-9\/&#95;:@=.+?,##%&~-]*[^.|\'|""|\# |!|\(|?|,| |>|<|;|\)])";

                MatchCollection numberoflinks = Regex.Matches(reader.ReadToEnd(), pattern,RegexOptions.Singleline);
                resultLabel.Text = "Results found " + numberoflinks;

                int counter = 0;
                foreach (Match m in numberoflinks)
                {
                    string link = m.Groups[1].Value;
                    try
                    {
                        WebRequest newrequest = WebRequest.Create(link);
                        WebResponse newresponse = newrequest.GetResponse();
                        resultRTB.AppendText("\n" + link + "  Status " + ((HttpWebResponse)newresponse).StatusCode);
                        newresponse.Close();
                        counter++;
                        resultLabel.Text = "Results found " + counter;
                    }
                    catch (Exception ex)
                    {
                        resultRTB.AppendText("\n" + link + " " + ex.Message);
                        counter++;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
