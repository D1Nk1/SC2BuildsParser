using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;
using System.Net;
using System.Text.RegularExpressions;

namespace GPStestapp
{
    public partial class Builds : Form
    {
        
        public Builds()
        {
            InitializeComponent();
            /* if (NoAltElements != null)
             {
                 foreach (HtmlNode HN in NoAltElements)
                 {
                     string outputText = HN.InnerText;
                     richTextBox1.Text = outputText;
                 }
             }*/
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string html = "https://www.reddit.com/r/allthingsprotoss/comments/3xi8zi/build_of_the_week_pvz_classiccjheros_fast_3rd/";
            HtmlAgilityPack.HtmlDocument HD = new HtmlAgilityPack.HtmlDocument();
            var web = new HtmlWeb
            {
                AutoDetectEncoding = false,
                OverrideEncoding = Encoding.UTF8,
            };
            HD = web.Load(html);
            HtmlNode NoAltElements = HD.DocumentNode.SelectSingleNode("//div[@class='expando']//div[@class='md']//ul");
            if (NoAltElements != null)
                richTextBox1.Text = NoAltElements.InnerText;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string html = "https://www.reddit.com/r/allthingsprotoss/comments/3wfl8g/build_of_the_week_pvp_partings_nexus_first_into/";
            HtmlAgilityPack.HtmlDocument HD = new HtmlAgilityPack.HtmlDocument();
            var web = new HtmlWeb
            {
                AutoDetectEncoding = false,
                OverrideEncoding = Encoding.UTF8,
            };
            HD = web.Load(html);
            HtmlNode NoAltElements = HD.DocumentNode.SelectSingleNode("//div[@class='expando']//div[@class='md']//ul");
            if (NoAltElements != null)
                richTextBox1.Text = NoAltElements.InnerText;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string html = "https://www.reddit.com/r/allthingsprotoss/comments/3yfnsm/build_of_the_week_pvt_myungsiks_4gate_warp_prism/";
            HtmlAgilityPack.HtmlDocument HD = new HtmlAgilityPack.HtmlDocument();
            var web = new HtmlWeb
            {
                AutoDetectEncoding = false,
                OverrideEncoding = Encoding.UTF8,
            };
            HD = web.Load(html);
            HtmlNode NoAltElements = HD.DocumentNode.SelectSingleNode("//div[@class='expando']//div[@class='md']//ul");
            if (NoAltElements != null)
                richTextBox1.Text = NoAltElements.InnerText;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://lotv.spawningtool.com/build/pvx/");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Deep_guides d = new Deep_guides();
            d.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string html = textBox1.Text;
            HtmlAgilityPack.HtmlDocument HD = new HtmlAgilityPack.HtmlDocument();
            var web = new HtmlWeb
            {
                AutoDetectEncoding = false,
                OverrideEncoding = Encoding.UTF8,
            };
            
            HD = web.Load(html);
            HtmlNode NoAltElements = HD.DocumentNode.SelectSingleNode("//div[@class='row']//div[@class='col-md-8']//table[@id='build-1']");
            if (NoAltElements != null)
            {
                richTextBox1.Text = NoAltElements.InnerText;
                richTextBox1.Text = Regex.Replace(richTextBox1.Text, "&nbsp;", "\n").Trim();
            }
        }
    }
}
