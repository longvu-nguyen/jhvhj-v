namespace Hi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label2 = new Label();
            btlogin = new Button();
            txtname = new TextBox();
            txtpass = new TextBox();
            label1 = new Label();
            btExit = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 169);
            label2.Name = "label2";
            label2.Size = new Size(36, 20);
            label2.TabIndex = 1;
            label2.Text = "Pass";
            label2.Click += label2_Click;
            // 
            // btlogin
            // 
            btlogin.Location = new Point(79, 222);
            btlogin.Name = "btlogin";
            btlogin.Size = new Size(132, 51);
            btlogin.TabIndex = 3;
            btlogin.Text = "Login";
            btlogin.UseVisualStyleBackColor = true;
            btlogin.Click += btlogin_Click;
            // 
            // txtname
            // 
            txtname.Location = new Point(112, 72);
            txtname.Name = "txtname";
            txtname.Size = new Size(125, 27);
            txtname.TabIndex = 5;
            txtname.TextChanged += textname_TextChanged;
            // 
            // txtpass
            // 
            txtpass.Location = new Point(112, 169);
            txtpass.Name = "txtpass";
            txtpass.Size = new Size(125, 27);
            txtpass.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 72);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 8;
            label1.Text = "Name";
            label1.Click += label1_Click_1;
            // 
            // btExit
            // 
            btExit.Location = new Point(195, 301);
            btExit.Name = "btExit";
            btExit.Size = new Size(73, 29);
            btExit.TabIndex = 9;
            btExit.Text = "exit";
            btExit.UseVisualStyleBackColor = true;
            btExit.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(303, 349);
            Controls.Add(btExit);
            Controls.Add(label1);
            Controls.Add(txtpass);
            Controls.Add(txtname);
            Controls.Add(btlogin);
            Controls.Add(label2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Button btlogin;
        private TextBox txtname;
        private TextBox txtpass;
        private Label label1;
        private Button btExit;
    }
}
