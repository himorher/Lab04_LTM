using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21521581_21520406
{
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }
        private string getSource(string URL) //hàm lấy source khi nhập vào URL
        {
            try
            {
                HtmlWeb web = new HtmlWeb();
                HtmlAgilityPack.HtmlDocument content = new HtmlAgilityPack.HtmlDocument();
                content = web.Load(URL);
                string s = content.Text;
                return s;
            }
            catch
            {
                return "URL không tồn tại!";
            }
        }
        private string getHTML(string URL) //hàm lấy file HTML của URL nhập vào
        {
            // Create a request for the URL.
            WebRequest request = WebRequest.Create(URL);
            // Get the response. 
            WebResponse response = request.GetResponse();
            // Get the stream containing content returned by the server. 
            Stream dataStream = response.GetResponseStream();
            // Open the stream using a StreamReader for easy access. 
            StreamReader reader = new StreamReader(dataStream);
            // Read the content. 
            string responseFromServer = reader.ReadToEnd();
            // Close the response. 
            response.Close();
            return responseFromServer;
        }

        private void button1_Click(object sender, EventArgs e) //button get HTML 
        {
            if (getSource(textBox1.Text) == "URL không tồn tại!") //nếu kết quả kiểm tra source trả về URL không tồn tại, xuất thông báo.
            {
                MessageBox.Show("URL không tồn tại!");
            }
            else
            {
                richTextBox1.Text = getHTML(textBox1.Text); //xuất nội dung file HTML ra richTextBox
            }
        }

        private void button2_Click(object sender, EventArgs e) //button close
        {
            this.Close();
        }
    }
}
