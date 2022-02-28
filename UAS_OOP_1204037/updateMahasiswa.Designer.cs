namespace UAS_OOP_1204037
{
    partial class updateMahasiswa
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
            this.dgUpdateMahasiswa = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgUpdateMahasiswa)).BeginInit();
            this.SuspendLayout();
            // 
            // dgUpdateMahasiswa
            // 
            this.dgUpdateMahasiswa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUpdateMahasiswa.Location = new System.Drawing.Point(30, 24);
            this.dgUpdateMahasiswa.Name = "dgUpdateMahasiswa";
            this.dgUpdateMahasiswa.RowHeadersWidth = 51;
            this.dgUpdateMahasiswa.RowTemplate.Height = 24;
            this.dgUpdateMahasiswa.Size = new System.Drawing.Size(441, 295);
            this.dgUpdateMahasiswa.TabIndex = 0;
            this.dgUpdateMahasiswa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(212, 356);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(80, 35);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // updateMahasiswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 450);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dgUpdateMahasiswa);
            this.Name = "updateMahasiswa";
            this.Text = "updateMahasiswa1";
            this.Load += new System.EventHandler(this.updateMahasiswa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgUpdateMahasiswa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgUpdateMahasiswa;
        private System.Windows.Forms.Button btnUpdate;
    }
}