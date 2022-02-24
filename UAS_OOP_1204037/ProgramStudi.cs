using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace UAS_OOP_1204037
{
    public partial class ProgramStudi : Form
    {
        public ProgramStudi()
        {
            InitializeComponent();
        }

        //membuat method updateDB dengan parameter cmd
        private void UpdateDB(string cmd)
        {
            //exception handler
            try
            {
                //connection untuk koneksi ke basisdata 1204037
                SqlConnection myConnection = new SqlConnection(@"Data Source=SAFWAN\SAFWANJIHYO; Initial Catalog = UAS; Integrated Security = True");

                //membuka koneksi, menggunakan object myConnection
                myConnection.Open();

                //membuat objek dengan nama myCommand, inisialisasi dari class sqlCommand
                SqlCommand myCommand = new SqlCommand();

                //menetapkan koneksi basisdata yang digunakan yaitu object myConnection
                myCommand.Connection = myConnection;

                //mengatur query yang digunakan, diambil dari parameter cmd
                myCommand.CommandText = cmd;

                //eksekusi myCommand yang diambil dari parameter cmd
                myCommand.ExecuteNonQuery();

                //menampilkan pesan jika eksekusi berhasil
                MessageBox.Show("Data Berhasil Disubmit !", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //penanganan apabila terjadi error pada saat try, exception diset dalam variabel ex
            catch (Exception ex)
            {
                //menampilkan pesan kesalahan
                MessageBox.Show(ex.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void ProgramStudi_Load(object sender, EventArgs e)
        {

        }

        private void clear()
        {
            //mengosongkan isian dalam textbox
            txtKodeProdi.Text = "";
            txtNamaProdi.Text = "";
            txtSingkatan.Text = "";
            txtBiayaKuliah.Text = "";
        }

        //event Handler click control btn Save
        private void btnSave_Click(object sender, EventArgs e)
        {
            //perintah sql untuk menyimpan data inputan ke basis data
            string myCmd = "INSERT INTO ms_prodi Values('"
                + txtKodeProdi.Text + "','"
                + txtNamaProdi.Text + "','"
                + txtSingkatan.Text + "','"
                + txtBiayaKuliah.Text + "')";

            //memanggil method UpdateDB dengn set parameter myCMD
            UpdateDB(myCmd);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}
