using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Formats.Asn1;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Code_NT106.Q14._2_Lab02_24521213
{
    public partial class Bai03 : Form
    {
        public Bai03()
        {
            InitializeComponent();
        }
        private int Prioty(char op)
        {
            if (op == '*' || op == '/') return 2;
            if (op == '+' || op == '-') return 1;
            return 0;
        }
        private decimal? Operation(char operators, decimal b, decimal a)
        {
            if (operators == '+') return a + b;
            else if (operators == '-') return a - b;
            else if (operators == '*') return a * b;
            else
            {
                if (b == 0)
                {
                    MessageBox.Show("Lỗi: Không thể chia cho 0");
                    return null;
                }
                return a / b;
            }
        }
        private decimal? Calculate(string s)
        {
            s = s.Trim();
            if (string.IsNullOrWhiteSpace(s))
            {
                MessageBox.Show("Lỗi: Biểu thức không được để trống");
                return null;
            }
            Stack<decimal> numbers = new Stack<decimal>();
            Stack<char> operators = new Stack<char>();
            string StringNumber = "";
            for (int i = 0; i < s.Length; ++i)
            {
                if (s[i] == ' ') continue;
                if ((s[i] >= '0' && s[i] <= '9') || s[i] == '.') StringNumber += s[i];
                else if ((s[i] == '-' || s[i] == '+') && (i == 0 || s[i - 1] == '(')) StringNumber += s[i];
                else if (s[i] == '(') operators.Push(s[i]);
                else if (s[i] == ')')
                {
                    if (StringNumber != "")
                    {
                        numbers.Push(decimal.Parse(StringNumber));
                        StringNumber = "";
                    }
                    while (operators.Count > 0 && operators.Peek() != '(')
                    {
                        if (numbers.Count < 2)
                        {
                            MessageBox.Show("Lỗi: Biểu thức không hợp lệ - thiếu toán hạng");
                            return null;
                        }
                        decimal b = numbers.Pop();
                        decimal a = numbers.Pop();
                        char op = operators.Pop();
                        decimal? result = Operation(op, b, a);
                        if (result == null) return null;
                        numbers.Push(result.Value);
                    }
                    if (operators.Count == 0)
                    {
                        MessageBox.Show("Lỗi: Biểu thức không hợp lệ - thiếu dấu '('");
                        return null;
                    }
                    operators.Pop();
                }
                else if (s[i] == '+' || s[i] == '-' || s[i] == '*' || s[i] == '/')
                {
                    if (StringNumber == "" && numbers.Count == 0)
                    {
                        MessageBox.Show("Lỗi: Biểu thức không hợp lệ - toán tử không hợp lệ ở đầu");
                        return null;
                    }
                    if (StringNumber != "")
                    {
                        numbers.Push(decimal.Parse(StringNumber));
                        StringNumber = "";
                    }
                    while (operators.Count > 0 && operators.Peek() != '(' && Prioty(operators.Peek()) >= Prioty(s[i]))
                    {
                        if (numbers.Count < 2)
                        {
                            MessageBox.Show("Lỗi: Biểu thức không hợp lệ - thiếu toán hạng");
                            return null;
                        }
                        decimal b = numbers.Pop();
                        decimal a = numbers.Pop();
                        char op = operators.Pop();
                        decimal? result = Operation(op, b, a);
                        if (result == null) return null;
                        numbers.Push(result.Value);
                    }
                    operators.Push(s[i]);
                }
                else
                {
                    MessageBox.Show($"Lỗi: Ký tự '{s[i]}' không được phép trong biểu thức");
                    return null;
                }
            }
            if (StringNumber != "")
            {
                numbers.Push(decimal.Parse(StringNumber));
            }
            while (operators.Count > 0)
            {
                if (numbers.Count < 2)
                {
                    MessageBox.Show("Lỗi: Biểu thức không hợp lệ - thiếu toán hạng");
                    return null;
                }
                decimal b = numbers.Pop();
                decimal a = numbers.Pop();
                char op = operators.Pop();
                if (op == '(')
                {
                    MessageBox.Show("Lỗi: Biểu thức không hợp lệ - thiếu dấu ')'");
                    return null;
                }
                decimal? result = Operation(op, b, a);
                if (result == null) return null;
                numbers.Push(result.Value);
            }
            if (numbers.Count != 1)
            {
                MessageBox.Show("Lỗi: Biểu thức không hợp lệ - số lượng toán hạng không đúng");
                return null;
            }
            decimal finalResult = numbers.Pop();
            return finalResult;
        }
        private void btnRead_Click(object sender, EventArgs e)
        {
            try
            {
                string[] lines = File.ReadAllLines("input3.txt");
                txtShow.Text = "";
                for (int i = 0; i < lines.Length; ++i)
                {
                    decimal? res = Calculate(lines[i]);
                    if (res != null) txtShow.Text += lines[i] + " = " + res.Value.ToString() + "\r\n";
                    else return;
                }
                StreamWriter write = new StreamWriter("output3.txt");
                write.Write(txtShow.Text);
                write.Close();
                MessageBox.Show("Đã ghi kết quả vào file output3.txt");
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Không tìm thấy file input3.txt");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}
