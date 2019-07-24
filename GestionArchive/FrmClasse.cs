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
            nivclasse.Text = null;
            nclasse.Text = null;
            ShowAll();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            var cDAO = new ClasseDAO();
            cDAO.DeleteClasse(int.Parse(Table.CurrentRow.Cells[0].Value.ToString()));
            nivclasse.Text = null;
            nclasse.Text = null;
            ShowAll();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            var cDAO = new ClasseDAO();
            var classe = cDAO.GetClasse(int.Parse(Table.CurrentRow.Cells[0].Value.ToString()));
            classe.NomClasse = nclasse.Text;
            classe.NiveauClasse = nivclasse.Text;
            nivclasse.Text = null;
            nclasse.Text = null;
            ShowAll();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Table.DataSource = null;
            var classes = new ClasseDAO().GetClasses();
            Table.DataSource = classes;
            com();
            nivclasse.Text = null;
            nclasse.Text = null;
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
            nivclasse.Text = null;
            nclasse.Text = null;
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
            nivclasse.Text = null;
            nclasse.Text = null;
        }
        private void com()
        {
            if(nclasse.Text == "")// oub bien string.IsNullOrEmpty(nclasse.Text)
            {
                return;
            }
            string query = "Select * From Classe WHERE NomClasse = '" + nclasse.Text + "'";
            /*string query2 = "Select * From Classe WHERE NomClasse = @NiveauClasse";*/
            var con = Singleton.GetInstance().GetConnection();
            con.Open();
            SqlCommand command = new SqlCommand(query, con);
            /*command.Parameters.AddWithValue("@NomClasse", nclasse.Text);*/
            SqlDataReader reader = command.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            Table.DataSource = table;
            reader.Close();
            con.Close();
        }

        private void FrmClasse_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainFrm f1 = new MainFrm();
            f1.Show();
        }
    }
}
