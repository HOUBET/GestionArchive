using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionArchive
{
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
        }

        private void Etudient_Click(object sender, EventArgs e)
        {
            FrmEtudiant f1 = new FrmEtudiant();
            f1.Show();
            this.Hide();
        }

        private void Classe_Click(object sender, EventArgs e)
        {
            FrmClasse f1 = new FrmClasse();
            f1.Show();
            this.Dispose();
        }

        private void Note_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Dispose();
        }

        private void MainFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
