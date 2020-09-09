using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBrowser
{
    public partial class WebBrowser : Form
    {
        string url = "-1";
        public WebBrowser()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string s = "https://www.google.com/";
            comboBox1.Text = s;
            Uri myURL = new Uri(s);
            webBrowser1.Url = myURL;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            webBrowser1.Stop();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            url = comboBox1.Text;
            if (url.Equals("-1") == false)
            {
                if (url.StartsWith("https://"))
                {
                    Uri myURL = new Uri(url);
                    webBrowser1.Url = myURL;
                }
                else
                {
                    if (url.StartsWith("www."))
                    {
                        url = "https://+url";
                        Uri myURL = new Uri(url);
                        webBrowser1.Url = myURL;
                    }
                    else
                    {
                        url = "https://www." + url;
                        Uri myURL = new Uri(url);
                        webBrowser1.Url = myURL;
                    }
                }

                comboBox1.Text = url;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}

