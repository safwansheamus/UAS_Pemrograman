﻿using System;
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
    public partial class DaftarUlangMahasiswa : Form
    {
        public DaftarUlangMahasiswa()
        {
            InitializeComponent();
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

                MessageBox.Show("Data Berhasil Disubmit !", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtNpm.Text != "")
            {
                if (rbA.Checked != false || rbB.Checked != false || rbC.Checked != false)
                {
                    string grade = "";
                    if (rbA.Checked)
                    {
                        grade = "A";
                    }
                    if (rbB.Checked)
                    {
                        grade = "B";
                    }
                    if (rbC.Checked)
                    {
                        grade = "C";
                    }

                    string cmd = "INSERT INTO tr_daftar_ulang VALUES ('"
                       + txtNpm.Text + "','"
                       + grade + "','"
                       + txtTotalBiaya.Text + "')";

                    UpdateDB(cmd);
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Grade Seleksi harus dipilih !", "Infromasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("NPM harus diisi !", "Infromasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void txtNpm_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void txtTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }


        private void clear()
        {
            txtNpm.Text = "";
            txtNamaMahasiswa.Text = "";
            txtProdi.Text = "";
            txtBiaya.Text = "";
            rbA.Checked = false;
            rbB.Checked = false;
            rbC.Checked = false;
            txtPotonganBiaya.Text = "";
           txtTotalBiaya.Text = "";

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void DaftarUlangMahasiswa_Load(object sender, EventArgs e)
        {

        }

        private void rbGradeA_CheckedChanged(object sender, EventArgs e)
        {
            int diskon = (Int32.Parse(txtBiaya.Text.ToString()) * 50) / 100;
            txtPotonganBiaya.Text = diskon.ToString();
            int totalbiaya = Int32.Parse(txtBiaya.Text.ToString()) - diskon;
            txtBiaya.Text = totalbiaya.ToString();
        }

        private void txtTotalBiaya_TextChanged(object sender, EventArgs e)
        {

        }

        private void rbGradeB_CheckedChanged(object sender, EventArgs e)
        {
            int diskon = (Int32.Parse(txtBiaya.Text.ToString()) * 25) / 100;
            txtPotonganBiaya.Text = diskon.ToString();
            int totalbiaya = Int32.Parse(txtBiaya.Text.ToString()) - diskon;
            txtBiaya.Text = totalbiaya.ToString();
        }

        private void rbGradeC_CheckedChanged(object sender, EventArgs e)
        {
            int diskon = (Int32.Parse(txtBiaya.Text.ToString()) * 10) / 100;
            txtPotonganBiaya.Text = diskon.ToString();
            int totalbiaya = Int32.Parse(txtBiaya.Text.ToString()) - diskon;
            txtBiaya.Text = totalbiaya.ToString();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string getSql = "SELECT nama_mhs,nama_prodi,biaya_kuliah FROM ms_mhs " +
               "JOIN ms_prodi ON ms_mhs.kode_prodi=ms_prodi.kode_prodi WHERE npm='" + txtNpm.Text + "'";

            string connection = @"Data Source=SAFWAN\SAFWANJIHYO; Initial Catalog = UAS; Integrated Security = True";
            SqlConnection myConnection = new SqlConnection(connection);
            myConnection.Open();
            SqlCommand sc = new SqlCommand(getSql, myConnection);
            SqlDataReader Result;

            Result = sc.ExecuteReader();
            if (Result.HasRows)
            {
                while (Result.Read())
                {
                    txtNamaMahasiswa.Text = Result["nama_mhs"].ToString();
                    txtProdi.Text = Result["nama_prodi"].ToString();
                    txtBiaya.Text = Result["biaya_kuliah"].ToString();
                }
            }
        }
    }
}
