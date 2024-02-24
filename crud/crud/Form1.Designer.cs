namespace crud
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
            Rname = new Label();
            name = new TextBox();
            Remail = new Label();
            USEREAMIL = new TextBox();
            Rpassword = new Label();
            USERPASSWORD = new TextBox();
            REG = new Button();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            label5 = new Label();
            connection = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Rname
            // 
            Rname.AutoSize = true;
            Rname.Location = new Point(37, 122);
            Rname.Name = "Rname";
            Rname.Size = new Size(60, 15);
            Rname.TabIndex = 0;
            Rname.Text = "Username";
            Rname.Click += label1_Click;
            // 
            // name
            // 
            name.Location = new Point(37, 153);
            name.Name = "name";
            name.Size = new Size(146, 23);
            name.TabIndex = 1;
            name.TextChanged += textBox1_TextChanged;
            // 
            // Remail
            // 
            Remail.AutoSize = true;
            Remail.Location = new Point(38, 196);
            Remail.Name = "Remail";
            Remail.Size = new Size(36, 15);
            Remail.TabIndex = 2;
            Remail.Text = "Email";
            // 
            // USEREAMIL
            // 
            USEREAMIL.Location = new Point(38, 226);
            USEREAMIL.Name = "USEREAMIL";
            USEREAMIL.Size = new Size(145, 23);
            USEREAMIL.TabIndex = 3;
            // 
            // Rpassword
            // 
            Rpassword.AutoSize = true;
            Rpassword.Location = new Point(40, 271);
            Rpassword.Name = "Rpassword";
            Rpassword.Size = new Size(57, 15);
            Rpassword.TabIndex = 4;
            Rpassword.Text = "Password";
            // 
            // USERPASSWORD
            // 
            USERPASSWORD.Location = new Point(37, 300);
            USERPASSWORD.Name = "USERPASSWORD";
            USERPASSWORD.PasswordChar = '*';
            USERPASSWORD.Size = new Size(145, 23);
            USERPASSWORD.TabIndex = 5;
            // 
            // REG
            // 
            REG.BackColor = SystemColors.ScrollBar;
            REG.ForeColor = SystemColors.ActiveCaptionText;
            REG.Location = new Point(60, 360);
            REG.Name = "REG";
            REG.Size = new Size(94, 23);
            REG.TabIndex = 6;
            REG.Text = "Registration";
            REG.UseVisualStyleBackColor = false;
            REG.Click += REG_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(37, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(162, 81);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 336);
            label4.Name = "label4";
            label4.Size = new Size(99, 15);
            label4.TabIndex = 8;
            label4.Text = "have an account?";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(146, 336);
            label5.Name = "label5";
            label5.Size = new Size(37, 15);
            label5.TabIndex = 9;
            label5.Text = "Login";
            label5.Click += label5_Click;
            // 
            // connection
            // 
            connection.Location = new Point(60, 389);
            connection.Name = "connection";
            connection.Size = new Size(92, 23);
            connection.TabIndex = 10;
            connection.Text = "connect";
            connection.UseVisualStyleBackColor = true;
            connection.Click += connection_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(290, 450);
            Controls.Add(connection);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Controls.Add(REG);
            Controls.Add(USERPASSWORD);
            Controls.Add(Rpassword);
            Controls.Add(USEREAMIL);
            Controls.Add(Remail);
            Controls.Add(name);
            Controls.Add(Rname);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "APTECH LEARING SYSTEM";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Rname;
        private TextBox name;
        private Label Remail;
        private TextBox USEREAMIL;
        private Label Rpassword;
        private TextBox USERPASSWORD;
        private Button REG;
        private PictureBox pictureBox1;
        private Label label4;
        private Label label5;
        private Button connection;
    }
}