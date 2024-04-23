namespace ObjectOrientedGui
{
    partial class Home
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
            tableLayoutPanel1 = new TableLayoutPanel();
            btnProfessor = new Button();
            btnStudent = new Button();
            btnTeacher = new Button();
            panel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(tableLayoutPanel1);
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 48.3128853F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 51.6871147F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 291F));
            tableLayoutPanel1.Controls.Add(btnProfessor, 2, 0);
            tableLayoutPanel1.Controls.Add(btnStudent, 1, 0);
            tableLayoutPanel1.Controls.Add(btnTeacher, 0, 0);
            tableLayoutPanel1.Location = new Point(3, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 45.4767723F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 54.5232277F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 183F));
            tableLayoutPanel1.Size = new Size(923, 572);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btnProfessor
            // 
            btnProfessor.Location = new Point(634, 3);
            btnProfessor.Name = "btnProfessor";
            btnProfessor.Size = new Size(286, 169);
            btnProfessor.TabIndex = 2;
            btnProfessor.Text = "Professor";
            btnProfessor.UseVisualStyleBackColor = true;
            // 
            // btnStudent
            // 
            btnStudent.Location = new Point(308, 3);
            btnStudent.Name = "btnStudent";
            btnStudent.Size = new Size(318, 169);
            btnStudent.TabIndex = 1;
            btnStudent.Text = "Student";
            btnStudent.UseVisualStyleBackColor = true;
            btnStudent.Click += btnStudent_Click;
            // 
            // btnTeacher
            // 
            btnTeacher.Location = new Point(3, 3);
            btnTeacher.Name = "btnTeacher";
            btnTeacher.Size = new Size(299, 169);
            btnTeacher.TabIndex = 0;
            btnTeacher.Text = "Teacher";
            btnTeacher.UseVisualStyleBackColor = true;
            btnTeacher.Click += btnTeacher_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1217, 573);
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            panel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button btnProfessor;
        private Button btnStudent;
        private Button btnTeacher;
    }
}