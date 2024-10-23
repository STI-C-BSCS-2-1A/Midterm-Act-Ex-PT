namespace Employee_Application
{
    partial class frmComputeSalary
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
            firstNameTxtBx = new TextBox();
            lastNameTxtBx = new TextBox();
            departmentTxtBx = new TextBox();
            jobTitleTxtBx = new TextBox();
            rateTxtBx = new TextBox();
            totalHrsTxtBx = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            computeSalaryBtn = new Button();
            label7 = new Label();
            firstNameTxt = new Label();
            label9 = new Label();
            lastNameTxt = new Label();
            label11 = new Label();
            basicSalaryTxt = new Label();
            SuspendLayout();
            // 
            // firstNameTxtBx
            // 
            firstNameTxtBx.Location = new Point(12, 45);
            firstNameTxtBx.Name = "firstNameTxtBx";
            firstNameTxtBx.Size = new Size(134, 23);
            firstNameTxtBx.TabIndex = 0;
            // 
            // lastNameTxtBx
            // 
            lastNameTxtBx.Location = new Point(152, 45);
            lastNameTxtBx.Name = "lastNameTxtBx";
            lastNameTxtBx.Size = new Size(134, 23);
            lastNameTxtBx.TabIndex = 1;
            // 
            // departmentTxtBx
            // 
            departmentTxtBx.Location = new Point(12, 89);
            departmentTxtBx.Name = "departmentTxtBx";
            departmentTxtBx.Size = new Size(134, 23);
            departmentTxtBx.TabIndex = 2;
            // 
            // jobTitleTxtBx
            // 
            jobTitleTxtBx.Location = new Point(152, 89);
            jobTitleTxtBx.Name = "jobTitleTxtBx";
            jobTitleTxtBx.Size = new Size(134, 23);
            jobTitleTxtBx.TabIndex = 3;
            // 
            // rateTxtBx
            // 
            rateTxtBx.Location = new Point(12, 152);
            rateTxtBx.Name = "rateTxtBx";
            rateTxtBx.Size = new Size(134, 23);
            rateTxtBx.TabIndex = 4;
            // 
            // totalHrsTxtBx
            // 
            totalHrsTxtBx.Location = new Point(152, 152);
            totalHrsTxtBx.Name = "totalHrsTxtBx";
            totalHrsTxtBx.Size = new Size(134, 23);
            totalHrsTxtBx.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 27);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 6;
            label1.Text = "First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 71);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 7;
            label2.Text = "Department";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 134);
            label3.Name = "label3";
            label3.Size = new Size(78, 15);
            label3.TabIndex = 8;
            label3.Text = "Rate per hour";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(152, 27);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 9;
            label4.Text = "Last Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(152, 71);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 10;
            label5.Text = "Job Title";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(152, 134);
            label6.Name = "label6";
            label6.Size = new Size(107, 15);
            label6.TabIndex = 11;
            label6.Text = "Total hours worked";
            // 
            // computeSalaryBtn
            // 
            computeSalaryBtn.Location = new Point(95, 181);
            computeSalaryBtn.Name = "computeSalaryBtn";
            computeSalaryBtn.Size = new Size(107, 31);
            computeSalaryBtn.TabIndex = 12;
            computeSalaryBtn.Text = "Compute Salary";
            computeSalaryBtn.UseVisualStyleBackColor = true;
            computeSalaryBtn.Click += computeSalaryBtn_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 225);
            label7.Name = "label7";
            label7.Size = new Size(65, 15);
            label7.TabIndex = 13;
            label7.Text = "First name:";
            // 
            // firstNameTxt
            // 
            firstNameTxt.AutoSize = true;
            firstNameTxt.Location = new Point(83, 225);
            firstNameTxt.Name = "firstNameTxt";
            firstNameTxt.Size = new Size(102, 15);
            firstNameTxt.TabIndex = 14;
            firstNameTxt.Text = "<first name here>";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 249);
            label9.Name = "label9";
            label9.Size = new Size(61, 15);
            label9.TabIndex = 15;
            label9.Text = "Last name";
            // 
            // lastNameTxt
            // 
            lastNameTxt.AutoSize = true;
            lastNameTxt.Location = new Point(83, 249);
            lastNameTxt.Name = "lastNameTxt";
            lastNameTxt.Size = new Size(100, 15);
            lastNameTxt.TabIndex = 16;
            lastNameTxt.Text = "<last name here>";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(12, 274);
            label11.Name = "label11";
            label11.Size = new Size(71, 15);
            label11.TabIndex = 17;
            label11.Text = "Basic Salary:";
            label11.Click += label11_Click;
            // 
            // basicSalaryTxt
            // 
            basicSalaryTxt.AutoSize = true;
            basicSalaryTxt.Location = new Point(86, 274);
            basicSalaryTxt.Name = "basicSalaryTxt";
            basicSalaryTxt.Size = new Size(34, 15);
            basicSalaryTxt.TabIndex = 18;
            basicSalaryTxt.Text = "00.00";
            // 
            // frmComputeSalary
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(305, 304);
            Controls.Add(basicSalaryTxt);
            Controls.Add(label11);
            Controls.Add(lastNameTxt);
            Controls.Add(label9);
            Controls.Add(firstNameTxt);
            Controls.Add(label7);
            Controls.Add(computeSalaryBtn);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(totalHrsTxtBx);
            Controls.Add(rateTxtBx);
            Controls.Add(jobTitleTxtBx);
            Controls.Add(departmentTxtBx);
            Controls.Add(lastNameTxtBx);
            Controls.Add(firstNameTxtBx);
            Name = "frmComputeSalary";
            Text = "Employee Salary Calculator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox firstNameTxtBx;
        private TextBox lastNameTxtBx;
        private TextBox departmentTxtBx;
        private TextBox jobTitleTxtBx;
        private TextBox rateTxtBx;
        private TextBox totalHrsTxtBx;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button computeSalaryBtn;
        private Label label7;
        private Label firstNameTxt;
        private Label label9;
        private Label lastNameTxt;
        private Label label11;
        private Label basicSalaryTxt;
    }
}
