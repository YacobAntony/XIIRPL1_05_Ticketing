namespace XIIRPL1_05_Ticketing.MasterForm
{
    partial class FrmMaskapai
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
            button1 = new Button();
            btnSimpan = new Button();
            txtNama = new TextBox();
            label5 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtPerusahaan = new TextBox();
            txtKru = new TextBox();
            txtDeskripsi = new RichTextBox();
            label8 = new Label();
            id = new TextBox();
            Edit = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(547, 517);
            button1.Name = "button1";
            button1.RightToLeft = RightToLeft.Yes;
            button1.Size = new Size(81, 27);
            button1.TabIndex = 46;
            button1.Text = "Batal";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(683, 517);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.RightToLeft = RightToLeft.Yes;
            btnSimpan.Size = new Size(81, 27);
            btnSimpan.TabIndex = 41;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // txtNama
            // 
            txtNama.Location = new Point(144, 370);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(200, 23);
            txtNama.TabIndex = 38;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Franklin Gothic Medium", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(37, 467);
            label5.Name = "label5";
            label5.Size = new Size(70, 17);
            label5.TabIndex = 35;
            label5.Text = "Jumlah Kru";
            label5.Click += label5_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Franklin Gothic Medium", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(37, 372);
            label2.Name = "label2";
            label2.Size = new Size(41, 17);
            label2.TabIndex = 33;
            label2.Text = "Nama";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Edit, Delete });
            dataGridView1.Location = new Point(37, 95);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(727, 242);
            dataGridView1.TabIndex = 32;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Medium", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(37, 60);
            label1.Name = "label1";
            label1.Size = new Size(297, 17);
            label1.TabIndex = 31;
            label1.Text = "Semua Maskapai Yang Terdaftar Akan Muncul Disini";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Franklin Gothic Medium", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(37, 25);
            label3.Name = "label3";
            label3.Size = new Size(233, 34);
            label3.TabIndex = 30;
            label3.Text = "Master Maskapai";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Franklin Gothic Medium", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(37, 418);
            label4.Name = "label4";
            label4.Size = new Size(75, 17);
            label4.TabIndex = 47;
            label4.Text = "Perusahaan";
            // 
            // txtPerusahaan
            // 
            txtPerusahaan.Location = new Point(144, 414);
            txtPerusahaan.Name = "txtPerusahaan";
            txtPerusahaan.Size = new Size(200, 23);
            txtPerusahaan.TabIndex = 48;
            // 
            // txtKru
            // 
            txtKru.Location = new Point(144, 465);
            txtKru.Name = "txtKru";
            txtKru.Size = new Size(200, 23);
            txtKru.TabIndex = 49;
            // 
            // txtDeskripsi
            // 
            txtDeskripsi.Location = new Point(544, 370);
            txtDeskripsi.Name = "txtDeskripsi";
            txtDeskripsi.Size = new Size(220, 116);
            txtDeskripsi.TabIndex = 51;
            txtDeskripsi.Text = "";
            txtDeskripsi.TextChanged += richTextBox1_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Franklin Gothic Medium", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(458, 376);
            label8.Name = "label8";
            label8.Size = new Size(60, 17);
            label8.TabIndex = 50;
            label8.Text = "Deskripsi";
            label8.Click += label8_Click;
            // 
            // id
            // 
            id.Location = new Point(724, 54);
            id.Name = "id";
            id.Size = new Size(40, 23);
            id.TabIndex = 52;
            id.Visible = false;
            // 
            // Edit
            // 
            Edit.HeaderText = "Edit";
            Edit.Name = "Edit";
            Edit.Text = "Edit";
            Edit.UseColumnTextForButtonValue = true;
            // 
            // Delete
            // 
            Delete.HeaderText = "Delete";
            Delete.Name = "Delete";
            Delete.Text = "Delete";
            Delete.UseColumnTextForButtonValue = true;
            // 
            // FrmMaskapai
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(800, 560);
            Controls.Add(id);
            Controls.Add(txtDeskripsi);
            Controls.Add(label8);
            Controls.Add(txtKru);
            Controls.Add(txtPerusahaan);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(btnSimpan);
            Controls.Add(txtNama);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(label3);
            Name = "FrmMaskapai";
            Text = "FrmMaskapai";
            Load += FrmMaskapai_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button btnDaftar;
        private TextBox txtUsername;
        private Label label5;
        private Label label2;
        private DataGridView dataGridView1;
        private Label label1;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private RichTextBox richTextBox1;
        private Label label8;
        private Button btnSimpan;
        private TextBox txtNama;
        private TextBox txtPerusahaan;
        private TextBox txtKru;
        private RichTextBox txtDeskripsi;
        private TextBox id;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Delete;
    }
}