namespace XIIRPL1_05_Ticketing.MasterForm
{
    partial class FrmJadwalPenerbangan
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
            txtPertiket = new NumericUpDown();
            txtKeberangkatan = new TextBox();
            label10 = new Label();
            label9 = new Label();
            txtTgl = new DateTimePicker();
            txtKe = new ComboBox();
            txtDari = new ComboBox();
            btnSimpan = new Button();
            button1 = new Button();
            label8 = new Label();
            label7 = new Label();
            txtMaskapai = new ComboBox();
            txtKode = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            Edit = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            label2 = new Label();
            label1 = new Label();
            id = new TextBox();
            dateTimePickerWaktuKeberangkatan = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)txtPertiket).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtPertiket
            // 
            txtPertiket.Location = new Point(545, 377);
            txtPertiket.Name = "txtPertiket";
            txtPertiket.Size = new Size(229, 23);
            txtPertiket.TabIndex = 62;
            // 
            // txtKeberangkatan
            // 
            txtKeberangkatan.Location = new Point(545, 343);
            txtKeberangkatan.Name = "txtKeberangkatan";
            txtKeberangkatan.Size = new Size(229, 23);
            txtKeberangkatan.TabIndex = 61;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(417, 379);
            label10.Name = "label10";
            label10.Size = new Size(87, 15);
            label10.TabIndex = 59;
            label10.Text = "Harga Per Tiket";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(417, 346);
            label9.Name = "label9";
            label9.Size = new Size(113, 15);
            label9.TabIndex = 58;
            label9.Text = "Durasi Penerbangan";
            label9.Click += label9_Click;
            // 
            // txtTgl
            // 
            txtTgl.Location = new Point(545, 284);
            txtTgl.Name = "txtTgl";
            txtTgl.Size = new Size(229, 23);
            txtTgl.TabIndex = 57;
            // 
            // txtKe
            // 
            txtKe.FormattingEnabled = true;
            txtKe.Location = new Point(136, 343);
            txtKe.Name = "txtKe";
            txtKe.Size = new Size(210, 23);
            txtKe.TabIndex = 56;
            // 
            // txtDari
            // 
            txtDari.FormattingEnabled = true;
            txtDari.Location = new Point(136, 311);
            txtDari.Name = "txtDari";
            txtDari.Size = new Size(210, 23);
            txtDari.TabIndex = 55;
            txtDari.SelectedIndexChanged += txtDari_SelectedIndexChanged;
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(611, 418);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(75, 23);
            btnSimpan.TabIndex = 54;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // button1
            // 
            button1.Location = new Point(452, 418);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 53;
            button1.Text = "Batal";
            button1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(417, 316);
            label8.Name = "label8";
            label8.Size = new Size(123, 15);
            label8.TabIndex = 52;
            label8.Text = "Waktu Keberangkatan";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(417, 290);
            label7.Name = "label7";
            label7.Size = new Size(48, 15);
            label7.TabIndex = 51;
            label7.Text = "Tanggal";
            // 
            // txtMaskapai
            // 
            txtMaskapai.FormattingEnabled = true;
            txtMaskapai.Location = new Point(136, 376);
            txtMaskapai.Name = "txtMaskapai";
            txtMaskapai.Size = new Size(210, 23);
            txtMaskapai.TabIndex = 50;
            // 
            // txtKode
            // 
            txtKode.Location = new Point(136, 282);
            txtKode.Name = "txtKode";
            txtKode.Size = new Size(210, 23);
            txtKode.TabIndex = 49;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 379);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 48;
            label6.Text = "Maskapai";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 346);
            label5.Name = "label5";
            label5.Size = new Size(20, 15);
            label5.TabIndex = 47;
            label5.Text = "Ke";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 316);
            label4.Name = "label4";
            label4.Size = new Size(28, 15);
            label4.TabIndex = 46;
            label4.Text = "Dari";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 285);
            label3.Name = "label3";
            label3.Size = new Size(107, 15);
            label3.TabIndex = 45;
            label3.Text = "Kode Penerbangan";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Edit, Delete });
            dataGridView1.Location = new Point(12, 66);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(772, 201);
            dataGridView1.TabIndex = 44;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 33);
            label2.Name = "label2";
            label2.Size = new Size(260, 15);
            label2.TabIndex = 43;
            label2.Text = "Semua Jadwal Penerbangan Akan Muncul Disini";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 10);
            label1.Name = "label1";
            label1.Size = new Size(225, 21);
            label1.TabIndex = 42;
            label1.Text = "Master Jadwal Penerbangan";
            // 
            // id
            // 
            id.Location = new Point(372, 12);
            id.Name = "id";
            id.Size = new Size(23, 23);
            id.TabIndex = 63;
            // 
            // dateTimePickerWaktuKeberangkatan
            // 
            dateTimePickerWaktuKeberangkatan.Format = DateTimePickerFormat.Time;
            dateTimePickerWaktuKeberangkatan.Location = new Point(545, 314);
            dateTimePickerWaktuKeberangkatan.Name = "dateTimePickerWaktuKeberangkatan";
            dateTimePickerWaktuKeberangkatan.Size = new Size(124, 23);
            dateTimePickerWaktuKeberangkatan.TabIndex = 64;
            // 
            // FrmJadwalPenerbangan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dateTimePickerWaktuKeberangkatan);
            Controls.Add(id);
            Controls.Add(txtPertiket);
            Controls.Add(txtKeberangkatan);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(txtTgl);
            Controls.Add(txtKe);
            Controls.Add(txtDari);
            Controls.Add(btnSimpan);
            Controls.Add(button1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(txtMaskapai);
            Controls.Add(txtKode);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmJadwalPenerbangan";
            Text = "FrmJadwalPenerbangan1";
            Load += FrmJadwalPenerbangan_Load;
            ((System.ComponentModel.ISupportInitialize)txtPertiket).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown txtPertiket;
        private TextBox txtKeberangkatan;
        private TextBox txtWaktukeberangkatan;
        private Label label10;
        private Label label9;
        private DateTimePicker txtTgl;
        private ComboBox txtKe;
        private ComboBox txtDari;
        private Button btnSimpan;
        private Button button1;
        private Label label8;
        private Label label7;
        private ComboBox txtMaskapai;
        private TextBox txtKode;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private DataGridView dataGridView1;
        private Label label2;
        private Label label1;
        private TextBox id;
        private DateTimePicker dateTimePickerWaktuKeberangkatan;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Delete;
    }
}