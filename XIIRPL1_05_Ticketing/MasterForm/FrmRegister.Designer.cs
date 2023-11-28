namespace XIIRPL1_05_Ticketing.MasterForm
{
    partial class FrmRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegister));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtUsername = new TextBox();
            textNama = new TextBox();
            txtTgllahir = new DateTimePicker();
            txtNomertlp = new TextBox();
            txtPassword = new TextBox();
            pictureBox1 = new PictureBox();
            btnDaftar = new Button();
            Login = new LinkLabel();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Medium", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(37, 44);
            label1.Name = "label1";
            label1.Size = new Size(168, 34);
            label1.TabIndex = 0;
            label1.Text = "Daftar Akun";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Franklin Gothic Medium", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(37, 78);
            label2.Name = "label2";
            label2.Size = new Size(321, 17);
            label2.TabIndex = 1;
            label2.Text = "Daftarkan Diri Anda Untuk Menggunakan Bromo Airlines";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Franklin Gothic Medium", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(44, 121);
            label3.Name = "label3";
            label3.Size = new Size(65, 17);
            label3.TabIndex = 2;
            label3.Text = "Username";
            label3.Click += label3_Click_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Franklin Gothic Medium", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(44, 156);
            label4.Name = "label4";
            label4.Size = new Size(41, 17);
            label4.TabIndex = 3;
            label4.Text = "Nama";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Franklin Gothic Medium", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(44, 190);
            label5.Name = "label5";
            label5.Size = new Size(82, 17);
            label5.TabIndex = 4;
            label5.Text = "Tanggal Lahir";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Franklin Gothic Medium", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(44, 228);
            label6.Name = "label6";
            label6.Size = new Size(92, 17);
            label6.TabIndex = 5;
            label6.Text = "Nomor Telepon";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Franklin Gothic Medium", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(44, 266);
            label7.Name = "label7";
            label7.Size = new Size(62, 17);
            label7.TabIndex = 6;
            label7.Text = "Password";
            label7.Click += label7_Click;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(197, 121);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(200, 23);
            txtUsername.TabIndex = 7;
            txtUsername.TextChanged += txtUsername_TextChanged;
            // 
            // textNama
            // 
            textNama.Location = new Point(197, 156);
            textNama.Name = "textNama";
            textNama.Size = new Size(200, 23);
            textNama.TabIndex = 8;
            textNama.TextChanged += textNama_TextChanged;
            // 
            // txtTgllahir
            // 
            txtTgllahir.Location = new Point(197, 190);
            txtTgllahir.Name = "txtTgllahir";
            txtTgllahir.Size = new Size(200, 23);
            txtTgllahir.TabIndex = 9;
            txtTgllahir.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // txtNomertlp
            // 
            txtNomertlp.Location = new Point(197, 226);
            txtNomertlp.Name = "txtNomertlp";
            txtNomertlp.Size = new Size(200, 23);
            txtNomertlp.TabIndex = 10;
            txtNomertlp.TextChanged += textBox3_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(197, 264);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(200, 23);
            txtPassword.TabIndex = 11;
            txtPassword.TextChanged += textBox4_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(473, 91);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(289, 243);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // btnDaftar
            // 
            btnDaftar.Location = new Point(316, 307);
            btnDaftar.Name = "btnDaftar";
            btnDaftar.RightToLeft = RightToLeft.Yes;
            btnDaftar.Size = new Size(81, 27);
            btnDaftar.TabIndex = 13;
            btnDaftar.Text = "Daftar";
            btnDaftar.UseVisualStyleBackColor = true;
            btnDaftar.Click += button1_Click;
            // 
            // Login
            // 
            Login.AutoSize = true;
            Login.Font = new Font("Franklin Gothic Medium", 9F, FontStyle.Italic, GraphicsUnit.Point);
            Login.Location = new Point(132, 410);
            Login.Name = "Login";
            Login.Size = new Size(96, 16);
            Login.TabIndex = 15;
            Login.TabStop = true;
            Login.Text = "Masuk Sekarang !";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Franklin Gothic Medium", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label8.Location = new Point(17, 410);
            label8.Name = "label8";
            label8.Size = new Size(108, 16);
            label8.TabIndex = 14;
            label8.Text = "Sudsh Punya Akun ?";
            label8.Click += label8_Click;
            // 
            // FrmRegister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(800, 450);
            Controls.Add(Login);
            Controls.Add(label8);
            Controls.Add(btnDaftar);
            Controls.Add(pictureBox1);
            Controls.Add(txtPassword);
            Controls.Add(txtNomertlp);
            Controls.Add(txtTgllahir);
            Controls.Add(textNama);
            Controls.Add(txtUsername);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmRegister";
            Text = "FrmRegister";
            Load += FrmRegister_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtUsername;
        private TextBox textNama;
        private DateTimePicker txtTgllahir;
        private TextBox txtNomertlp;
        private TextBox txtPassword;
        private PictureBox pictureBox1;
        private Button btnDaftar;
        private LinkLabel Login;
        private Label label8;
    }
}