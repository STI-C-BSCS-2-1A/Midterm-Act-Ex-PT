
namespace EmployeeApplicationTP
{
    partial class frmComputerSalary
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            FNametxt = new TextBox();
            Departmenttxt = new TextBox();
            LNametxt = new TextBox();
            JobTitletxt = new TextBox();
            Ratetxt = new TextBox();
            TotalHourstxt = new TextBox();
            label7 = new Label();
            ComputeBtn = new Button();
            label8 = new Label();
            label9 = new Label();
            FNamelbl = new Label();
            LNamelbl = new Label();
            Salarylbl = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 61);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 0;
            label1.Text = "First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 131);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 1;
            label2.Text = "Department";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(56, 216);
            label3.Name = "label3";
            label3.Size = new Size(78, 15);
            label3.TabIndex = 2;
            label3.Text = "Rate per hour";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(268, 61);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 3;
            label4.Text = "Last Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(268, 131);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 4;
            label5.Text = "Job Title";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(268, 216);
            label6.Name = "label6";
            label6.Size = new Size(107, 15);
            label6.TabIndex = 5;
            label6.Text = "Total hours worked";
            // 
            // FNametxt
            // 
            FNametxt.Location = new Point(56, 79);
            FNametxt.Name = "FNametxt";
            FNametxt.Size = new Size(100, 23);
            FNametxt.TabIndex = 6;
            // 
            // Departmenttxt
            // 
            Departmenttxt.Location = new Point(56, 149);
            Departmenttxt.Name = "Departmenttxt";
            Departmenttxt.Size = new Size(100, 23);
            Departmenttxt.TabIndex = 7;
            // 
            // LNametxt
            // 
            LNametxt.Location = new Point(268, 79);
            LNametxt.Name = "LNametxt";
            LNametxt.Size = new Size(100, 23);
            LNametxt.TabIndex = 8;
            // 
            // JobTitletxt
            // 
            JobTitletxt.Location = new Point(268, 149);
            JobTitletxt.Name = "JobTitletxt";
            JobTitletxt.Size = new Size(100, 23);
            JobTitletxt.TabIndex = 9;
            // 
            // Ratetxt
            // 
            Ratetxt.Location = new Point(56, 234);
            Ratetxt.Name = "Ratetxt";
            Ratetxt.Size = new Size(100, 23);
            Ratetxt.TabIndex = 11;
            // 
            // TotalHourstxt
            // 
            TotalHourstxt.Location = new Point(268, 234);
            TotalHourstxt.Name = "TotalHourstxt";
            TotalHourstxt.Size = new Size(100, 23);
            TotalHourstxt.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(56, 332);
            label7.Name = "label7";
            label7.Size = new Size(64, 15);
            label7.TabIndex = 13;
            label7.Text = "First Name";
            // 
            // ComputeBtn
            // 
            ComputeBtn.Location = new Point(173, 280);
            ComputeBtn.Name = "ComputeBtn";
            ComputeBtn.Size = new Size(75, 23);
            ComputeBtn.TabIndex = 14;
            ComputeBtn.Text = "Compute Salary";
            ComputeBtn.UseVisualStyleBackColor = true;
            ComputeBtn.Click += ComputeBtn_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(56, 360);
            label8.Name = "label8";
            label8.Size = new Size(63, 15);
            label8.TabIndex = 15;
            label8.Text = "Last Name";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(56, 389);
            label9.Name = "label9";
            label9.Size = new Size(68, 15);
            label9.TabIndex = 16;
            label9.Text = "Basic Salary";
            // 
            // FNamelbl
            // 
            FNamelbl.AutoSize = true;
            FNamelbl.Location = new Point(163, 332);
            FNamelbl.Name = "FNamelbl";
            FNamelbl.Size = new Size(44, 15);
            FNamelbl.TabIndex = 17;
            FNamelbl.Text = "label10";
            // 
            // LNamelbl
            // 
            LNamelbl.AutoSize = true;
            LNamelbl.Location = new Point(163, 360);
            LNamelbl.Name = "LNamelbl";
            LNamelbl.Size = new Size(44, 15);
            LNamelbl.TabIndex = 18;
            LNamelbl.Text = "label11";
            // 
            // Salarylbl
            // 
            Salarylbl.AutoSize = true;
            Salarylbl.Location = new Point(163, 389);
            Salarylbl.Name = "Salarylbl";
            Salarylbl.Size = new Size(44, 15);
            Salarylbl.TabIndex = 19;
            Salarylbl.Text = "label12";
            // 
            // frmComputerSalary
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(444, 450);
            Controls.Add(Salarylbl);
            Controls.Add(LNamelbl);
            Controls.Add(FNamelbl);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(ComputeBtn);
            Controls.Add(label7);
            Controls.Add(TotalHourstxt);
            Controls.Add(Ratetxt);
            Controls.Add(JobTitletxt);
            Controls.Add(LNametxt);
            Controls.Add(Departmenttxt);
            Controls.Add(FNametxt);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmComputerSalary";
            Text = "Employee Salary Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox FNametxt;
        private TextBox Departmenttxt;
        private TextBox LNametxt;
        private TextBox JobTitletxt;
        private TextBox Ratetxt;
        private TextBox TotalHourstxt;
        private Label label7;
        private Button ComputeBtn;
        private Label label8;
        private Label label9;
        private Label FNamelbl;
        private Label LNamelbl;
        private Label Salarylbl;
    }
}
