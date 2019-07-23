using DAO;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;
using System.Data.SqlClient;

namespace GestionArchive
{
    public partial class FrmClasse : Form
    {
        public FrmClasse()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            Classe classe = new Classe(0, nclasse.Text, nivclasse.Text);
            ClasseDAO classeDAO = new ClasseDAO();
            int rs = classeDAO.InsertClasse(classe);
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            var cDAO = new ClasseDAO();
            cDAO.DeleteClasse(int.Parse(Table.CurrentRow.Cells[0].Value.ToString()));
        }

        private void Update_Click(object sender, EventArgs e)
        {
            var cDAO = new ClasseDAO();
            var classe = cDAO.GetClasse(int.Parse(Table.CurrentRow.Cells[0].Value.ToString()));
            classe.NomClasse = nclasse.Text;
            classe.NiveauClasse = nivclasse.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Table.DataSource = null;
            var classes = new ClasseDAO().GetClasses();
            Table.DataSource = classes;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void nclasse_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void nivclasse_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmClasse_Load(object sender, EventArgs e)
        {
            ShowAll();
        }

        private void ShowAll()
        {
            Table.DataSource = null;
            var classes = new ClasseDAO().GetClasses();
            Table.DataSource = classes;
            //-----------------------------------------
            nclasse.DataSource = null;
            nclasse.ValueMember = "IdClasse";
            nclasse.DisplayMember = "NomClasse";
            nclasse.DataSource = classes;
            //-----------------------------------------
            nivclasse.DataSource = null;
            nivclasse.ValueMember = "IdClasse";
            nivclasse.DisplayMember = "NiveauClasse";
            nivclasse.DataSource = classes;
        }
    }
}
