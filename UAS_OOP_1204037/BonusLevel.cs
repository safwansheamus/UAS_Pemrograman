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
    public partial class BonusLevel : Form
    {
        public BonusLevel()
        {
            InitializeComponent();
            SqlConnection myConnection = new SqlConnection(@"Data Source=SAFWAN\SAFWANJIHYO; Initial Catalog = UAS; Integrated Security = True");

            myConnection.Open();

            SqlCommand myCommand = new SqlCommand("SELECT * FROM ms_prodi", myConnection);
            SqlDataReader reader;

            reader = myCommand.ExecuteReader();
            DataTable myDataTable = new DataTable();
            myDataTable.Columns.Add("kode_prodi", typeof(string));
            myDataTable.Columns.Add("singkatan", typeof(string));
            myDataTable.Load(reader);

            //txtProgramStudi.ValueMember = "kode_prodi";
            //txtProgramStudi.DisplayMember = "singkatan";
            //txtProgramStudi.DataSource = myDataTable;

            myConnection.Close();

        }

        //membuat method updateDB dengan parameter cmd
        private void UpdateDB(string cmd)
        {
            try
            {
                SqlConnection myConnection = new SqlConnection(@"Data Source=SAFWAN\SAFWANJIHYO; Initial Catalog = UAS; Integrated Security = True");
                myConnection.Open();
                SqlCommand myCommand = new SqlCommand();
                myCommand.Connection = myConnection;
                myCommand.CommandText = cmd;
                myCommand.ExecuteNonQuery();


                MessageBox.Show("Data Berhasil Tersubmit !", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void clear()
        {
            //mengosongkan isian dalam textbox
            txtNpm.Text = "";
            txtNamaMhs.Text = "";
            txtProgramStudi.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();    
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtNpm.Text != "")
            {
                if (txtNamaMhs.Text != "")
                {
                    if (txtProgramStudi.Text != "")
                    {
                        string npm = txtNpm.Text;
                        string nama = txtNamaMhs.Text;
                        string prodi = this.txtProgramStudi.Text;

                        SqlConnection myConnection = new SqlConnection(@"Data Source=SAFWAN\SAFWANJIHYO; Initial Catalog = UAS; Integrated Security = True");
                        string sql = "INSERT INTO ms_mhs ([npm],[nama_mhs]," + "[kode_prodi]) VALUES (@npm,@namaMhs,@kodeProdi)";

                        using (SqlConnection Connection = new SqlConnection(@"Data Source = SAFWAN\SAFWANJIHYO; Initial Catalog = UAS; Integrated Security=True"))
                        {
                            try
                            {
                                Connection.Open();

                                using (SqlCommand command = new SqlCommand(sql, Connection))
                                {
                                    command.Parameters.Add("@npm", SqlDbType.VarChar).Value = npm;
                                    command.Parameters.Add("@namaMhs", SqlDbType.VarChar).Value = nama;
                                    command.Parameters.Add("@kodeProdi", SqlDbType.VarChar).Value = prodi;

                                    int rowsAdded = command.ExecuteNonQuery();
                                    if (rowsAdded > 0)
                                        MessageBox.Show("Data berhasil di simpan");
                                    else
                                        MessageBox.Show("Data tidak tersimpan");

                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("ERROR:" + ex.Message);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nama harus diisi !", "Infromasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Nama harus diisi !", "Infromasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            else
            {
                MessageBox.Show("NPM harus diisi !", "Infromasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BonusLevel_Load(object sender, EventArgs e)
        {

        }
    }
}
