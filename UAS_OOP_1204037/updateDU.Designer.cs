namespace UAS_OOP_1204037
{
    partial class updateDU
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
            this.dgDaftarU = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgDaftarU)).BeginInit();
            this.SuspendLayout();
            // 
            // dgDaftarU
            // 
            this.dgDaftarU.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDaftarU.Location = new System.Drawing.Point(33, 27);
            this.dgDaftarU.Name = "dgDaftarU";
            this.dgDaftarU.RowHeadersWidth = 51;
            this.dgDaftarU.RowTemplate.Height = 24;
            this.dgDaftarU.Size = new System.Drawing.Size(528, 274);
            this.dgDaftarU.TabIndex = 0;
            this.dgDaftarU.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(244, 348);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(84, 36);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // updateDU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 450);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dgDaftarU);
            this.Name = "updateDU";
            this.Text = "updateDU";
            this.Load += new System.EventHandler(this.updateDU_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgDaftarU)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgDaftarU;
        private System.Windows.Forms.Button btnUpdate;
    }
}