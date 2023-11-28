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
    public partial class FrmKodePromo : Form
    {
        public NpgsqlCommand cmd;
        public NpgsqlDataReader dr;
        public FrmKodePromo()
        {
            InitializeComponent();
        }

        private void FrmKodePromo_Load(object sender, EventArgs e)
        {

            view_data();
            nomor_urut();

        }



        public void view_data()
        {
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter("SELECT * FROM public.tbl_kodepromo", koneksi.conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "public.tbl_kodepromo");
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
        }

        public void nomor_urut()
        {
            int hitung, nomor;
            koneksi.conn.Open();
            string sql = "SELECT id FROM tbl_kodepromo where id in(select max(id) FROM tbl_kodepromo) order by id desc";
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
                String sql = "INSERT INTO public.tbl_kodepromo" +
                    "(id,kode,presentasediskon,maxdiskon,berlakusampai,deskripsi)" +
                    "VALUES" +
                    "('" + id.Text + "'," +
                    "'" + txtPromo.Text + "'," +
                    "'" + txtPresentase.Text + "'," +
                    "'" + txtMaximum.Text + "'," +
                    "'" + txtBerlaku.Value + "'," +
                    "'" + txtDeskripsi.Text + "')";
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "Delete")
            {
                int id;
                id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id"].Value);
                try
                {
                    koneksi.conn.Open();
                    String sql = "DELETE FROM tbl_kodepromo WHERE id=@id";
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

