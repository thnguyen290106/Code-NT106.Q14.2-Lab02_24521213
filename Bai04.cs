using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Code_NT106.Q14._2_Lab02_24521213
{
    public struct Student
    {
        public string Name;
        public int ID;
        public string Phone;
        public float Course1;
        public float Course2;
        public float Course3;
        public float Average;
    }
    public partial class Bai04 : Form
    {
        private List<Student> studentList = new List<Student>();
        private int Page = 0;
        public Bai04()
        {
            InitializeComponent();
        }
        private bool Legit(string[] lines)
        {
            if (lines.Length < 6)
            {
                MessageBox.Show("Vui lòng nhập đủ 6 dòng thông tin!");
                return false;
            }
            if (string.IsNullOrWhiteSpace(lines[0]))
            {
                MessageBox.Show("Tên không được rỗng!");
                return false;
            }
            if (!int.TryParse(lines[1].Trim(), out int id) || lines[1].Trim().Length != 8)
            {
                MessageBox.Show("MSSV phải là số có 8 chữ số!");
                return false;
            }
            string phone = lines[2].Trim();
            if (phone.Length != 10 || !phone.StartsWith("0"))
            {
                MessageBox.Show("Số điện thoại phải có 10 chữ số và bắt đầu bằng 0!");
                return false;
            }
            if (!float.TryParse(lines[3].Trim(), out float c1) || c1 < 0 || c1 > 10)
            {
                MessageBox.Show("Điểm môn 1 phải là số từ 0 đến 10!");
                return false;
            }
            if (!float.TryParse(lines[4].Trim(), out float c2) || c2 < 0 || c2 > 10)
            {
                MessageBox.Show("Điểm môn 2 phải là số từ 0 đến 10!");
                return false;
            }
            if (!float.TryParse(lines[5].Trim(), out float c3) || c3 < 0 || c3 > 10)
            {
                MessageBox.Show("Điểm môn 3 phải là số từ 0 đến 10!");
                return false;
            }
            return true;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string content = textBox2.Text.Trim();
            if (string.IsNullOrEmpty(content))
            {
                MessageBox.Show("Vui lòng nhập thông tin sinh viên!");
                return;
            }
            string[] lines = content.Split(new[] { "\r\n", "\n" }, StringSplitOptions.None);
            if (!Legit(lines)) return;
            Student student;
            student.Name = lines[0].Trim();
            student.ID = int.Parse(lines[1].Trim());
            student.Phone = lines[2].Trim();
            student.Course1 = float.Parse(lines[3].Trim());
            student.Course2 = float.Parse(lines[4].Trim());
            student.Course3 = float.Parse(lines[5].Trim());
            student.Average = 0;
            StreamWriter sw = new StreamWriter("input4.txt", true);
            sw.WriteLine(student.Name);
            sw.WriteLine(student.ID);
            sw.WriteLine(student.Phone);
            sw.WriteLine(student.Course1);
            sw.WriteLine(student.Course2);
            sw.WriteLine(student.Course3);
            sw.WriteLine();
            sw.Close();
            MessageBox.Show("Đã thêm sinh viên vào input4.txt!");
            textBox2.Clear();
        }
        private void btnWrite_Click(object sender, EventArgs e)
        {
            if (!File.Exists("input4.txt"))
            {
                MessageBox.Show("Không tìm thấy file input4.txt!");
                return;
            }

            string[] lines = File.ReadAllLines("input4.txt");
            List<Student> temp = new List<Student>();

            for (int i = 0; i < lines.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(lines[i])) continue;
                if (i + 5 >= lines.Length) break;

                if (!int.TryParse(lines[i + 1].Trim(), out int id))
                {
                    MessageBox.Show($"Lỗi ở dòng {i + 2}: MSSV không hợp lệ!");
                    return;
                }

                if (!float.TryParse(lines[i + 3].Trim(), out float c1))
                {
                    MessageBox.Show($"Lỗi ở dòng {i + 4}: Điểm môn 1 không phải là số!");
                    return;
                }
                if (c1 < 0 || c1 > 10)
                {
                    MessageBox.Show($"Lỗi ở dòng {i + 4}: Điểm môn 1 phải từ 0 đến 10!");
                    return;
                }

                if (!float.TryParse(lines[i + 4].Trim(), out float c2))
                {
                    MessageBox.Show($"Lỗi ở dòng {i + 5}: Điểm môn 2 không phải là số!");
                    return;
                }
                if (c2 < 0 || c2 > 10)
                {
                    MessageBox.Show($"Lỗi ở dòng {i + 5}: Điểm môn 2 phải từ 0 đến 10!");
                    return;
                }

                if (!float.TryParse(lines[i + 5].Trim(), out float c3))
                {
                    MessageBox.Show($"Lỗi ở dòng {i + 6}: Điểm môn 3 không phải là số!");
                    return;
                }
                if (c3 < 0 || c3 > 10)
                {
                    MessageBox.Show($"Lỗi ở dòng {i + 6}: Điểm môn 3 phải từ 0 đến 10!");
                    return;
                }

                Student student;
                student.Name = lines[i].Trim();
                student.ID = id;
                student.Phone = lines[i + 2].Trim();
                student.Course1 = c1;
                student.Course2 = c2;
                student.Course3 = c3;
                student.Average = (student.Course1 + student.Course2 + student.Course3) / 3;
                temp.Add(student);
                i += 6;
            }

            StreamWriter sw = new StreamWriter("output4.txt");
            foreach (var student in temp)
            {
                sw.WriteLine(student.Name);
                sw.WriteLine(student.ID);
                sw.WriteLine(student.Phone);
                sw.WriteLine(student.Course1);
                sw.WriteLine(student.Course2);
                sw.WriteLine(student.Course3);
                sw.WriteLine(student.Average.ToString("F2"));
                sw.WriteLine();
            }
            sw.Close();
            MessageBox.Show("Đã đọc file input4.txt, tính điểm TB và ghi vào file output4.txt!\n Có tổng cộng: " + temp.Count + " sinh viên");
        }
        private void DisplayStudent(int i)
        {
            if (studentList == null || studentList.Count == 0) return;
            if (i < 0 || i >= studentList.Count) return;
            Student student = studentList[i];
            txtName.Text = student.Name;
            txtID.Text = student.ID.ToString();
            txtPhone.Text = student.Phone;
            txtCourse1.Text = student.Course1.ToString();
            txtCourse2.Text = student.Course2.ToString();
            txtCourse3.Text = student.Course3.ToString();
            txtAverage.Text = student.Average.ToString("F2");
            lblPage.Text = (i + 1).ToString();
        }
        private void btnRead_Click(object sender, EventArgs e)
        {
            if (!File.Exists("input4.txt"))
            {
                MessageBox.Show("Không tìm thấy file input4.txt!");
                return;
            }

            string[] lines = File.ReadAllLines("input4.txt");
            if (lines.Length == 0)
            {
                MessageBox.Show("File input4.txt rỗng!");
                return;
            }
            studentList = new List<Student>();

            for (int i = 0; i < lines.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(lines[i])) continue;
                if (i + 5 >= lines.Length) break;

                if (!int.TryParse(lines[i + 1].Trim(), out int id))
                {
                    MessageBox.Show($"Lỗi ở dòng {i + 2}: MSSV không hợp lệ!");
                    return;
                }

                if (!float.TryParse(lines[i + 3].Trim(), out float c1))
                {
                    MessageBox.Show($"Lỗi ở dòng {i + 4}: Điểm môn 1 không phải là số!");
                    return;
                }
                if (c1 < 0 || c1 > 10)
                {
                    MessageBox.Show($"Lỗi ở dòng {i + 4}: Điểm môn 1 phải từ 0 đến 10!");
                    return;
                }

                if (!float.TryParse(lines[i + 4].Trim(), out float c2))
                {
                    MessageBox.Show($"Lỗi ở dòng {i + 5}: Điểm môn 2 không phải là số!");
                    return;
                }
                if (c2 < 0 || c2 > 10)
                {
                    MessageBox.Show($"Lỗi ở dòng {i + 5}: Điểm môn 2 phải từ 0 đến 10!");
                    return;
                }

                if (!float.TryParse(lines[i + 5].Trim(), out float c3))
                {
                    MessageBox.Show($"Lỗi ở dòng {i + 6}: Điểm môn 3 không phải là số!");
                    return;
                }
                if (c3 < 0 || c3 > 10)
                {
                    MessageBox.Show($"Lỗi ở dòng {i + 6}: Điểm môn 3 phải từ 0 đến 10!");
                    return;
                }

                Student student;
                student.Name = lines[i].Trim();
                student.ID = id;
                student.Phone = lines[i + 2].Trim();
                student.Course1 = c1;
                student.Course2 = c2;
                student.Course3 = c3;
                student.Average = (student.Course1 + student.Course2 + student.Course3) / 3;
                studentList.Add(student);
                i += 6;
            }

            if (studentList.Count > 0)
            {
                Page = 0;
                DisplayStudent(Page);
            }
            MessageBox.Show("Đã đọc " + studentList.Count + " sinh viên!");
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            if (studentList == null || studentList.Count == 0)
            {
                MessageBox.Show("Chưa có dữ liệu!");
                return;
            }
            if (Page > 0)
            {
                Page--;
                DisplayStudent(Page);
            }
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (studentList == null || studentList.Count == 0)
            {
                MessageBox.Show("Chưa có dữ liệu!");
                return;
            }
            if (Page < studentList.Count - 1)
            {
                Page++;
                DisplayStudent(Page);
            }
        }
    }
}
