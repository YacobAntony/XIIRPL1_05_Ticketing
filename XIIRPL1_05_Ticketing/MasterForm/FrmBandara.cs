using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace XIIRPL1_05_Ticketing.MasterForm
{
    public partial class FrmBandara : Form
    {
        ComboBoxFunction cb = new ComboBoxFunction();
        public NpgsqlCommand cmd;
        public NpgsqlDataReader dr;
        int Record_id;
        public FrmBandara()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmBandara_Load(object sender, EventArgs e)
        {
            view_data();
            nomor_urut();

            //ambasing
            string query = "SELECT * FROM public.tbl_negara";
            // ComboBoxFunction.Set_ComboBox(query, "nama", txtNegara);
            txtNegara.DataSource = cb.getData(query);
            txtNegara.DisplayMember = "nama";
            txtNegara.ValueMember = "id";
        }


        private void txtTgllahir_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            koneksi.conn.Open();
            try
            {
                String sql = "INSERT INTO public.tbl_bandara" +
                    "(id,nama,kodeiata,kota,negara_id,jumlahterminal,alamat)" +
                    "VALUES" +
                    "('" + id.Text + "'," +
                    "'" + txtNama.Text + "'," +
                    "'" + txtIata.Text + "'," +
                    "'" + txtKota.Text + "'," +
                    "'" + txtNegara.SelectedValue + "'," +
                    "'" + txtJumlahTerminal.Text + "'," +
                    "'" + txtAlamat.Text + "')";
                cmd = new NpgsqlCommand(sql, koneksi.conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Berhasil simpan data bandara");
                koneksi.conn.Close();
                view_data();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        public void view_data()
        {

            string sql = "SELECT tbl_bandara.id," + "tbl_bandara.nama," + "tbl_bandara.kodeiata," + "tbl_bandara.kota," + "tbl_negara.nama," + "tbl_bandara.jumlahterminal" + "FROM tbl_bandara INNER JOIN" + "tbl_negara ON tbl_bandara.negara_id = tbl_negara.id";

            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter("SELECT * FROM public.tbl_bandara", koneksi.conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[2].HeaderText = "ID";
            dataGridView1.Columns[3].HeaderText = "Nama Bandara";
            dataGridView1.Columns[4].HeaderText = "Kode iata";
            dataGridView1.Columns[5].HeaderText = "Kota";
            // DataSet ds = new DataSet();
            ///apter.Fill(ds, "public.tbl_bandara");
            // dataGridView1.DataSource = ds.Tables[0].DefaultView;
        }

        public void nomor_urut()
        {
            int hitung, nomor;
            koneksi.conn.Open();
            string sql = "SELECT id FROM tbl_bandara where id in(select max(id) FROM tbl_bandara) order by id desc";
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "Delete")
            {
                int id;
                id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id"].Value);
                try
                {
                    koneksi.conn.Open();
                    String sql = "DELETE FROM tbl_bandara WHERE id=@id";
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
            if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "Edit")
            {
                id.Text = Convert.ToString(dataGridView1.Rows[e.ColumnIndex].Cells["id"].Value);
                txtNama.Text = Convert.ToString(dataGridView1.Rows[e.ColumnIndex].Cells["nama"].Value);
                txtIata.Text = Convert.ToString(dataGridView1.Rows[e.ColumnIndex].Cells["kodeiata"].Value);
                txtKota.Text = Convert.ToString(dataGridView1.Rows[e.ColumnIndex].Cells["kota"].Value);
                txtNegara.Text = Convert.ToString(dataGridView1.Rows[e.ColumnIndex].Cells["negara_id"].Value);
                txtJumlahTerminal.Text = Convert.ToString(dataGridView1.Rows[e.ColumnIndex].Cells["jumlahterminal"].Value);
                txtAlamat.Text = Convert.ToString(dataGridView1.Rows[e.ColumnIndex].Cells["alamat"].Value);

                btnSimpan.Enabled = false;

            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                koneksi.conn.Open();
                String sql = "UPDATE public.tbl_bandara SET nama='" + txtNama.Text + "',kodeiata='" + txtIata.Text + "',kota='" + txtKota.Text + "', negara_id='" + txtNegara.Text + "', jumlahterminal='" + txtJumlahTerminal.Text + "',alamat='" + txtAlamat.Text + "'";
                cmd = new NpgsqlCommand(sql, koneksi.conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Berhasil edit data bandara");
                view_data();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtNegara_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
