namespace Code_NT106.Q14._2_Lab02_24521213
{
    partial class Bai06
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            txtHinhAnh = new TextBox();
            txtTenMonAn = new TextBox();
            txtHoVaTen = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnThem = new Button();
            groupBox2 = new GroupBox();
            listViewMonAn = new ListView();
            colIDMA = new ColumnHeader();
            colTenMonAn = new ColumnHeader();
            colHinhAnh = new ColumnHeader();
            colNguoiDongGop = new ColumnHeader();
            btnTimMonAn = new Button();
            btnXoa = new Button();
            btnThoat = new Button();
            groupBox3 = new GroupBox();
            pictureBoxMonAn = new PictureBox();
            lblKetQua = new Label();
            label4 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMonAn).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtHinhAnh);
            groupBox1.Controls.Add(txtTenMonAn);
            groupBox1.Controls.Add(txtHoVaTen);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 15);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(380, 275);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thêm món ăn mới";
            // 
            // txtHinhAnh
            // 
            txtHinhAnh.Location = new Point(140, 131);
            txtHinhAnh.Margin = new Padding(3, 4, 3, 4);
            txtHinhAnh.Name = "txtHinhAnh";
            txtHinhAnh.Size = new Size(220, 26);
            txtHinhAnh.TabIndex = 6;
            // 
            // txtTenMonAn
            // 
            txtTenMonAn.Location = new Point(140, 81);
            txtTenMonAn.Margin = new Padding(3, 4, 3, 4);
            txtTenMonAn.Name = "txtTenMonAn";
            txtTenMonAn.Size = new Size(220, 26);
            txtTenMonAn.TabIndex = 5;
            // 
            // txtHoVaTen
            // 
            txtHoVaTen.Location = new Point(140, 31);
            txtHoVaTen.Margin = new Padding(3, 4, 3, 4);
            txtHoVaTen.Name = "txtHoVaTen";
            txtHoVaTen.Size = new Size(220, 26);
            txtHoVaTen.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 135);
            label3.Name = "label3";
            label3.Size = new Size(132, 20);
            label3.TabIndex = 3;
            label3.Text = "Hình ảnh (URL):";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 85);
            label2.Name = "label2";
            label2.Size = new Size(102, 20);
            label2.TabIndex = 2;
            label2.Text = "Tên món ăn:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 35);
            label1.Name = "label1";
            label1.Size = new Size(86, 20);
            label1.TabIndex = 1;
            label1.Text = "Họ và tên:";
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThem.Location = new Point(140, 194);
            btnThem.Margin = new Padding(3, 4, 3, 4);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(120, 56);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(listViewMonAn);
            groupBox2.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(410, 15);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(580, 275);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách món ăn";
            // 
            // listViewMonAn
            // 
            listViewMonAn.Columns.AddRange(new ColumnHeader[] { colIDMA, colTenMonAn, colHinhAnh, colNguoiDongGop });
            listViewMonAn.FullRowSelect = true;
            listViewMonAn.GridLines = true;
            listViewMonAn.Location = new Point(15, 31);
            listViewMonAn.Margin = new Padding(3, 4, 3, 4);
            listViewMonAn.Name = "listViewMonAn";
            listViewMonAn.Size = new Size(550, 224);
            listViewMonAn.TabIndex = 0;
            listViewMonAn.UseCompatibleStateImageBehavior = false;
            listViewMonAn.View = View.Details;
            // 
            // colIDMA
            // 
            colIDMA.Text = "ID";
            colIDMA.Width = 50;
            // 
            // colTenMonAn
            // 
            colTenMonAn.Text = "Tên món ăn";
            colTenMonAn.Width = 180;
            // 
            // colHinhAnh
            // 
            colHinhAnh.Text = "Hình ảnh";
            colHinhAnh.Width = 150;
            // 
            // colNguoiDongGop
            // 
            colNguoiDongGop.Text = "Người đóng góp";
            colNguoiDongGop.Width = 150;
            // 
            // btnTimMonAn
            // 
            btnTimMonAn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTimMonAn.Location = new Point(120, 312);
            btnTimMonAn.Margin = new Padding(3, 4, 3, 4);
            btnTimMonAn.Name = "btnTimMonAn";
            btnTimMonAn.Size = new Size(180, 62);
            btnTimMonAn.TabIndex = 2;
            btnTimMonAn.Text = "Tìm món ăn";
            btnTimMonAn.UseVisualStyleBackColor = true;
            btnTimMonAn.Click += btnTimMonAn_Click;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnXoa.Location = new Point(420, 312);
            btnXoa.Margin = new Padding(3, 4, 3, 4);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(120, 62);
            btnXoa.TabIndex = 3;
            btnXoa.Text = "Xóa DB";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThoat.Location = new Point(710, 312);
            btnThoat.Margin = new Padding(3, 4, 3, 4);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(120, 62);
            btnThoat.TabIndex = 4;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(pictureBoxMonAn);
            groupBox3.Controls.Add(lblKetQua);
            groupBox3.Controls.Add(label4);
            groupBox3.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(12, 400);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(978, 312);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Kết quả";
            // 
            // pictureBoxMonAn
            // 
            pictureBoxMonAn.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxMonAn.Location = new Point(550, 38);
            pictureBoxMonAn.Margin = new Padding(3, 4, 3, 4);
            pictureBoxMonAn.Name = "pictureBoxMonAn";
            pictureBoxMonAn.Size = new Size(400, 250);
            pictureBoxMonAn.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxMonAn.TabIndex = 2;
            pictureBoxMonAn.TabStop = false;
            // 
            // lblKetQua
            // 
            lblKetQua.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKetQua.ForeColor = Color.Red;
            lblKetQua.Location = new Point(20, 112);
            lblKetQua.Name = "lblKetQua";
            lblKetQua.Size = new Size(500, 150);
            lblKetQua.TabIndex = 1;
            lblKetQua.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(140, 50);
            label4.Name = "label4";
            label4.Size = new Size(218, 25);
            label4.TabIndex = 0;
            label4.Text = "Hôm nay bạn nên ăn:";
            // 
            // Bai06
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1002, 729);
            Controls.Add(groupBox3);
            Controls.Add(btnThoat);
            Controls.Add(btnXoa);
            Controls.Add(btnTimMonAn);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Bai06";
            Text = "Bài 06 – Hôm nay ăn gì? (phiên bản số 2)";
            Load += Bai06_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMonAn).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtHinhAnh;
        private System.Windows.Forms.TextBox txtTenMonAn;
        private System.Windows.Forms.TextBox txtHoVaTen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView listViewMonAn;
        private System.Windows.Forms.ColumnHeader colIDMA;
        private System.Windows.Forms.ColumnHeader colTenMonAn;
        private System.Windows.Forms.ColumnHeader colHinhAnh;
        private System.Windows.Forms.ColumnHeader colNguoiDongGop;
        private System.Windows.Forms.Button btnTimMonAn;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pictureBoxMonAn;
        private System.Windows.Forms.Label lblKetQua;
        private System.Windows.Forms.Label label4;
    }
}
