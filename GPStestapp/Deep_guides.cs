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

namespace GPStestapp
{
    public partial class Deep_guides : Form
    {
        
        public Deep_guides()
        {
            InitializeComponent();
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
            HtmlNode NoAltElements = HD.DocumentNode.SelectSingleNode("//div[@class='expando']//div[@class='md']");
            if (NoAltElements != null)
                richTextBox1.Text = NoAltElements.InnerText;
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
            HtmlNode NoAltElements = HD.DocumentNode.SelectSingleNode("//div[@class='expando']//div[@class='md']");
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
            HtmlNode NoAltElements = HD.DocumentNode.SelectSingleNode("//div[@class='expando']//div[@class='md']");
            if (NoAltElements != null)
                richTextBox1.Text = NoAltElements.InnerText;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
