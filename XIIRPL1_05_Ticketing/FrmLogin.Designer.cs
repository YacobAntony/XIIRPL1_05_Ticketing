namespace XIIRPL1_05_Ticketing
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            pictureBox1 = new PictureBox();
            lbl = new Label();
            txtPw = new Label();
            textUsername = new TextBox();
            textPassword = new TextBox();
            btnLogin = new Button();
            label1 = new Label();
            linkLabel1 = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(153, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(508, 162);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl.Location = new Point(153, 219);
            lbl.Name = "lbl";
            lbl.Size = new Size(80, 21);
            lbl.TabIndex = 1;
            lbl.Text = "Username";
            lbl.Click += label1_Click;
            // 
            // txtPw
            // 
            txtPw.AutoSize = true;
            txtPw.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPw.Location = new Point(153, 280);
            txtPw.Name = "txtPw";
            txtPw.Size = new Size(76, 21);
            txtPw.TabIndex = 2;
            txtPw.Text = "Password";
            // 
            // textUsername
            // 
            textUsername.BackColor = SystemColors.Window;
            textUsername.Cursor = Cursors.No;
            textUsername.Location = new Point(299, 219);
            textUsername.Multiline = true;
            textUsername.Name = "textUsername";
            textUsername.Size = new Size(227, 27);
            textUsername.TabIndex = 3;
            textUsername.TextChanged += textBox1_TextChanged;
            // 
            // textPassword
            // 
            textPassword.BackColor = SystemColors.Window;
            textPassword.Cursor = Cursors.No;
            textPassword.Location = new Point(299, 274);
            textPassword.Multiline = true;
            textPassword.Name = "textPassword";
            textPassword.Size = new Size(227, 27);
            textPassword.TabIndex = 4;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.ControlLight;
            btnLogin.Location = new Point(565, 355);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(96, 30);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Medium", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(233, 393);
            label1.Name = "label1";
            label1.Size = new Size(109, 16);
            label1.TabIndex = 6;
            label1.Text = "Belum Punya Akun ?";
            label1.Click += label1_Click_1;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Franklin Gothic Medium", 9F, FontStyle.Italic, GraphicsUnit.Point);
            linkLabel1.Location = new Point(361, 393);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(95, 16);
            linkLabel1.TabIndex = 7;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Daftar Sekarang !";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(800, 450);
            Controls.Add(linkLabel1);
            Controls.Add(label1);
            Controls.Add(btnLogin);
            Controls.Add(textPassword);
            Controls.Add(textUsername);
            Controls.Add(txtPw);
            Controls.Add(lbl);
            Controls.Add(pictureBox1);
            Name = "FrmLogin";
            Text = "Form1";
            Load += FrmLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lbl;
        private Label txtPw;
        private TextBox textUsername;
        private TextBox textPassword;
        private Button btnLogin;
        private Label label1;
        private LinkLabel linkLabel1;
    }
}