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

        private void prodiToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            viewProdi tampilprodi = new viewProdi();
            tampilprodi.MdiParent = this;
            tampilprodi.Show();
        }

        private void daftarUlangToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            viewDaftarUlang VDU = new viewDaftarUlang();
            VDU.MdiParent = this;
            VDU.Show();
        }

        private void daftarUlangToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            DaftarUlangMahasiswa DU = new DaftarUlangMahasiswa();
            DU.MdiParent = this;
            DU.Show();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void mahasiswaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            updateMahasiswa UM = new updateMahasiswa();
            UM.MdiParent = this;
            UM.Show();
        }

        private void prodiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            updateProdi UP = new updateProdi();
            UP.MdiParent = this;
            UP.Show();
        }

        private void daftarUlangToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            updateDU UDU = new updateDU();
            UDU.MdiParent = this;
            UDU.Show();
        }
    }
}
