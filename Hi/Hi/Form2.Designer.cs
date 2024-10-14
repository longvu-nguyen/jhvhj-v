namespace Hi
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
            panel1 = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            panel3 = new Panel();
            button1 = new Button();
            button6 = new Button();
            button2 = new Button();
            button5 = new Button();
            button3 = new Button();
            button4 = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel4 = new Panel();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel4);
            panel1.Location = new Point(228, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1236, 95);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Location = new Point(5, 158);
            panel2.Name = "panel2";
            panel2.Size = new Size(796, 296);
            panel2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Historic", 25.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(459, 9);
            label1.Name = "label1";
            label1.Size = new Size(196, 60);
            label1.TabIndex = 0;
            label1.Text = "Quản Lý";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveBorder;
            panel3.Controls.Add(button1);
            panel3.Controls.Add(button6);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(button5);
            panel3.Controls.Add(button3);
            panel3.Controls.Add(button4);
            panel3.ImeMode = ImeMode.NoControl;
            panel3.Location = new Point(0, 165);
            panel3.Name = "panel3";
            panel3.Size = new Size(228, 523);
            panel3.TabIndex = 2;
            panel3.Paint += panel3_Paint;
            // 
            // button1
            // 
            button1.Location = new Point(52, 421);
            button1.Name = "button1";
            button1.Size = new Size(101, 61);
            button1.TabIndex = 8;
            button1.Text = "exit";
            button1.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(0, 298);
            button6.Name = "button6";
            button6.Size = new Size(228, 86);
            button6.TabIndex = 7;
            button6.Text = "Log out";
            button6.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(0, 150);
            button2.Name = "button2";
            button2.Size = new Size(228, 80);
            button2.TabIndex = 4;
            button2.Text = "Employee ";
            button2.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(0, 223);
            button5.Name = "button5";
            button5.Size = new Size(228, 80);
            button5.TabIndex = 6;
            button5.Text = "Statistics";
            button5.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(0, 75);
            button3.Name = "button3";
            button3.Size = new Size(228, 80);
            button3.TabIndex = 5;
            button3.Text = "Customer";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(0, 0);
            button4.Name = "button4";
            button4.Size = new Size(228, 80);
            button4.TabIndex = 3;
            button4.Text = "Product";
            button4.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ActiveBorder;
            panel4.ImeMode = ImeMode.NoControl;
            panel4.Location = new Point(0, 92);
            panel4.Name = "panel4";
            panel4.Size = new Size(1236, 596);
            panel4.TabIndex = 8;
            panel4.Paint += panel4_Paint;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.White_and_Blue_Minimalist_Clothing_Store_Logo;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(228, 169);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1465, 692);
            Controls.Add(panel3);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form2";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += Form2_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Panel panel3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button bt1;
        private Button bt2;
        private Button bt3;
        private Button bt4;
        private Button button1;
        private Panel panel4;
        private Button button2;
        private Button button6;
        private Button button5;
        private Button button3;
        private Button button4;
        private PictureBox pictureBox2;
    }
}