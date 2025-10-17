namespace Code_NT106.Q14._2_Lab02_24521213
{
    partial class Bai03
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnRead = new Button();
            txtShow = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnRead
            // 
            btnRead.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRead.Location = new Point(12, 1);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(176, 77);
            btnRead.TabIndex = 0;
            btnRead.Text = "Đọc file input3.txt";
            btnRead.UseVisualStyleBackColor = true;
            btnRead.Click += btnRead_Click;
            // 
            // txtShow
            // 
            txtShow.Location = new Point(257, 51);
            txtShow.Multiline = true;
            txtShow.Name = "txtShow";
            txtShow.ReadOnly = true;
            txtShow.Size = new Size(531, 398);
            txtShow.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(242, 23);
            label1.Name = "label1";
            label1.Size = new Size(76, 25);
            label1.TabIndex = 2;
            label1.Text = "Kết quả:";
            // 
            // Bai03
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(txtShow);
            Controls.Add(btnRead);
            Name = "Bai03";
            Text = "Bài 03 - Đọc và Ghi file và tính toán";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRead;
        private TextBox txtShow;
        private Label label1;
    }
}