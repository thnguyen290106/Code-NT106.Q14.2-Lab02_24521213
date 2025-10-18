using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;
using System.Net;

namespace Code_NT106.Q14._2_Lab02_24521213
{
    public partial class Bai06 : Form
    {
        private string connectionString = "Data Source=Foods.db;Version=3;";
        private Random random = new Random();

        public Bai06()
        {
            InitializeComponent();
        }

        private void Bai06_Load(object sender, EventArgs e)
        {
            InitializeDatabase();
            LoadDataToListView();
        }

        private void InitializeDatabase()
        {
            try
            {
                if (!File.Exists("Foods.db"))
                {
                    SQLiteConnection.CreateFile("Foods.db");
                }

                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();

                    string createUserTable = @"CREATE TABLE IF NOT EXISTS NguoiDung (
                        IDNCC INTEGER PRIMARY KEY AUTOINCREMENT,
                        HoVaTen TEXT NOT NULL,
                        QuyenHan TEXT DEFAULT 'User'
                    )";

                    string createFoodTable = @"CREATE TABLE IF NOT EXISTS MonAn (
                        IDMA INTEGER PRIMARY KEY AUTOINCREMENT,
                        TenMonAn TEXT NOT NULL,
                        HinhAnh TEXT,
                        IDNCC INTEGER,
                        FOREIGN KEY (IDNCC) REFERENCES NguoiDung(IDNCC)
                    )";

                    using (SQLiteCommand cmd = new SQLiteCommand(createUserTable, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }

                    using (SQLiteCommand cmd = new SQLiteCommand(createFoodTable, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }

                    AddDefaultData(conn);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khởi tạo database: {ex.Message}");
            }
        }

        private void AddDefaultData(SQLiteConnection conn)
        {
            string checkData = "SELECT COUNT(*) FROM MonAn";
            using (SQLiteCommand cmd = new SQLiteCommand(checkData, conn))
            {
                long count = (long)cmd.ExecuteScalar();
                if (count == 0)
                {
                    string[] defaultUsers = { "Trương Vĩnh Nguyên", "Reyna", "Đào Mạnh Nhân" };
                    foreach (string user in defaultUsers)
                    {
                        string insertUser = "INSERT INTO NguoiDung (HoVaTen, QuyenHan) VALUES (@HoVaTen, 'User')";
                        using (SQLiteCommand cmdUser = new SQLiteCommand(insertUser, conn))
                        {
                            cmdUser.Parameters.AddWithValue("@HoVaTen", user);
                            cmdUser.ExecuteNonQuery();
                        }
                    }

                    string[][] defaultFoods = new string[][]
                    {
                        new string[] { "Phở", "https://cdn2.fptshop.com.vn/unsafe/1920x0/filters:format(webp):quality(75)/cach_nau_pho_bo_nam_dinh_0_1d94be153c.png", "1" },
                        new string[] { "Bún bò Huế", "https://mms.img.susercontent.com/vn-11134513-7r98o-lsvdf3utj44905@resize_ss640x400!@crop_w640_h400_cT", "2" },
                        new string[] { "Cơm tấm", "https://sakos.vn/wp-content/uploads/2024/09/bia.jpg", "3" },
                        new string[] { "Bánh mì", "https://cleverjunior.vn/wp-content/uploads/2022/08/gioi-thieu-banh-mi-bang-tieng-anh-1-768x480.jpg", "1" },
                        new string[] { "Gỏi cuốn", "https://cdn.tcdulichtphcm.vn/upload/2-2021/images/2021-05-14/1620967472-5fd6cc95e23f4d1eb34009678c2d6556.jpg", "2" }
                    };

                    foreach (string[] food in defaultFoods)
                    {
                        string insertFood = "INSERT INTO MonAn (TenMonAn, HinhAnh, IDNCC) VALUES (@TenMonAn, @HinhAnh, @IDNCC)";
                        using (SQLiteCommand cmdFood = new SQLiteCommand(insertFood, conn))
                        {
                            cmdFood.Parameters.AddWithValue("@TenMonAn", food[0]);
                            cmdFood.Parameters.AddWithValue("@HinhAnh", food[1]);
                            cmdFood.Parameters.AddWithValue("@IDNCC", food[2]);
                            cmdFood.ExecuteNonQuery();
                        }
                    }
                }
            }
        }

        private void LoadDataToListView()
        {
            try
            {
                listViewMonAn.Items.Clear();

                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();
                    string query = @"SELECT m.IDMA, m.TenMonAn, m.HinhAnh, n.HoVaTen 
                                   FROM MonAn m 
                                   INNER JOIN NguoiDung n ON m.IDNCC = n.IDNCC 
                                   ORDER BY m.IDMA";

                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ListViewItem item = new ListViewItem(reader["IDMA"].ToString());
                                item.SubItems.Add(reader["TenMonAn"].ToString());
                                item.SubItems.Add(reader["HinhAnh"].ToString());
                                item.SubItems.Add(reader["HoVaTen"].ToString());
                                listViewMonAn.Items.Add(item);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải dữ liệu: {ex.Message}");
            }
        }

