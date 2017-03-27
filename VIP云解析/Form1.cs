using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VIP云解析
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cloudAnalysis_Click(object sender, EventArgs e)
        {
            string url = textUrl.Text;
            string videoUrl = url.Substring(url.LastIndexOf("/") + 1);
            string outVideoUrl = "http://api.47ks.com/webcloud/?v=" + url;

        }

        private void play_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = textUrl.Text;
            if (string.IsNullOrEmpty(url))
            {
                MessageBox.Show("请输入视频链接！");
                return;
            }
            if (!url.EndsWith(".html"))
            {
                url += ".html";
            }
            string videoUrl = url.Substring(url.LastIndexOf("/") + 1);
            string outVideoUrl = "";
            if (rbtOne.Checked)
            {
                outVideoUrl = "http://api.47ks.com/webcloud/?v=" + url;

            }
            else
            {
                outVideoUrl = "http://yun.mt2t.com/yun?url=" + url;
            }
            System.Diagnostics.Process.Start("chrome.exe", outVideoUrl);
        }
    }
}
