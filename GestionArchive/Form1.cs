using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;
using DAO;
using Models;

namespace GestionArchive
{
    public partial class Form1 : Form
    {
        /**
         * SELECT C.IdClasse, (C.NomClasse + ' ' + a.Annee) FROM AnneeScolaire a
INNER JOIN Etudiant e on a.IdEtudiant = e.IdEtudiant
INNER JOIN Classe c on c.IdClasse = a.IdClasse WHERE e.IdEtudiant = 2
         * */

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                double result = 0.0;
                if (txtNote.Text == "")
                    return;

                bool isDouble = double.TryParse(txtNote.Text, out result);

                if (!isDouble)
                    return;

                var semestre = "";
                if (rdSemestreOne.Checked)
                    semestre = "1ere Semestre";
                else
                    semestre = "2eme Semestre";
                var note = new Note(0, cbMatiere.Text, double.Parse(txtNote.Text), 5, semestre);
                var classe = new ClasseDAO().GetClasse(int.Parse(cbClasse.SelectedValue.ToString()));
                var etudiant = new EtudiantDAO().GetEtudiant(int.Parse(cbEtudiant.Text));
                note.Classe = classe;
                note.Etudiant = etudiant;
                var nDAO = new NoteDAO();
                nDAO.InsertNote(note);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            MessageBox.Show(this, "Insertion avec succée", "Succée", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cbMatiere.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbEtudiant.DataSource = null;
            var Etudiants = new EtudiantDAO().GetEtudiants();
            cbEtudiant.ValueMember = "FullName";
            cbEtudiant.DisplayMember = "IdEtudiant";
            cbEtudiant.DataSource = Etudiants;
        }

        private async void cbEtudiant_SelectedIndexChangedAsync(object sender, EventArgs e)
        {
            try
            {
                await LoadCbAnnee();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbClasse_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async Task LoadCbAnnee()
        {
            var con = Singleton.GetInstance().GetConnection();
            try
            {
                cbClasse.DataSource = null;
                con.Open();
                var IdEtudiant = int.Parse(cbEtudiant.Text);
                string query = "SELECT C.IdClasse, (C.NomClasse + ' ' + a.Annee) As Name FROM AnneeScolaire a INNER JOIN Etudiant e on a.IdEtudiant = e.IdEtudiant INNER JOIN Classe c on c.IdClasse = a.IdClasse WHERE e.IdEtudiant = @IdEtudiant";
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@IdEtudiant", IdEtudiant);
                SqlDataReader reader = await command.ExecuteReaderAsync();
                DataTable table = new DataTable();
                table.Load(reader);
                reader.Close();
                con.Close();
                cbClasse.ValueMember = "IdClasse";
                cbClasse.DisplayMember = "Name";
                cbClasse.DataSource = table;
                var etudiant = new EtudiantDAO().GetEtudiant(IdEtudiant);
                LbNom.Text = $"Nom : {etudiant.NomEtudiant} \t  الإسم العائلي : {etudiant.NomEtudiantArabe} ";
                LbPrenom.Text = $"Prenom : {etudiant.PrenomEtudiant} \t  الإسم الشخصي : {etudiant.PrenomEtudiantArabe}";
                LbCne.Text = $"CNE : {etudiant.Cne}";
                LbMassar.Text = $"Massar : {etudiant.Massar}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainFrm f1 = new MainFrm();
            f1.Show();
        }
    }
}
