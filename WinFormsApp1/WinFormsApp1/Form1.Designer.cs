namespace WinFormsApp1
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
            submit = new Button();
            label1 = new Label();
            label2 = new Label();
            firstname = new TextBox();
            lastname = new TextBox();
            SuspendLayout();
            // 
            // submit
            // 
            submit.Location = new Point(105, 247);
            submit.Name = "submit";
            submit.Size = new Size(70, 35);
            submit.TabIndex = 0;
            submit.Text = "Submit";
            submit.UseVisualStyleBackColor = true;
            submit.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(105, 54);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 1;
            label1.Text = "First Name";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(105, 157);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 2;
            label2.Text = "Last Name";
            // 
            // firstname
            // 
            firstname.Location = new Point(105, 72);
            firstname.Name = "firstname";
            firstname.Size = new Size(100, 23);
            firstname.TabIndex = 3;
            firstname.TextChanged += textBox1_TextChanged;
            // 
            // lastname
            // 
            lastname.Location = new Point(105, 175);
            lastname.Name = "lastname";
            lastname.Size = new Size(100, 23);
            lastname.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(831, 450);
            Controls.Add(lastname);
            Controls.Add(firstname);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(submit);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button submit;
        private Label label1;
        private Label label2;
        private TextBox firstname;
        private TextBox lastname;
    }
}
