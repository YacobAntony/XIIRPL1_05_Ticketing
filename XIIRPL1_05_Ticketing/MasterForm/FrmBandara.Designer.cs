namespace XIIRPL1_05_Ticketing.MasterForm
{
    partial class FrmBandara
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
            label3 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            Edit = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            btnSimpan = new Button();
            txtKota = new TextBox();
            txtIata = new TextBox();
            txtNama = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            txtNegara = new ComboBox();
            txtJumlahTerminal = new NumericUpDown();
            label8 = new Label();
            txtAlamat = new RichTextBox();
            btnBatalbandara = new Button();
            id = new TextBox();
            btnEdit = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtJumlahTerminal).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Franklin Gothic Medium", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(37, 25);
            label3.Name = "label3";
            label3.Size = new Size(217, 34);
            label3.TabIndex = 2;
            label3.Text = "Master Bandara";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Medium", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(37, 60);
            label1.Name = "label1";
            label1.Size = new Size(290, 17);
            label1.TabIndex = 3;
            label1.Text = "Semua Bandara Yang Terdaftar Akan Muncul Disini";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Edit, Delete });
            dataGridView1.Location = new Point(37, 95);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(727, 201);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
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
            // btnSimpan
            // 
            btnSimpan.Location = new Point(683, 473);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.RightToLeft = RightToLeft.Yes;
            btnSimpan.Size = new Size(81, 27);
            btnSimpan.TabIndex = 24;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // txtKota
            // 
            txtKota.Location = new Point(166, 394);
            txtKota.Name = "txtKota";
            txtKota.Size = new Size(200, 23);
            txtKota.TabIndex = 23;
            // 
            // txtIata
            // 
            txtIata.Location = new Point(166, 359);
            txtIata.Name = "txtIata";
            txtIata.Size = new Size(200, 23);
            txtIata.TabIndex = 20;
            // 
            // txtNama
            // 
            txtNama.Location = new Point(166, 322);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(200, 23);
            txtNama.TabIndex = 19;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Franklin Gothic Medium", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(37, 396);
            label7.Name = "label7";
            label7.Size = new Size(34, 17);
            label7.TabIndex = 18;
            label7.Text = "Kota";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Franklin Gothic Medium", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(37, 434);
            label6.Name = "label6";
            label6.Size = new Size(48, 17);
            label6.TabIndex = 17;
            label6.Text = "Negara";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Franklin Gothic Medium", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(409, 324);
            label5.Name = "label5";
            label5.Size = new Size(99, 17);
            label5.TabIndex = 16;
            label5.Text = "Jumlah Terminal";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Franklin Gothic Medium", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(37, 361);
            label4.Name = "label4";
            label4.Size = new Size(64, 17);
            label4.TabIndex = 15;
            label4.Text = "kode IATA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Franklin Gothic Medium", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(37, 324);
            label2.Name = "label2";
            label2.Size = new Size(41, 17);
            label2.TabIndex = 14;
            label2.Text = "Nama";
            // 
            // txtNegara
            // 
            txtNegara.FormattingEnabled = true;
            txtNegara.Location = new Point(166, 434);
            txtNegara.Name = "txtNegara";
            txtNegara.Size = new Size(200, 23);
            txtNegara.TabIndex = 25;
            txtNegara.SelectedIndexChanged += txtNegara_SelectedIndexChanged;
            // 
            // txtJumlahTerminal
            // 
            txtJumlahTerminal.Location = new Point(544, 322);
            txtJumlahTerminal.Name = "txtJumlahTerminal";
            txtJumlahTerminal.Size = new Size(220, 23);
            txtJumlahTerminal.TabIndex = 26;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Franklin Gothic Medium", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(409, 361);
            label8.Name = "label8";
            label8.Size = new Size(48, 17);
            label8.TabIndex = 27;
            label8.Text = "Alamat";
            label8.Click += label8_Click;
            // 
            // txtAlamat
            // 
            txtAlamat.Location = new Point(544, 359);
            txtAlamat.Name = "txtAlamat";
            txtAlamat.Size = new Size(220, 67);
            txtAlamat.TabIndex = 28;
            txtAlamat.Text = "";
            // 
            // btnBatalbandara
            // 
            btnBatalbandara.Location = new Point(482, 473);
            btnBatalbandara.Name = "btnBatalbandara";
            btnBatalbandara.RightToLeft = RightToLeft.Yes;
            btnBatalbandara.Size = new Size(81, 27);
            btnBatalbandara.TabIndex = 29;
            btnBatalbandara.Text = "Batal";
            btnBatalbandara.UseVisualStyleBackColor = true;
            // 
            // id
            // 
            id.Location = new Point(408, 403);
            id.Name = "id";
            id.Size = new Size(100, 23);
            id.TabIndex = 30;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(584, 473);
            btnEdit.Name = "btnEdit";
            btnEdit.RightToLeft = RightToLeft.Yes;
            btnEdit.Size = new Size(81, 27);
            btnEdit.TabIndex = 31;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // FrmBandara
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(800, 523);
            Controls.Add(btnEdit);
            Controls.Add(id);
            Controls.Add(btnBatalbandara);
            Controls.Add(txtAlamat);
            Controls.Add(label8);
            Controls.Add(txtJumlahTerminal);
            Controls.Add(txtNegara);
            Controls.Add(btnSimpan);
            Controls.Add(txtKota);
            Controls.Add(txtIata);
            Controls.Add(txtNama);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(label3);
            Name = "FrmBandara";
            Text = "FrmBandara";
            Load += FrmBandara_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtJumlahTerminal).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private Label label1;
        private DataGridView dataGridView1;
        private Button btnSimpan;
        private TextBox txtKota;
        private TextBox txtIata;
        private TextBox txtNama;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label2;
        private ComboBox txtNegara;
        private NumericUpDown txtJumlahTerminal;
        private Label label8;
        private RichTextBox txtAlamat;
        private Button btnBatalbandara;
        private TextBox id;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Delete;
        private Button btnEdit;
    }
}