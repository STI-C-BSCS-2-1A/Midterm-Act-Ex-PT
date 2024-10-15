
namespace CashierApplication
{
    partial class frmPurchaseDiscountedItem
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
            ComputeBtn = new Button();
            label5 = new Label();
            TotalAmountlbl = new Label();
            label7 = new Label();
            Itemtxt = new TextBox();
            Pricetxt = new TextBox();
            Discounttxt = new TextBox();
            Quantitytxt = new TextBox();
            PaymentReceivedtxt = new TextBox();
            label8 = new Label();
            Changelbl = new Label();
            SubmitBtn = new Button();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 35);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 0;
            label1.Text = "Item:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(197, 35);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 1;
            label2.Text = "Discount(%):";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 98);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 2;
            label3.Text = "Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(197, 98);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 3;
            label4.Text = "Quantity:";
            // 
            // ComputeBtn
            // 
            ComputeBtn.Location = new Point(139, 154);
            ComputeBtn.Name = "ComputeBtn";
            ComputeBtn.Size = new Size(75, 23);
            ComputeBtn.TabIndex = 4;
            ComputeBtn.Text = "Compute";
            ComputeBtn.UseVisualStyleBackColor = true;
            ComputeBtn.Click += ComputeBtn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(78, 193);
            label5.Name = "label5";
            label5.Size = new Size(82, 15);
            label5.TabIndex = 5;
            label5.Text = "Total Amount:";
            // 
            // TotalAmountlbl
            // 
            TotalAmountlbl.AutoSize = true;
            TotalAmountlbl.Location = new Point(164, 193);
            TotalAmountlbl.Name = "TotalAmountlbl";
            TotalAmountlbl.Size = new Size(38, 15);
            TotalAmountlbl.TabIndex = 6;
            TotalAmountlbl.Text = "label6";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(41, 242);
            label7.Name = "label7";
            label7.Size = new Size(107, 15);
            label7.TabIndex = 7;
            label7.Text = "Payment Received:";
            // 
            // Itemtxt
            // 
            Itemtxt.Location = new Point(16, 53);
            Itemtxt.Name = "Itemtxt";
            Itemtxt.Size = new Size(100, 23);
            Itemtxt.TabIndex = 8;
            // 
            // Pricetxt
            // 
            Pricetxt.Location = new Point(60, 95);
            Pricetxt.Name = "Pricetxt";
            Pricetxt.Size = new Size(100, 23);
            Pricetxt.TabIndex = 9;
            // 
            // Discounttxt
            // 
            Discounttxt.Location = new Point(197, 53);
            Discounttxt.Name = "Discounttxt";
            Discounttxt.Size = new Size(100, 23);
            Discounttxt.TabIndex = 10;
            // 
            // Quantitytxt
            // 
            Quantitytxt.Location = new Point(266, 95);
            Quantitytxt.Name = "Quantitytxt";
            Quantitytxt.Size = new Size(100, 23);
            Quantitytxt.TabIndex = 11;
            // 
            // PaymentReceivedtxt
            // 
            PaymentReceivedtxt.Location = new Point(154, 239);
            PaymentReceivedtxt.Name = "PaymentReceivedtxt";
            PaymentReceivedtxt.Size = new Size(100, 23);
            PaymentReceivedtxt.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(97, 285);
            label8.Name = "label8";
            label8.Size = new Size(51, 15);
            label8.TabIndex = 13;
            label8.Text = "Change:";
            // 
            // Changelbl
            // 
            Changelbl.AutoSize = true;
            Changelbl.Location = new Point(164, 285);
            Changelbl.Name = "Changelbl";
            Changelbl.Size = new Size(38, 15);
            Changelbl.TabIndex = 14;
            Changelbl.Text = "label9";
            // 
            // SubmitBtn
            // 
            SubmitBtn.Location = new Point(260, 239);
            SubmitBtn.Name = "SubmitBtn";
            SubmitBtn.Size = new Size(75, 23);
            SubmitBtn.TabIndex = 15;
            SubmitBtn.Text = "Submit";
            SubmitBtn.UseVisualStyleBackColor = true;
            SubmitBtn.Click += SubmitBtn_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(388, 24);
            menuStrip1.TabIndex = 16;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { logoutToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(180, 22);
            logoutToolStripMenuItem.Text = "Logout";
            logoutToolStripMenuItem.Click += logoutToolStripMenuItem_Click_1;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(180, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // frmPurchaseDiscountedItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(388, 317);
            Controls.Add(SubmitBtn);
            Controls.Add(Changelbl);
            Controls.Add(label8);
            Controls.Add(PaymentReceivedtxt);
            Controls.Add(Quantitytxt);
            Controls.Add(Discounttxt);
            Controls.Add(Pricetxt);
            Controls.Add(Itemtxt);
            Controls.Add(label7);
            Controls.Add(TotalAmountlbl);
            Controls.Add(label5);
            Controls.Add(ComputeBtn);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmPurchaseDiscountedItem";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button ComputeBtn;
        private Label label5;
        private Label TotalAmountlbl;
        private Label label7;
        private TextBox Itemtxt;
        private TextBox Pricetxt;
        private TextBox Discounttxt;
        private TextBox Quantitytxt;
        private TextBox PaymentReceivedtxt;
        private Label label8;
        private Label Changelbl;
        private Button SubmitBtn;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
    }
}
