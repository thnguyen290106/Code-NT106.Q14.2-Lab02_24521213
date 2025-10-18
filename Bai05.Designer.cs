namespace Code_NT106.Q14._2_Lab02_24521213
{
    partial class Bai05
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
            btnLoadFile = new Button();
            btnExportReport = new Button();
            panelSeats = new Panel();
            cmbMovie = new ComboBox();
            cmbRoom = new ComboBox();
            txtCustomerName = new TextBox();
            lblCustomerName = new Label();
            lblMovie = new Label();
            lblRoom = new Label();
            btnCalculate = new Button();
            btnReset = new Button();
            txtResult = new TextBox();
            lblSelectedSeats = new Label();
            txtSelectedSeats = new TextBox();
            lblResult = new Label();
            btnExit = new Button();
            progressBar = new ProgressBar();
            lblProgress = new Label();
            SuspendLayout();
            // 
            // btnLoadFile
            // 
            btnLoadFile.BackColor = Color.LightBlue;
            btnLoadFile.Font = new Font("Arial", 10F, FontStyle.Bold);
            btnLoadFile.Location = new Point(25, 25);
            btnLoadFile.Margin = new Padding(3, 4, 3, 4);
            btnLoadFile.Name = "btnLoadFile";
            btnLoadFile.Size = new Size(150, 50);
            btnLoadFile.TabIndex = 0;
            btnLoadFile.Text = "Đọc File";
            btnLoadFile.UseVisualStyleBackColor = false;
            btnLoadFile.Click += btnLoadFile_Click;
            // 
            // btnExportReport
            // 
            btnExportReport.BackColor = Color.LightYellow;
            btnExportReport.Font = new Font("Arial", 10F, FontStyle.Bold);
            btnExportReport.Location = new Point(185, 25);
            btnExportReport.Margin = new Padding(3, 4, 3, 4);
            btnExportReport.Name = "btnExportReport";
            btnExportReport.Size = new Size(150, 50);
            btnExportReport.TabIndex = 2;
            btnExportReport.Text = "Xuất Báo Cáo";
            btnExportReport.UseVisualStyleBackColor = false;
            btnExportReport.Click += btnExportReport_Click;
            // 
            // panelSeats
            // 
            panelSeats.AutoScroll = true;
            panelSeats.BackColor = Color.White;
            panelSeats.BorderStyle = BorderStyle.FixedSingle;
            panelSeats.Location = new Point(25, 275);
            panelSeats.Margin = new Padding(3, 4, 3, 4);
            panelSeats.Name = "panelSeats";
            panelSeats.Size = new Size(838, 650);
            panelSeats.TabIndex = 3;
            panelSeats.Visible = false;
            // 
            // cmbMovie
            // 
            cmbMovie.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMovie.Font = new Font("Arial", 10F);
            cmbMovie.FormattingEnabled = true;
            cmbMovie.Location = new Point(130, 138);
            cmbMovie.Margin = new Padding(3, 4, 3, 4);
            cmbMovie.Name = "cmbMovie";
            cmbMovie.Size = new Size(270, 27);
            cmbMovie.TabIndex = 4;
            cmbMovie.SelectedIndexChanged += cmbMovie_SelectedIndexChanged;
            // 
            // cmbRoom
            // 
            cmbRoom.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRoom.Enabled = false;
            cmbRoom.Font = new Font("Arial", 10F);
            cmbRoom.FormattingEnabled = true;
            cmbRoom.Location = new Point(146, 190);
            cmbRoom.Margin = new Padding(3, 4, 3, 4);
            cmbRoom.Name = "cmbRoom";
            cmbRoom.Size = new Size(270, 27);
            cmbRoom.TabIndex = 5;
            cmbRoom.SelectedIndexChanged += cmbRoom_SelectedIndexChanged;
            // 
            // txtCustomerName
            // 
            txtCustomerName.Font = new Font("Arial", 10F);
            txtCustomerName.Location = new Point(130, 88);
            txtCustomerName.Margin = new Padding(3, 4, 3, 4);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(270, 27);
            txtCustomerName.TabIndex = 6;
            // 
            // lblCustomerName
            // 
            lblCustomerName.AutoSize = true;
            lblCustomerName.Font = new Font("Arial", 10F);
            lblCustomerName.Location = new Point(25, 94);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(82, 19);
            lblCustomerName.TabIndex = 7;
            lblCustomerName.Text = "Họ và tên:";
            // 
            // lblMovie
            // 
            lblMovie.AutoSize = true;
            lblMovie.Font = new Font("Arial", 10F);
            lblMovie.Location = new Point(25, 144);
            lblMovie.Name = "lblMovie";
            lblMovie.Size = new Size(93, 19);
            lblMovie.TabIndex = 8;
            lblMovie.Text = "Chọn phim:";
            // 
            // lblRoom
            // 
            lblRoom.AutoSize = true;
            lblRoom.Font = new Font("Arial", 10F);
            lblRoom.Location = new Point(25, 194);
            lblRoom.Name = "lblRoom";
            lblRoom.Size = new Size(106, 19);
            lblRoom.TabIndex = 9;
            lblRoom.Text = "Phòng chiếu:";
            // 
            // btnCalculate
            // 
            btnCalculate.BackColor = Color.LightGreen;
            btnCalculate.Font = new Font("Arial", 11F, FontStyle.Bold);
            btnCalculate.Location = new Point(869, 274);
            btnCalculate.Margin = new Padding(3, 4, 3, 4);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(120, 50);
            btnCalculate.TabIndex = 10;
            btnCalculate.Text = "Đặt vé";
            btnCalculate.UseVisualStyleBackColor = false;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.LightCoral;
            btnReset.Font = new Font("Arial", 11F, FontStyle.Bold);
            btnReset.Location = new Point(999, 274);
            btnReset.Margin = new Padding(3, 4, 3, 4);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(120, 50);
            btnReset.TabIndex = 11;
            btnReset.Text = "Làm mới";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // txtResult
            // 
            txtResult.Font = new Font("Courier New", 10F);
            txtResult.Location = new Point(869, 374);
            txtResult.Margin = new Padding(3, 4, 3, 4);
            txtResult.Multiline = true;
            txtResult.Name = "txtResult";
            txtResult.ReadOnly = true;
            txtResult.ScrollBars = ScrollBars.Vertical;
            txtResult.Size = new Size(250, 436);
            txtResult.TabIndex = 12;
            // 
            // lblSelectedSeats
            // 
            lblSelectedSeats.AutoSize = true;
            lblSelectedSeats.Font = new Font("Arial", 10F);
            lblSelectedSeats.Location = new Point(869, 174);
            lblSelectedSeats.Name = "lblSelectedSeats";
            lblSelectedSeats.Size = new Size(109, 19);
            lblSelectedSeats.TabIndex = 13;
            lblSelectedSeats.Text = "Ghế đã chọn:";
            // 
            // txtSelectedSeats
            // 
            txtSelectedSeats.Font = new Font("Arial", 10F);
            txtSelectedSeats.Location = new Point(869, 199);
            txtSelectedSeats.Margin = new Padding(3, 4, 3, 4);
            txtSelectedSeats.Multiline = true;
            txtSelectedSeats.Name = "txtSelectedSeats";
            txtSelectedSeats.ReadOnly = true;
            txtSelectedSeats.ScrollBars = ScrollBars.Vertical;
            txtSelectedSeats.Size = new Size(250, 62);
            txtSelectedSeats.TabIndex = 14;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Arial", 10F, FontStyle.Bold);
            lblResult.Location = new Point(869, 349);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(165, 19);
            lblResult.TabIndex = 15;
            lblResult.Text = "THÔNG TIN ĐẶT VÉ";
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.LightSalmon;
            btnExit.Font = new Font("Arial", 10F, FontStyle.Bold);
            btnExit.Location = new Point(869, 819);
            btnExit.Margin = new Padding(3, 4, 3, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(250, 50);
            btnExit.TabIndex = 16;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // progressBar
            // 
            progressBar.Location = new Point(25, 238);
            progressBar.Margin = new Padding(3, 4, 3, 4);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(838, 29);
            progressBar.TabIndex = 17;
            progressBar.Visible = false;
            // 
            // lblProgress
            // 
            lblProgress.AutoSize = true;
            lblProgress.Font = new Font("Arial", 9F);
            lblProgress.Location = new Point(869, 88);
            lblProgress.Name = "lblProgress";
            lblProgress.Size = new Size(0, 17);
            lblProgress.TabIndex = 18;
            // 
            // Bai05
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1150, 938);
            Controls.Add(lblProgress);
            Controls.Add(progressBar);
            Controls.Add(btnExit);
            Controls.Add(lblResult);
            Controls.Add(txtSelectedSeats);
            Controls.Add(lblSelectedSeats);
            Controls.Add(txtResult);
            Controls.Add(btnReset);
            Controls.Add(btnCalculate);
            Controls.Add(lblRoom);
            Controls.Add(lblMovie);
            Controls.Add(lblCustomerName);
            Controls.Add(txtCustomerName);
            Controls.Add(cmbRoom);
            Controls.Add(cmbMovie);
            Controls.Add(panelSeats);
            Controls.Add(btnExportReport);
            Controls.Add(btnLoadFile);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Bai05";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bài 05 – Quản lý phòng vé (phiên bản số 2)";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnLoadFile;
        private System.Windows.Forms.Button btnExportReport;
        private System.Windows.Forms.Panel panelSeats;
        private System.Windows.Forms.ComboBox cmbMovie;
        private System.Windows.Forms.ComboBox cmbRoom;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblMovie;
        private System.Windows.Forms.Label lblRoom;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label lblSelectedSeats;
        private System.Windows.Forms.TextBox txtSelectedSeats;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label lblProgress;
    }
}
