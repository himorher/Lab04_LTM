using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21521581_21520406
{
    public partial class Bai4 : Form
    {
        public Bai4()
        {
            InitializeComponent();
        }
        private string GetHTML(string szURL) //để lấy source từ trang web
        {
            // Create a request for the URL.
            WebRequest request = WebRequest.Create(szURL);
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

        private void button1_Click(object sender, EventArgs e) //button xem nội dung web: hiện giao diện trang web lên form
        {
            webView21.Source = new Uri(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e) //button download file HTML: lưu file HTML của trang web
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.ShowDialog();
            WebClient webClient = new WebClient();
            Stream response = webClient.OpenRead(textBox1.Text);
            webClient.DownloadFile(textBox1.Text, saveFileDialog.FileName);
        }

        private void button3_Click(object sender, EventArgs e) //button xem source: hiển thị source HTML của trang web ra form Bai4_ViewSource
        {
            var html = GetHTML(textBox1.Text);

            Bai4_ViewSource viewSource = new Bai4_ViewSource(html);
            viewSource.Show();
        }
    }
}
