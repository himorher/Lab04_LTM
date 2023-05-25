using ltm_lab4;
using System.Runtime.Intrinsics.X86;

namespace _21521581_21520406
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //bai 2
        {
            Bai1 getHTMLweb = new Bai1();
            getHTMLweb.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e) //bai 4
        {
            Bai2 sendPOST = new Bai2();
            sendPOST.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e) //bai 5
        {
            Bai3 downloadWeb = new Bai3();
            downloadWeb.ShowDialog();
        }
        private void button4_Click(object sender, EventArgs e) //bai 5
        {
            Bai4 WebBrowser = new Bai4();
            WebBrowser.ShowDialog();
        }
        private void button5_Click(object sender, EventArgs e) //bai 5
        {
            Bai5 WebServer = new Bai5();
            WebServer.ShowDialog();
        }
        private void button6_Click(object sender, EventArgs e) //bai 5
        {
            Bai6 newsWebsite = new Bai6();
            newsWebsite.ShowDialog();
        }
    }
}