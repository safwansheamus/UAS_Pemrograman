namespace UAS_OOP_1204037
{
    partial class viewDaftarUlang
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
            this.dgDU = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgDU)).BeginInit();
            this.SuspendLayout();
            // 
            // dgDU
            // 
            this.dgDU.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDU.Location = new System.Drawing.Point(45, 40);
            this.dgDU.Name = "dgDU";
            this.dgDU.RowHeadersWidth = 51;
            this.dgDU.RowTemplate.Height = 24;
            this.dgDU.Size = new System.Drawing.Size(462, 313);
            this.dgDU.TabIndex = 0;
            // 
            // viewDaftarUlang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 450);
            this.Controls.Add(this.dgDU);
            this.Name = "viewDaftarUlang";
            this.Text = "viewDaftarUlang";
            this.Load += new System.EventHandler(this.viewDaftarUlang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgDU)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgDU;
    }
}