using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using HtmlAgilityPack;

namespace LatestAnimu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HtmlWeb web = new HtmlWeb();
            HtmlAgilityPack.HtmlDocument document = web.Load("http://www.gogoanime.to/");
            HtmlNode[] nodes = document.DocumentNode.SelectNodes(@"//td[@class='redgr']//a").ToArray();
            foreach (HtmlNode node in nodes)
            {
                String[]items={node.InnerText, node.Attributes["href"].Value};
                lvReleases.Items.Add(new ListViewItem(items));
            }
            Console.ReadLine();
        }

        private void lvReleases_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                Process.Start(lvReleases.SelectedItems[0].SubItems[1].Text);
            }
            catch
            {
            }
        }
    }
}
