namespace TKM
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
            components = new System.ComponentModel.Container();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.Location = new Point(301, 312);
            button1.Name = "button1";
            button1.Size = new Size(158, 65);
            button1.TabIndex = 0;
            button1.Text = "Taş";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button2.Location = new Point(301, 383);
            button2.Name = "button2";
            button2.Size = new Size(158, 65);
            button2.TabIndex = 1;
            button2.Text = "Kağıt";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button3.Location = new Point(301, 454);
            button3.Name = "button3";
            button3.Size = new Size(158, 65);
            button3.TabIndex = 2;
            button3.Text = "Makas";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.White;
            button4.Enabled = false;
            button4.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button4.Location = new Point(301, 154);
            button4.Name = "button4";
            button4.Size = new Size(158, 65);
            button4.TabIndex = 5;
            button4.Text = "Makas";
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.White;
            button5.Enabled = false;
            button5.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button5.Location = new Point(301, 83);
            button5.Name = "button5";
            button5.Size = new Size(158, 65);
            button5.TabIndex = 4;
            button5.Text = "Kağıt";
            button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = Color.White;
            button6.Enabled = false;
            button6.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button6.Location = new Point(301, 12);
            button6.Name = "button6";
            button6.Size = new Size(158, 65);
            button6.TabIndex = 3;
            button6.Text = "Taş";
            button6.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(24, 475);
            label1.Name = "label1";
            label1.Size = new Size(0, 32);
            label1.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(329, 249);
            label2.Name = "label2";
            label2.Size = new Size(0, 32);
            label2.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.Location = new Point(24, 45);
            label3.Name = "label3";
            label3.Size = new Size(0, 32);
            label3.TabIndex = 8;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(814, 617);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Label label1;
        private Label label2;
        private Label label3;
        private System.Windows.Forms.Timer timer1;
    }
}
