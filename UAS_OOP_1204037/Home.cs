using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UAS_OOP_1204037
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void prodiToolStripMenuItem_Click(object sender, EventArgs e)
        {
           ProgramStudi newProdi = new ProgramStudi();
            newProdi.MdiParent = this;
            newProdi.Show();
        }

        private void MhsMenuItem_Click(object sender, EventArgs e)
        {
            BonusLevel newMahasiswa = new BonusLevel();
            newMahasiswa.MdiParent = this;
            newMahasiswa.Show();
        }

        private void daftarUlangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DaftarUlangMahasiswa newDaftarUlang = new DaftarUlangMahasiswa();
            newDaftarUlang.MdiParent = this;
            newDaftarUlang.Show();  
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void programStudiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewMahasiswa newProgramStudi = new ViewMahasiswa();
            newProgramStudi.MdiParent = this;
            newProgramStudi.Show(); 
        }
    }
}