        private bool IsValidImageUrl(string url)
        {
            if (string.IsNullOrEmpty(url)) return false;

            string[] validExtensions = { ".jpg", ".jpeg", ".png", ".gif", ".bmp", ".webp" };

            try
            {
                Uri uri = new Uri(url);
                string extension = System.IO.Path.GetExtension(uri.AbsolutePath).ToLower();
                return validExtensions.Contains(extension);
            }
            catch
            {
                return false;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string hoVaTen = txtHoVaTen.Text.Trim();
            string tenMonAn = txtTenMonAn.Text.Trim();
            string hinhAnh = txtHinhAnh.Text.Trim();

            if (string.IsNullOrEmpty(hoVaTen) || string.IsNullOrEmpty(tenMonAn))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ họ tên và tên món ăn!");
                return;
            }

            if (!string.IsNullOrEmpty(hinhAnh) && !IsValidImageUrl(hinhAnh))
            {
                MessageBox.Show("URL không phải là ảnh! Vui lòng nhập URL kết thúc bằng .jpg, .jpeg, .png, .gif, .bmp hoặc .webp");
                return;
            }

            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();

                    int idncc = 0;
                    string checkUser = "SELECT IDNCC FROM NguoiDung WHERE HoVaTen = @HoVaTen";
                    using (SQLiteCommand cmd = new SQLiteCommand(checkUser, conn))
                    {
                        cmd.Parameters.AddWithValue("@HoVaTen", hoVaTen);
                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            idncc = Convert.ToInt32(result);
                        }
                        else
                        {
                            string insertUser = "INSERT INTO NguoiDung (HoVaTen, QuyenHan) VALUES (@HoVaTen, 'User'); SELECT last_insert_rowid();";
                            using (SQLiteCommand cmdUser = new SQLiteCommand(insertUser, conn))
                            {
                                cmdUser.Parameters.AddWithValue("@HoVaTen", hoVaTen);
                                idncc = Convert.ToInt32(cmdUser.ExecuteScalar());
                            }
                        }
                    }

                    string insertFood = "INSERT INTO MonAn (TenMonAn, HinhAnh, IDNCC) VALUES (@TenMonAn, @HinhAnh, @IDNCC)";
                    using (SQLiteCommand cmd = new SQLiteCommand(insertFood, conn))
                    {
                        cmd.Parameters.AddWithValue("@TenMonAn", tenMonAn);
                        cmd.Parameters.AddWithValue("@HinhAnh", string.IsNullOrEmpty(hinhAnh) ? "" : hinhAnh);
                        cmd.Parameters.AddWithValue("@IDNCC", idncc);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Thêm món ăn thành công!");

                    txtHoVaTen.Clear();
                    txtTenMonAn.Clear();
                    txtHinhAnh.Clear();
                    LoadDataToListView();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi thêm món ăn: {ex.Message}");
            }
        }

        private void btnTimMonAn_Click(object sender, EventArgs e)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();

                    string countQuery = "SELECT COUNT(*) FROM MonAn";
                    int count = 0;
                    using (SQLiteCommand cmd = new SQLiteCommand(countQuery, conn))
                    {
                        count = Convert.ToInt32(cmd.ExecuteScalar());
                    }

                    if (count == 0)
                    {
                        MessageBox.Show("Chưa có món ăn nào trong database!");
                        return;
                    }

                    string query = @"SELECT m.TenMonAn, m.HinhAnh, n.HoVaTen 
                                   FROM MonAn m 
                                   INNER JOIN NguoiDung n ON m.IDNCC = n.IDNCC 
                                   ORDER BY RANDOM() LIMIT 1";

                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string tenMonAn = reader["TenMonAn"].ToString();
                                string hinhAnh = reader["HinhAnh"].ToString();
                                string nguoiDongGop = reader["HoVaTen"].ToString();

                                lblKetQua.Text = $"{tenMonAn}\n\n(Đóng góp bởi: {nguoiDongGop})";

                                if (!string.IsNullOrEmpty(hinhAnh))
                                {
                                    LoadImageFromUrl(hinhAnh);
                                }
                                else
                                {
                                    pictureBoxMonAn.Image = null;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tìm món ăn: {ex.Message}");
            }
        }

        private void LoadImageFromUrl(string url)
        {
            try
            {
                using (WebClient client = new WebClient())
                {
                    byte[] imageData = client.DownloadData(url);
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        pictureBoxMonAn.Image = Image.FromStream(ms);
                    }
                }
            }
            catch
            {
                pictureBoxMonAn.Image = null;
                MessageBox.Show("Không thể tải hình ảnh từ URL!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa toàn bộ dữ liệu?", "Xác nhận", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                    {
                        conn.Open();

                        string deleteFood = "DELETE FROM MonAn";
                        string deleteUser = "DELETE FROM NguoiDung";

                        using (SQLiteCommand cmd = new SQLiteCommand(deleteFood, conn))
                        {
                            cmd.ExecuteNonQuery();
                        }

                        using (SQLiteCommand cmd = new SQLiteCommand(deleteUser, conn))
                        {
                            cmd.ExecuteNonQuery();
                        }

                        string resetFood = "DELETE FROM sqlite_sequence WHERE name='MonAn'";
                        string resetUser = "DELETE FROM sqlite_sequence WHERE name='NguoiDung'";

                        using (SQLiteCommand cmd = new SQLiteCommand(resetFood, conn))
                        {
                            cmd.ExecuteNonQuery();
                        }

                        using (SQLiteCommand cmd = new SQLiteCommand(resetUser, conn))
                        {
                            cmd.ExecuteNonQuery();
                        }

                        AddDefaultData(conn);
                    }

                    LoadDataToListView();
                    lblKetQua.Text = "";
                    pictureBoxMonAn.Image = null;
                    MessageBox.Show("Đã xóa và khôi phục dữ liệu mẫu!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi xóa dữ liệu: {ex.Message}");
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
