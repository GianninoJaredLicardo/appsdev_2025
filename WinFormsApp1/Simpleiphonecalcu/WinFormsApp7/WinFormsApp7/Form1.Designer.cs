namespace WinFormsApp7
{
    partial class Form1
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
            iphonelstbox = new ListBox();
            iphonechcklstbox = new CheckedListBox();
            loancombobox = new ComboBox();
            Computebtn = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            SuspendLayout();
            // 
            // iphonelstbox
            // 
            iphonelstbox.FormattingEnabled = true;
            iphonelstbox.ItemHeight = 15;
            iphonelstbox.Location = new Point(34, 49);
            iphonelstbox.Name = "iphonelstbox";
            iphonelstbox.Size = new Size(119, 169);
            iphonelstbox.TabIndex = 0;
            // 
            // iphonechcklstbox
            // 
            iphonechcklstbox.FormattingEnabled = true;
            iphonechcklstbox.Location = new Point(299, 52);
            iphonechcklstbox.Name = "iphonechcklstbox";
            iphonechcklstbox.Size = new Size(114, 166);
            iphonechcklstbox.TabIndex = 1;
            // 
            // loancombobox
            // 
            loancombobox.FormattingEnabled = true;
            loancombobox.Location = new Point(562, 49);
            loancombobox.Name = "loancombobox";
            loancombobox.Size = new Size(121, 23);
            loancombobox.TabIndex = 2;
            // 
            // Computebtn
            // 
            Computebtn.Location = new Point(597, 103);
            Computebtn.Name = "Computebtn";
            Computebtn.Size = new Size(75, 23);
            Computebtn.TabIndex = 3;
            Computebtn.Text = "button1";
            Computebtn.UseVisualStyleBackColor = true;
            Computebtn.Click += Computebtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(63, 287);
            label1.Name = "label1";
            label1.Size = new Size(82, 14);
            label1.TabIndex = 4;
            label1.Text = "Loan Details";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(66, 326);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 5;
            label2.Text = "Model:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(63, 364);
            label3.Name = "label3";
            label3.Size = new Size(103, 15);
            label3.TabIndex = 6;
            label3.Text = "Principal Amount:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(63, 411);
            label4.Name = "label4";
            label4.Size = new Size(91, 15);
            label4.TabIndex = 7;
            label4.Text = "Down Payment:";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(66, 458);
            label5.Name = "label5";
            label5.Size = new Size(65, 15);
            label5.TabIndex = 8;
            label5.Text = "Loan Term:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(66, 502);
            label6.Name = "label6";
            label6.Size = new Size(75, 15);
            label6.TabIndex = 9;
            label6.Text = "Interest Rate:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(66, 541);
            label7.Name = "label7";
            label7.Size = new Size(122, 15);
            label7.TabIndex = 10;
            label7.Text = "Interest Rate Amount:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(66, 577);
            label8.Name = "label8";
            label8.Size = new Size(130, 15);
            label8.TabIndex = 11;
            label8.Text = "Total Monthly Amount:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(72, 614);
            label9.Name = "label9";
            label9.Size = new Size(82, 15);
            label9.TabIndex = 12;
            label9.Text = "Total Amount:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(831, 657);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Computebtn);
            Controls.Add(loancombobox);
            Controls.Add(iphonechcklstbox);
            Controls.Add(iphonelstbox);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox iphonelstbox;
        private CheckedListBox iphonechcklstbox;
        private ComboBox loancombobox;
        private Button Computebtn;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
    }
}
