using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XIIRPL1_05_Ticketing.MasterForm
{
    public partial class FrmJadwalPenerbangan : Form
    {
        ComboBoxFunction cb = new ComboBoxFunction();
        public NpgsqlCommand cmd;
        public NpgsqlDataReader dr;
        public FrmJadwalPenerbangan()
        {
            InitializeComponent();
        }

        private void FrmJadwalPenerbangan_Load(object sender, EventArgs e)
        {
            view_data();
            nomor_urut();

            //ambasing
            // Menambahkan data dari tbl_negara ke txtMaskapai dan txtKe
            string query = "SELECT * FROM public.tbl_bandara";
            // ComboBoxFunction.Set_ComboBox(query, "nama", txtNegara);
            txtDari.DataSource = cb.getData(query);
            txtDari.DisplayMember = "nama";
            txtDari.ValueMember = "id";

            txtKe.DataSource = cb.getData(query);
            txtKe.DisplayMember = "nama";
            txtKe.ValueMember = "id";


            // Menambahkan data dari tbl_maskapai ke txtMaskapai
            string queryMaskapai = "SELECT nama FROM tbl_maskapai";
            ComboBoxFunction.Set_ComboBox(queryMaskapai, "nama", txtMaskapai);
        }

        public void view_data()
        {
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter("SELECT * FROM public.tbl_jadwalpenerbangan", koneksi.conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "public.tbl_jadwalpenerbangan");
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
        }

        public void nomor_urut()
        {
            int hitung, nomor;
            koneksi.conn.Open();
            string sql = "SELECT id FROM tbl_jadwalpenerbangan where id in(select max(id) FROM tbl_jadwalpenerbangan) order by id desc";
            cmd = new NpgsqlCommand(sql, koneksi.conn);
            dr = cmd.ExecuteReader();
            dr.Read();

            if (dr.HasRows)
            {
                nomor = Convert.ToInt32(dr[0]);
                hitung = nomor + 1;
            }
            else
            {
                hitung = 1;
            }
            dr.Close();
            id.Text = Convert.ToString(hitung);
            koneksi.conn.Close();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            koneksi.conn.Open();
            try
            {
                String sql = "INSERT INTO public.tbl_jadwalpenerbangan" +
                    "(id,kodepenerbangan,bandarakeberangkatan,bandaratujuanid,maskapaiid,tanggalkeberangkatan,durasipenerbangan,hargapertiket,waktukeberangkatan)" +
                    "VALUES" +
                    "('" + id.Text + "'," +
                    "'" + txtKode.Text + "'," +
                    "'" + txtDari.SelectedValue + "'," +
                    "'" + txtKe.SelectedValue + "'," +
                    "'" + txtMaskapai.SelectedValue + "'," +
                    "'" + txtTgl.Value + "'," +
                    "'" + txtPertiket.Value + "'," +
                    "'" + txtKeberangkatan.Text + "', " +
                    "'" + dateTimePickerWaktuKeberangkatan.Value + "')";
                cmd = new NpgsqlCommand(sql, koneksi.conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Berhasil simpan data maskapai");
                koneksi.conn.Close();
                view_data();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                koneksi.conn.Close();
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "Delete")
            {
                int id;
                id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id"].Value);
                try
                {
                    koneksi.conn.Open();
                    String sql = "DELETE FROM tbl_jadwalpenerbangan WHERE id=@id";
                    cmd = new NpgsqlCommand(sql, koneksi.conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("data berhasil dihapus");
                        view_data();
                    }
                    else
                    {
                        MessageBox.Show("data gagal dihapus");

                    }

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    koneksi.conn.Close();
                }
            }
        }

  
    }
}

