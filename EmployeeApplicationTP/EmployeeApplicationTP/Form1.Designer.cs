namespace EmployeeApplicationTP
{
    partial class frmComputeSalary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmComputeSalary));
            this.label1 = new System.Windows.Forms.Label();
            this.tb_firstName = new System.Windows.Forms.TextBox();
            this.tb_lastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_department = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_jobTitle = new System.Windows.Forms.TextBox();
            this.lb_jobTitle = new System.Windows.Forms.Label();
            this.tb_rate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_totalhour = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.bt_computeSalary = new System.Windows.Forms.Button();
            this.lb_firstName = new System.Windows.Forms.Label();
            this.lb_lastName = new System.Windows.Forms.Label();
            this.lb_basicSalary = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // tb_firstName
            // 
            this.tb_firstName.Location = new System.Drawing.Point(33, 59);
            this.tb_firstName.Name = "tb_firstName";
            this.tb_firstName.Size = new System.Drawing.Size(207, 20);
            this.tb_firstName.TabIndex = 1;
            // 
            // tb_lastName
            // 
            this.tb_lastName.Location = new System.Drawing.Point(271, 59);
            this.tb_lastName.Name = "tb_lastName";
            this.tb_lastName.Size = new System.Drawing.Size(207, 20);
            this.tb_lastName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(268, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Name";
            // 
            // tb_department
            // 
            this.tb_department.Location = new System.Drawing.Point(33, 112);
            this.tb_department.Name = "tb_department";
            this.tb_department.Size = new System.Drawing.Size(207, 20);
            this.tb_department.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Department";
            // 
            // tb_jobTitle
            // 
            this.tb_jobTitle.Location = new System.Drawing.Point(271, 112);
            this.tb_jobTitle.Name = "tb_jobTitle";
            this.tb_jobTitle.Size = new System.Drawing.Size(207, 20);
            this.tb_jobTitle.TabIndex = 7;
            // 
            // lb_jobTitle
            // 
            this.lb_jobTitle.AutoSize = true;
            this.lb_jobTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_jobTitle.Location = new System.Drawing.Point(268, 91);
            this.lb_jobTitle.Name = "lb_jobTitle";
            this.lb_jobTitle.Size = new System.Drawing.Size(64, 18);
            this.lb_jobTitle.TabIndex = 6;
            this.lb_jobTitle.Text = "Job Title";
            // 
            // tb_rate
            // 
            this.tb_rate.Location = new System.Drawing.Point(33, 208);
            this.tb_rate.Name = "tb_rate";
            this.tb_rate.Size = new System.Drawing.Size(207, 20);
            this.tb_rate.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Rate per hour";
            // 
            // tb_totalhour
            // 
            this.tb_totalhour.Location = new System.Drawing.Point(271, 208);
            this.tb_totalhour.Name = "tb_totalhour";
            this.tb_totalhour.Size = new System.Drawing.Size(207, 20);
            this.tb_totalhour.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(268, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Total hours worked";
            // 
            // bt_computeSalary
            // 
            this.bt_computeSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_computeSalary.Location = new System.Drawing.Point(175, 270);
            this.bt_computeSalary.Name = "bt_computeSalary";
            this.bt_computeSalary.Size = new System.Drawing.Size(174, 34);
            this.bt_computeSalary.TabIndex = 12;
            this.bt_computeSalary.Text = "Compute Salary";
            this.bt_computeSalary.UseVisualStyleBackColor = true;
            this.bt_computeSalary.Click += new System.EventHandler(this.bt_computeSalary_Click);
            // 
            // lb_firstName
            // 
            this.lb_firstName.AutoSize = true;
            this.lb_firstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_firstName.Location = new System.Drawing.Point(30, 322);
            this.lb_firstName.Name = "lb_firstName";
            this.lb_firstName.Size = new System.Drawing.Size(89, 18);
            this.lb_firstName.TabIndex = 13;
            this.lb_firstName.Text = "First Name: ";
            // 
            // lb_lastName
            // 
            this.lb_lastName.AutoSize = true;
            this.lb_lastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_lastName.Location = new System.Drawing.Point(30, 365);
            this.lb_lastName.Name = "lb_lastName";
            this.lb_lastName.Size = new System.Drawing.Size(88, 18);
            this.lb_lastName.TabIndex = 14;
            this.lb_lastName.Text = "Last Name: ";
            // 
            // lb_basicSalary
            // 
            this.lb_basicSalary.AutoSize = true;
            this.lb_basicSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_basicSalary.Location = new System.Drawing.Point(30, 406);
            this.lb_basicSalary.Name = "lb_basicSalary";
            this.lb_basicSalary.Size = new System.Drawing.Size(98, 18);
            this.lb_basicSalary.TabIndex = 15;
            this.lb_basicSalary.Text = "Basic Salary: ";
            // 
            // frmComputeSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(502, 450);
            this.Controls.Add(this.lb_basicSalary);
            this.Controls.Add(this.lb_lastName);
            this.Controls.Add(this.lb_firstName);
            this.Controls.Add(this.bt_computeSalary);
            this.Controls.Add(this.tb_totalhour);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_rate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_jobTitle);
            this.Controls.Add(this.lb_jobTitle);
            this.Controls.Add(this.tb_department);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_lastName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_firstName);
            this.Controls.Add(this.label1);
            this.Name = "frmComputeSalary";
            this.Text = "Employee Salary Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_firstName;
        private System.Windows.Forms.TextBox tb_lastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_department;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_jobTitle;
        private System.Windows.Forms.Label lb_jobTitle;
        private System.Windows.Forms.TextBox tb_rate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_totalhour;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bt_computeSalary;
        private System.Windows.Forms.Label lb_firstName;
        private System.Windows.Forms.Label lb_lastName;
        private System.Windows.Forms.Label lb_basicSalary;
    }
}

