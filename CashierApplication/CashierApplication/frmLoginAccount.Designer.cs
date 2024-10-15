namespace CashierApplication
{
    partial class frmLoginAccount
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
            UName = new Label();
            UNametxt = new TextBox();
            Password = new Label();
            Passwordtxt = new TextBox();
            LoginBtn = new Button();
            SuspendLayout();
            // 
            // UName
            // 
            UName.AutoSize = true;
            UName.Location = new Point(12, 12);
            UName.Name = "UName";
            UName.Size = new Size(60, 15);
            UName.TabIndex = 0;
            UName.Text = "Username";
            // 
            // UNametxt
            // 
            UNametxt.Location = new Point(12, 30);
            UNametxt.Name = "UNametxt";
            UNametxt.Size = new Size(100, 23);
            UNametxt.TabIndex = 1;
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.Location = new Point(12, 79);
            Password.Name = "Password";
            Password.Size = new Size(57, 15);
            Password.TabIndex = 2;
            Password.Text = "Password";
            // 
            // Passwordtxt
            // 
            Passwordtxt.Location = new Point(12, 97);
            Passwordtxt.Name = "Passwordtxt";
            Passwordtxt.Size = new Size(100, 23);
            Passwordtxt.TabIndex = 3;
            // 
            // LoginBtn
            // 
            LoginBtn.Location = new Point(23, 141);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(75, 29);
            LoginBtn.TabIndex = 4;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = true;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // frmLoginAccount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(134, 195);
            Controls.Add(LoginBtn);
            Controls.Add(Passwordtxt);
            Controls.Add(Password);
            Controls.Add(UNametxt);
            Controls.Add(UName);
            Name = "frmLoginAccount";
            Text = "frmLoginAccount";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label UName;
        private TextBox UNametxt;
        private Label Password;
        private TextBox Passwordtxt;
        private Button LoginBtn;
    }
}