namespace Code_NT106.Q14._2_Lab02_24521213
{
    partial class Bai02
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
            label1 = new Label();
            txtFileName = new TextBox();
            txtSize = new TextBox();
            label2 = new Label();
            txtURL = new TextBox();
            label3 = new Label();
            txtLineCount = new TextBox();
            label4 = new Label();
            txtWordsCount = new TextBox();
            label5 = new Label();
            txtCharacterCount = new TextBox();
            label6 = new Label();
            btnReadFromFile = new Button();
            btnExit = new Button();
            txtShow = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F);
            label1.Location = new Point(12, 95);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 1;
            label1.Text = "File name";
            // 
            // txtFileName
            // 
            txtFileName.Location = new Point(105, 88);
            txtFileName.Name = "txtFileName";
            txtFileName.Size = new Size(311, 27);
            txtFileName.TabIndex = 2;
            txtFileName.TextChanged += txtFileName_TextChanged;
            // 
            // txtSize
            // 
            txtSize.Location = new Point(105, 147);
            txtSize.Name = "txtSize";
            txtSize.Size = new Size(311, 27);
            txtSize.TabIndex = 5;
            txtSize.TextChanged += txtSize_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F);
            label2.Location = new Point(24, 150);
            label2.Name = "label2";
            label2.Size = new Size(36, 20);
            label2.TabIndex = 4;
            label2.Text = "Size";
            // 
            // txtURL
            // 
            txtURL.Location = new Point(105, 204);
            txtURL.Name = "txtURL";
            txtURL.Size = new Size(311, 27);
            txtURL.TabIndex = 7;
            txtURL.TextChanged += txtURL_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F);
            label3.Location = new Point(24, 207);
            label3.Name = "label3";
            label3.Size = new Size(35, 20);
            label3.TabIndex = 6;
            label3.Text = "URL";
            // 
            // txtLineCount
            // 
            txtLineCount.Location = new Point(105, 268);
            txtLineCount.Name = "txtLineCount";
            txtLineCount.Size = new Size(311, 27);
            txtLineCount.TabIndex = 9;
            txtLineCount.TextChanged += txtLineCount_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F);
            label4.Location = new Point(6, 275);
            label4.Name = "label4";
            label4.Size = new Size(79, 20);
            label4.TabIndex = 8;
            label4.Text = "Line Count";
            // 
            // txtWordsCount
            // 
            txtWordsCount.Location = new Point(105, 328);
            txtWordsCount.Name = "txtWordsCount";
            txtWordsCount.Size = new Size(311, 27);
            txtWordsCount.TabIndex = 11;
            txtWordsCount.TextChanged += txtWordsCount_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F);
            label5.Location = new Point(3, 335);
            label5.Name = "label5";
            label5.Size = new Size(94, 20);
            label5.TabIndex = 10;
            label5.Text = "Words Count";
            // 
            // txtCharacterCount
            // 
            txtCharacterCount.Location = new Point(124, 393);
            txtCharacterCount.Name = "txtCharacterCount";
            txtCharacterCount.Size = new Size(311, 27);
            txtCharacterCount.TabIndex = 13;
            txtCharacterCount.TextChanged += txtCharacterCount_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F);
            label6.Location = new Point(3, 396);
            label6.Name = "label6";
            label6.Size = new Size(115, 20);
            label6.TabIndex = 12;
            label6.Text = "Character Count";
            // 
            // btnReadFromFile
            // 
            btnReadFromFile.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReadFromFile.Location = new Point(12, 21);
            btnReadFromFile.Name = "btnReadFromFile";
            btnReadFromFile.Size = new Size(404, 40);
            btnReadFromFile.TabIndex = 15;
            btnReadFromFile.Text = "Read From File";
            btnReadFromFile.UseVisualStyleBackColor = true;
            btnReadFromFile.Click += btnReadFromFile_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(2, 437);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(436, 70);
            btnExit.TabIndex = 16;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // txtShow
            // 
            txtShow.Location = new Point(444, 3);
            txtShow.Multiline = true;
            txtShow.Name = "txtShow";
            txtShow.ReadOnly = true;
            txtShow.Size = new Size(630, 504);
            txtShow.TabIndex = 17;
            txtShow.TextChanged += txtShow_TextChanged;
            // 
            // Bai02
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1083, 508);
            Controls.Add(txtShow);
            Controls.Add(btnExit);
            Controls.Add(btnReadFromFile);
            Controls.Add(txtCharacterCount);
            Controls.Add(label6);
            Controls.Add(txtWordsCount);
            Controls.Add(label5);
            Controls.Add(txtLineCount);
            Controls.Add(label4);
            Controls.Add(txtURL);
            Controls.Add(label3);
            Controls.Add(txtSize);
            Controls.Add(label2);
            Controls.Add(txtFileName);
            Controls.Add(label1);
            Name = "Bai02";
            Text = "Bài 02 – Đọc thông tin một file .txt";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox txtFileName;
        private TextBox txtSize;
        private Label label2;
        private TextBox txtURL;
        private Label label3;
        private TextBox txtLineCount;
        private Label label4;
        private TextBox txtWordsCount;
        private Label label5;
        private TextBox txtCharacterCount;
        private Label label6;
        private Button btnReadFromFile;
        private Button btnExit;
        private TextBox txtShow;
    }
}