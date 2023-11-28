namespace XIIRPL1_05_Ticketing.MasterForm
{
    partial class FrmKodePromo
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
            txtDeskripsi = new RichTextBox();
            label8 = new Label();
            label4 = new Label();
            button1 = new Button();
            btnSimpan = new Button();
            txtPromo = new TextBox();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label3 = new Label();
            txtBerlaku = new DateTimePicker();
            txtPresentase = new NumericUpDown();
            label7 = new Label();
            txtMaximum = new NumericUpDown();
            label5 = new Label();
            id = new TextBox();
            Edit = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtPresentase).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtMaximum).BeginInit();
            SuspendLayout();
            // 
            // txtDeskripsi
            // 
            txtDeskripsi.Location = new Point(524, 316);
            txtDeskripsi.Name = "txtDeskripsi";
            txtDeskripsi.Size = new Size(240, 69);
            txtDeskripsi.TabIndex = 64;
            txtDeskripsi.Text = "";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Franklin Gothic Medium", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(441, 318);
            label8.Name = "label8";
            label8.Size = new Size(60, 17);
            label8.TabIndex = 63;
            label8.Text = "Deskripsi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Franklin Gothic Medium", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(37, 364);
            label4.Name = "label4";
            label4.Size = new Size(96, 17);
            label4.TabIndex = 60;
            label4.Text = "Berlaku Sampai";
            // 
            // button1
            // 
            button1.Location = new Point(524, 459);
            button1.Name = "button1";
            button1.RightToLeft = RightToLeft.Yes;
            button1.Size = new Size(81, 27);
            button1.TabIndex = 59;
            button1.Text = "Batal";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(683, 459);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.RightToLeft = RightToLeft.Yes;
            btnSimpan.Size = new Size(81, 27);
            btnSimpan.TabIndex = 58;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // txtPromo
            // 
            txtPromo.Location = new Point(165, 316);
            txtPromo.Name = "txtPromo";
            txtPromo.Size = new Size(200, 23);
            txtPromo.TabIndex = 57;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Franklin Gothic Medium", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(37, 318);
            label2.Name = "label2";
            label2.Size = new Size(77, 17);
            label2.TabIndex = 55;
            label2.Text = "Kode Promo";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Edit, Delete });
            dataGridView1.Location = new Point(37, 89);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(727, 201);
            dataGridView1.TabIndex = 54;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Medium", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(37, 54);
            label1.Name = "label1";
            label1.Size = new Size(312, 17);
            label1.TabIndex = 53;
            label1.Text = "Semua Kode Promo Yang Terdaftar Akan Muncul Disini";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Franklin Gothic Medium", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(37, 19);
            label3.Name = "label3";
            label3.Size = new Size(264, 34);
            label3.TabIndex = 52;
            label3.Text = "Master Kode Promo";
            // 
            // txtBerlaku
            // 
            txtBerlaku.Location = new Point(165, 362);
            txtBerlaku.Name = "txtBerlaku";
            txtBerlaku.Size = new Size(200, 23);
            txtBerlaku.TabIndex = 65;
            // 
            // txtPresentase
            // 
            txtPresentase.Location = new Point(165, 411);
            txtPresentase.Name = "txtPresentase";
            txtPresentase.Size = new Size(200, 23);
            txtPresentase.TabIndex = 80;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Franklin Gothic Medium", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(37, 412);
            label7.Name = "label7";
            label7.Size = new Size(111, 17);
            label7.TabIndex = 79;
            label7.Text = "Presentase diskon";
            // 
            // txtMaximum
            // 
            txtMaximum.Location = new Point(165, 463);
            txtMaximum.Name = "txtMaximum";
            txtMaximum.Size = new Size(200, 23);
            txtMaximum.TabIndex = 82;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Franklin Gothic Medium", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(37, 464);
            label5.Name = "label5";
            label5.Size = new Size(110, 17);
            label5.TabIndex = 81;
            label5.Text = "Maksimum diskon";
            // 
            // id
            // 
            id.Location = new Point(592, 48);
            id.Name = "id";
            id.Size = new Size(31, 23);
            id.TabIndex = 83;
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
            // FrmKodePromo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(800, 614);
            Controls.Add(id);
            Controls.Add(txtMaximum);
            Controls.Add(label5);
            Controls.Add(txtPresentase);
            Controls.Add(label7);
            Controls.Add(txtBerlaku);
            Controls.Add(txtDeskripsi);
            Controls.Add(label8);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(btnSimpan);
            Controls.Add(txtPromo);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(label3);
            Name = "FrmKodePromo";
            Text = "FrmKodePromo";
            Load += FrmKodePromo_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtPresentase).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtMaximum).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox txtDeskripsi;
        private Label label8;
        private Label label4;
        private Button button1;
        private Button btnSimpan;
        private TextBox txtPromo;
        private Label label2;
        private DataGridView dataGridView1;
        private Label label1;
        private Label label3;
        private DateTimePicker txtBerlaku;
        private NumericUpDown txtPresentase;
        private Label label7;
        private NumericUpDown txtMaximum;
        private Label label5;
        private TextBox id;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Delete;
    }
}