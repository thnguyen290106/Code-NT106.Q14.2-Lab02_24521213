using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Code_NT106.Q14._2_Lab02_24521213
{
    public partial class Bai01 : Form
    {
        public Bai01()
        {
            InitializeComponent();
        }

        private void btnReadFile_Click(object sender, EventArgs e)
        {
            if (!File.Exists("input1.txt"))
            {
                MessageBox.Show("Chưa tạo file input1.txt");
                return;
            }
            FileInfo file = new FileInfo("input1.txt");
            if (file.Length == 0) {
                MessageBox.Show("File input1.txt rỗng");
                return;
            }
            StreamReader read = new StreamReader("input1.txt");
            string content = read.ReadToEnd();
            txtContentOfFile.Text = content;
            read.Close();
            MessageBox.Show("Đọc file thành công");
        }

        private void btnWriteFile_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtContentOfFile.Text))
            {
                MessageBox.Show("Chưa có nội dung để lưu");
                return;
            }
            StreamWriter write = new StreamWriter("output1.txt");
            write.Write(txtContentOfFile.Text.ToUpper());
            write.Close();
            MessageBox.Show("Đã lưu nội dung dưới dạng in hoa vào file output1.txt");
        }

        private void txtContentOfFile_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
