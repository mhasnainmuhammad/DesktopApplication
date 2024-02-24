namespace crud
{
    partial class loginform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginform));
            label5 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            lo = new Button();
            loginpassword = new TextBox();
            lpass = new Label();
            loginemail = new TextBox();
            lemail = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(178, 285);
            label5.Name = "label5";
            label5.Size = new Size(75, 15);
            label5.TabIndex = 19;
            label5.Text = "Registration";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(45, 285);
            label4.Name = "label4";
            label4.Size = new Size(127, 15);
            label4.TabIndex = 18;
            label4.Text = "dont have an account?";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(45, 40);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(162, 81);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // lo
            // 
            lo.BackColor = SystemColors.ScrollBar;
            lo.ForeColor = SystemColors.ActiveCaptionText;
            lo.Location = new Point(65, 314);
            lo.Name = "lo";
            lo.Size = new Size(94, 23);
            lo.TabIndex = 16;
            lo.Text = "LOGIN";
            lo.UseVisualStyleBackColor = false;
       
            // 
            // loginpassword
            // 
            loginpassword.Location = new Point(45, 248);
            loginpassword.Name = "loginpassword";
            loginpassword.Size = new Size(145, 23);
            loginpassword.TabIndex = 15;
            // 
            // lpass
            // 
            lpass.AutoSize = true;
            lpass.Location = new Point(48, 220);
            lpass.Name = "lpass";
            lpass.Size = new Size(57, 15);
            lpass.TabIndex = 14;
            lpass.Text = "Password";
            // 
            // loginemail
            // 
            loginemail.Location = new Point(46, 175);
            loginemail.Name = "loginemail";
            loginemail.Size = new Size(145, 23);
            loginemail.TabIndex = 13;
            // 
            // lemail
            // 
            lemail.AutoSize = true;
            lemail.Location = new Point(46, 145);
            lemail.Name = "lemail";
            lemail.Size = new Size(36, 15);
            lemail.TabIndex = 12;
            lemail.Text = "Email";
            // 
            // loginform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(276, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Controls.Add(lo);
            Controls.Add(loginpassword);
            Controls.Add(lpass);
            Controls.Add(loginemail);
            Controls.Add(lemail);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "loginform";
            Text = "APTECH LEARING SYSTEM";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Label label4;
        private PictureBox pictureBox1;
        private Button lo;
        private TextBox loginpassword;
        private Label lpass;
        private TextBox loginemail;
        private Label lemail;
    }
}