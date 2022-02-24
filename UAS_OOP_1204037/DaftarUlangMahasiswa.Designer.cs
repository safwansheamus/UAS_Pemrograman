namespace UAS_OOP_1204037
{
    partial class DaftarUlangMahasiswa
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rbGradeA = new System.Windows.Forms.RadioButton();
            this.rbGradeB = new System.Windows.Forms.RadioButton();
            this.rbGradeC = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtNpm = new System.Windows.Forms.TextBox();
            this.txtTotalBiaya = new System.Windows.Forms.TextBox();
            this.txtNamaMahasiswa = new System.Windows.Forms.TextBox();
            this.txtProdi = new System.Windows.Forms.TextBox();
            this.txtBiaya = new System.Windows.Forms.TextBox();
            this.txtPotonganBiaya = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(184, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input Daftar Ulang Mahasiswa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "NPM   :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nama Mahasiswa   :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(57, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Program Studi  :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(57, 299);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Grade Seleksi      : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(57, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Biaya Kuliah    :";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // rbGradeA
            // 
            this.rbGradeA.AutoSize = true;
            this.rbGradeA.Location = new System.Drawing.Point(233, 299);
            this.rbGradeA.Name = "rbGradeA";
            this.rbGradeA.Size = new System.Drawing.Size(37, 20);
            this.rbGradeA.TabIndex = 6;
            this.rbGradeA.TabStop = true;
            this.rbGradeA.Text = "A";
            this.rbGradeA.UseVisualStyleBackColor = true;
            // 
            // rbGradeB
            // 
            this.rbGradeB.AutoSize = true;
            this.rbGradeB.Location = new System.Drawing.Point(233, 342);
            this.rbGradeB.Name = "rbGradeB";
            this.rbGradeB.Size = new System.Drawing.Size(37, 20);
            this.rbGradeB.TabIndex = 7;
            this.rbGradeB.TabStop = true;
            this.rbGradeB.Text = "B";
            this.rbGradeB.UseVisualStyleBackColor = true;
            // 
            // rbGradeC
            // 
            this.rbGradeC.AutoSize = true;
            this.rbGradeC.Location = new System.Drawing.Point(233, 381);
            this.rbGradeC.Name = "rbGradeC";
            this.rbGradeC.Size = new System.Drawing.Size(37, 20);
            this.rbGradeC.TabIndex = 8;
            this.rbGradeC.TabStop = true;
            this.rbGradeC.Text = "C";
            this.rbGradeC.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(57, 433);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(166, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Potongan Biaya      : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(57, 484);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(179, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "Total Biaya Kuliah     : ";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(172, 558);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(98, 39);
            this.btnSubmit.TabIndex = 11;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(386, 558);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(98, 39);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtNpm
            // 
            this.txtNpm.Location = new System.Drawing.Point(233, 104);
            this.txtNpm.Name = "txtNpm";
            this.txtNpm.Size = new System.Drawing.Size(275, 22);
            this.txtNpm.TabIndex = 13;
            // 
            // txtTotalBiaya
            // 
            this.txtTotalBiaya.Location = new System.Drawing.Point(233, 484);
            this.txtTotalBiaya.Name = "txtTotalBiaya";
            this.txtTotalBiaya.Size = new System.Drawing.Size(275, 22);
            this.txtTotalBiaya.TabIndex = 14;
            // 
            // txtNamaMahasiswa
            // 
            this.txtNamaMahasiswa.Location = new System.Drawing.Point(233, 155);
            this.txtNamaMahasiswa.Name = "txtNamaMahasiswa";
            this.txtNamaMahasiswa.Size = new System.Drawing.Size(275, 22);
            this.txtNamaMahasiswa.TabIndex = 15;
            // 
            // txtProdi
            // 
            this.txtProdi.Location = new System.Drawing.Point(233, 203);
            this.txtProdi.Name = "txtProdi";
            this.txtProdi.Size = new System.Drawing.Size(275, 22);
            this.txtProdi.TabIndex = 16;
            // 
            // txtBiaya
            // 
            this.txtBiaya.Location = new System.Drawing.Point(233, 252);
            this.txtBiaya.Name = "txtBiaya";
            this.txtBiaya.Size = new System.Drawing.Size(275, 22);
            this.txtBiaya.TabIndex = 17;
            // 
            // txtPotonganBiaya
            // 
            this.txtPotonganBiaya.Location = new System.Drawing.Point(233, 433);
            this.txtPotonganBiaya.Name = "txtPotonganBiaya";
            this.txtPotonganBiaya.Size = new System.Drawing.Size(275, 22);
            this.txtPotonganBiaya.TabIndex = 18;
            // 
            // DaftarUlangMahasiswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 649);
            this.Controls.Add(this.txtPotonganBiaya);
            this.Controls.Add(this.txtBiaya);
            this.Controls.Add(this.txtProdi);
            this.Controls.Add(this.txtNamaMahasiswa);
            this.Controls.Add(this.txtTotalBiaya);
            this.Controls.Add(this.txtNpm);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rbGradeC);
            this.Controls.Add(this.rbGradeB);
            this.Controls.Add(this.rbGradeA);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DaftarUlangMahasiswa";
            this.Text = "DaftarUlangMahasiswa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rbGradeA;
        private System.Windows.Forms.RadioButton rbGradeB;
        private System.Windows.Forms.RadioButton rbGradeC;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtNpm;
        private System.Windows.Forms.TextBox txtTotalBiaya;
        private System.Windows.Forms.TextBox txtNamaMahasiswa;
        private System.Windows.Forms.TextBox txtProdi;
        private System.Windows.Forms.TextBox txtBiaya;
        private System.Windows.Forms.TextBox txtPotonganBiaya;
    }
}