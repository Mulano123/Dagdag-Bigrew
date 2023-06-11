namespace WinFormsApp2
{
    partial class Form2
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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label2 = new Label();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            label3 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label4 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 128, 0);
            label1.Font = new Font("Times New Roman", 48F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.InactiveBorder;
            label1.Location = new Point(241, 9);
            label1.Name = "label1";
            label1.Size = new Size(324, 73);
            label1.TabIndex = 0;
            label1.Text = "BIGBREW";
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(24, 109);
            button1.Name = "button1";
            button1.Size = new Size(149, 32);
            button1.TabIndex = 1;
            button1.Text = "Products";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(24, 163);
            button2.Name = "button2";
            button2.Size = new Size(149, 32);
            button2.TabIndex = 2;
            button2.Text = "Categories";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(24, 335);
            button3.Name = "button3";
            button3.Size = new Size(149, 34);
            button3.TabIndex = 3;
            button3.Text = "User Settings";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(24, 465);
            button4.Name = "button4";
            button4.Size = new Size(149, 34);
            button4.TabIndex = 4;
            button4.Text = "Log out";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 48F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(243, 51);
            label2.Name = "label2";
            label2.Size = new Size(324, 73);
            label2.TabIndex = 5;
            label2.Text = "BIGBREW";
            // 
            // button5
            // 
            button5.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(24, 220);
            button5.Name = "button5";
            button5.Size = new Size(149, 34);
            button5.TabIndex = 6;
            button5.Text = "Promo";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button6.Location = new Point(24, 274);
            button6.Name = "button6";
            button6.Size = new Size(149, 34);
            button6.TabIndex = 7;
            button6.Text = "Stock";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Font = new Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point);
            button7.Location = new Point(292, 118);
            button7.Name = "button7";
            button7.Size = new Size(200, 68);
            button7.TabIndex = 8;
            button7.Text = "Add Product";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Font = new Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point);
            button8.Location = new Point(544, 118);
            button8.Name = "button8";
            button8.Size = new Size(200, 68);
            button8.TabIndex = 9;
            button8.Text = "Add Category";
            button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Font = new Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point);
            button9.Location = new Point(544, 240);
            button9.Name = "button9";
            button9.Size = new Size(200, 68);
            button9.TabIndex = 10;
            button9.Text = "Add Stock";
            button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            button10.Font = new Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point);
            button10.Location = new Point(292, 240);
            button10.Name = "button10";
            button10.Size = new Size(200, 68);
            button10.TabIndex = 11;
            button10.Text = "Create Order";
            button10.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(345, 391);
            label3.Name = "label3";
            label3.Size = new Size(123, 19);
            label3.TabIndex = 12;
            label3.Text = "Total Product Sold";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = SystemColors.ActiveCaptionText;
            flowLayoutPanel1.Location = new Point(292, 343);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(452, 26);
            flowLayoutPanel1.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(567, 391);
            label4.Name = "label4";
            label4.Size = new Size(131, 19);
            label4.TabIndex = 14;
            label4.Text = "Today Product Sold";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(504, 368);
            panel1.Name = "panel1";
            panel1.Size = new Size(24, 119);
            panel1.TabIndex = 15;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaptionText;
            panel2.Location = new Point(292, 368);
            panel2.Name = "panel2";
            panel2.Size = new Size(30, 119);
            panel2.TabIndex = 16;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaptionText;
            panel3.Location = new Point(717, 368);
            panel3.Name = "panel3";
            panel3.Size = new Size(27, 119);
            panel3.TabIndex = 17;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ActiveCaptionText;
            panel4.Location = new Point(292, 484);
            panel4.Name = "panel4";
            panel4.Size = new Size(452, 25);
            panel4.TabIndex = 18;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 521);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label4);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(label3);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label2;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Label label3;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label4;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
    }
}