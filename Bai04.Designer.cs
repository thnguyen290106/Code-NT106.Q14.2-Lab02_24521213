namespace Code_NT106.Q14._2_Lab02_24521213
{
    partial class Bai04
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
            btnWrite = new Button();
            textBox2 = new TextBox();
            label8 = new Label();
            txtAverage = new TextBox();
            label9 = new Label();
            txtCourse3 = new TextBox();
            label10 = new Label();
            txtCourse2 = new TextBox();
            label11 = new Label();
            txtCourse1 = new TextBox();
            label12 = new Label();
            txtPhone = new TextBox();
            label13 = new Label();
            txtID = new TextBox();
            label14 = new Label();
            txtName = new TextBox();
            btnRead = new Button();
            btnBack = new Button();
            btnNext = new Button();
            lblPage = new Label();
            btnAdd = new Button();
            SuspendLayout();
            // 
            // btnWrite
            // 
            btnWrite.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnWrite.Location = new Point(28, 207);
            btnWrite.Name = "btnWrite";
            btnWrite.Size = new Size(216, 45);
            btnWrite.TabIndex = 0;
            btnWrite.Text = "Write to a file";
            btnWrite.UseVisualStyleBackColor = true;
            btnWrite.Click += btnWrite_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(289, 2);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(418, 512);
            textBox2.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(922, 409);
            label8.Name = "label8";
            label8.Size = new Size(83, 25);
            label8.TabIndex = 30;
            label8.Text = "Average";
            // 
            // txtAverage
            // 
            txtAverage.Location = new Point(730, 410);
            txtAverage.Name = "txtAverage";
            txtAverage.ReadOnly = true;
            txtAverage.Size = new Size(186, 27);
            txtAverage.TabIndex = 29;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(922, 352);
            label9.Name = "label9";
            label9.Size = new Size(85, 25);
            label9.TabIndex = 28;
            label9.Text = "Course 3";
            // 
            // txtCourse3
            // 
            txtCourse3.Location = new Point(730, 353);
            txtCourse3.Name = "txtCourse3";
            txtCourse3.ReadOnly = true;
            txtCourse3.Size = new Size(186, 27);
            txtCourse3.TabIndex = 27;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(922, 293);
            label10.Name = "label10";
            label10.Size = new Size(85, 25);
            label10.TabIndex = 26;
            label10.Text = "Course 2";
            // 
            // txtCourse2
            // 
            txtCourse2.Location = new Point(730, 294);
            txtCourse2.Name = "txtCourse2";
            txtCourse2.ReadOnly = true;
            txtCourse2.Size = new Size(186, 27);
            txtCourse2.TabIndex = 25;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(922, 227);
            label11.Name = "label11";
            label11.Size = new Size(85, 25);
            label11.TabIndex = 24;
            label11.Text = "Course 1";
            // 
            // txtCourse1
            // 
            txtCourse1.Location = new Point(730, 228);
            txtCourse1.Name = "txtCourse1";
            txtCourse1.ReadOnly = true;
            txtCourse1.Size = new Size(186, 27);
            txtCourse1.TabIndex = 23;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(922, 172);
            label12.Name = "label12";
            label12.Size = new Size(66, 25);
            label12.TabIndex = 22;
            label12.Text = "Phone";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(730, 173);
            txtPhone.Name = "txtPhone";
            txtPhone.ReadOnly = true;
            txtPhone.Size = new Size(186, 27);
            txtPhone.TabIndex = 21;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(922, 122);
            label13.Name = "label13";
            label13.Size = new Size(31, 25);
            label13.TabIndex = 20;
            label13.Text = "ID";
            // 
            // txtID
            // 
            txtID.Location = new Point(730, 123);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(186, 27);
            txtID.TabIndex = 19;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(922, 73);
            label14.Name = "label14";
            label14.Size = new Size(62, 25);
            label14.TabIndex = 18;
            label14.Text = "Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(730, 74);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(186, 27);
            txtName.TabIndex = 17;
            // 
            // btnRead
            // 
            btnRead.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRead.Location = new Point(730, 12);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(216, 45);
            btnRead.TabIndex = 16;
            btnRead.Text = "Button to read a file";
            btnRead.UseVisualStyleBackColor = true;
            btnRead.Click += btnRead_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(730, 465);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 31;
            btnBack.Text = "Back";
            btnBack.Click += btnBack_Click;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(922, 465);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(94, 29);
            btnNext.TabIndex = 32;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // lblPage
            // 
            lblPage.AutoSize = true;
            lblPage.Location = new Point(861, 469);
            lblPage.Name = "lblPage";
            lblPage.Size = new Size(17, 20);
            lblPage.TabIndex = 34;
            lblPage.Text = "1";
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(28, 294);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(216, 45);
            btnAdd.TabIndex = 35;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // Bai04
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1083, 515);
            Controls.Add(btnAdd);
            Controls.Add(lblPage);
            Controls.Add(btnNext);
            Controls.Add(btnBack);
            Controls.Add(label8);
            Controls.Add(txtAverage);
            Controls.Add(label9);
            Controls.Add(txtCourse3);
            Controls.Add(label10);
            Controls.Add(txtCourse2);
            Controls.Add(label11);
            Controls.Add(txtCourse1);
            Controls.Add(label12);
            Controls.Add(txtPhone);
            Controls.Add(label13);
            Controls.Add(txtID);
            Controls.Add(label14);
            Controls.Add(txtName);
            Controls.Add(btnRead);
            Controls.Add(textBox2);
            Controls.Add(btnWrite);
            Name = "Bai04";
            Text = "Bài 4 - Đọc và Ghi file sử dụng BinaryFormatter (JsonSerializer) ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnWrite;
        private TextBox textBox2;
        private Label label8;
        private TextBox txtAverage;
        private Label label9;
        private TextBox txtCourse3;
        private Label label10;
        private TextBox txtCourse2;
        private Label label11;
        private TextBox txtCourse1;
        private Label label12;
        private TextBox txtPhone;
        private Label label13;
        private TextBox txtID;
        private Label label14;
        private TextBox txtName;
        private Button btnRead;
        private Button btnBack;
        private Button btnNext;
        private Label lblPage;
        private Button btnAdd;
    }
}