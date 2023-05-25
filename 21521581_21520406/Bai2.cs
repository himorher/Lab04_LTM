using HtmlAgilityPack;
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
    public partial class Bai2 : Form
    {
        public Bai2()
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
        private void button1_Click(object sender, EventArgs e) //gửi dữ liệu bất kì lên địa chỉ được chỉ định ở textbox1
        {
            if (getSource(textBox1.Text) == "URL không tồn tại!") //nếu kết quả kiểm tra source trả về URL không tồn tại, xuất thông báo.
            {
                MessageBox.Show("URL không tồn tại!");
            }
            else
            {
                try
                {
                    string url = textBox1.Text;
                    WebRequest request = WebRequest.Create(url);
                    request.Method = "POST";

                    string post_data = textBox2.Text;
                    byte[] data = Encoding.UTF8.GetBytes(post_data);

                    request.ContentType = "application/x-www-form-urlencoded";
                    request.ContentLength = data.Length;
                    Stream dataStream = request.GetRequestStream();
                    dataStream.Write(data, 0, data.Length);
                    dataStream.Close();

                    WebResponse response = request.GetResponse();

                    dataStream = response.GetResponseStream();
                    StreamReader reader = new StreamReader(dataStream);
                    string responseFromServer = reader.ReadToEnd();
                    richTextBox1.Text = responseFromServer;
                    response.Close();
                    //dataStream.Close();
                    //reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e) //button close
        {
            this.Close();
        }
    }
}
