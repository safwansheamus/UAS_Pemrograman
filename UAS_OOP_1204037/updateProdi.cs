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
    public partial class updateProdi : Form
    {
        public updateProdi()
        {
            InitializeComponent();
        }
        private SqlConnection conn;
        private SqlCommand cmd1;
        private SqlDataAdapter DataAdapter;
        private DataSet DataSet;

        private void updateProdi_Load(object sender, EventArgs e)
        {
            string constr = @"Data Source=SAFWAN\SAFWANJIHYO; Initial Catalog = UAS; Integrated Security = True";
            conn = new SqlConnection(constr);
            conn.Open();
            cmd1 = new SqlCommand();
            cmd1.Connection = conn;
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "select * from ms_prodi";
            DataSet = new DataSet();
            DataAdapter = new SqlDataAdapter(cmd1);
            DataAdapter.Fill(DataSet, "ms_prodi");
            dgProdi.DataSource = DataSet;
            dgProdi.DataMember = "ms_prodi";
            dgProdi.Refresh();
            conn.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection myConnection = new SqlConnection(@"Data Source=ZIANASTI\ZIANASTI; Initial Catalog = UAS; Integrated Security = True");

            myConnection.Open();

            SqlDataAdapter myAdapter = new SqlDataAdapter("select * from ms_prodi", myConnection);
            SqlCommandBuilder myCmdBuilder = new SqlCommandBuilder(myAdapter);

            myAdapter.InsertCommand = myCmdBuilder.GetInsertCommand();
            myAdapter.UpdateCommand = myCmdBuilder.GetUpdateCommand();
            myAdapter.DeleteCommand = myCmdBuilder.GetDeleteCommand();

            SqlTransaction myTransaction;
            myTransaction = myConnection.BeginTransaction();
            myAdapter.DeleteCommand.Transaction = myTransaction;
            myAdapter.UpdateCommand.Transaction = myTransaction;
            myAdapter.InsertCommand.Transaction = myTransaction;

            try
            {
                int rowsUpdated = myAdapter.Update(DataSet, "ms_prodi");
                myTransaction.Commit();

                MessageBox.Show(rowsUpdated.ToString() + "Baris diperbarui", "Informasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);


                Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to update: " + ex.Message);

                myTransaction.Rollback();
            }
        }
    }
}
