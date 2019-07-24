using DAO;
using GoogleTranslateFreeApi;
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

namespace GestionArchive
{
    public partial class FrmEtudiant : Form
    {
        public FrmEtudiant()
        {
            InitializeComponent();
        }

        private void grbFrançais_Enter(object sender, EventArgs e)
        {

        }

        public void ClearAll()
        {
            Action<Control.ControlCollection> action = null;

            action = (controls) =>
            {
                foreach(Control item in controls)
                {
                    if ((item is TextBox) && (item.Name != "txtRdCNI") && (item.Name != "txtRdCNE") && (item.Name != "txtRdMassar")) 
                    {
                        item.Text = "";
                    }
                    else
                        action(item.Controls);
                }
            };
            action(Controls);
        }

        public bool IsEmpty()
        {
            Action<Control.ControlCollection> action = null;
            bool isEmpty = false;
            action = (controls) =>
            {
                foreach (Control item in controls)
                {
                    if ((item is TextBox) && (item.Name != "txtRdCNI") && (item.Name != "txtRdCNE") && (item.Name != "txtRdMassar"))
                    {
                        if(item.Text == "")
                        {
                            isEmpty = true;
                            break;
                        }
                    }
                    else
                        action(item.Controls);
                }
            };
            action(Controls);
            return isEmpty;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rdCNI_CheckedChanged(object sender, EventArgs e)
        {
            txtRdCNI.Enabled = true;
            txtRdCNE.Enabled = false;
            txtRdMassar.Enabled = false;
            //Focus
            txtRdCNI.Focus();
            txtRdCNI.SelectAll();

        }

        private void rdCNE_CheckedChanged(object sender, EventArgs e)
        {
            txtRdCNE.Enabled = true;
            txtRdMassar.Enabled = false;
            txtRdCNI.Enabled = false;
            //Focus
            txtRdCNE.Focus();
            txtRdCNE.SelectAll();
        }

        private void rdMassar_CheckedChanged(object sender, EventArgs e)
        {
            txtRdMassar.Enabled = true;
            txtRdCNE.Enabled = false;
            txtRdCNI.Enabled = false;
            //Focus
            txtRdMassar.Focus();
            txtRdMassar.SelectAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (IsEmpty())
            {
                MessageBox.Show("Il y a une zone de text vide!", "Attention !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Etudiant etudiant = new Etudiant(0, txtNom.Text, txtNomAr.Text, txtPrenom.Text, txtPrenomAr.Text, txtCNE.Text, txtCNI.Text, txtMassar.Text, dtNaissance.Value,
                dtInscription.Value, txtLieu.Text, txtLieuAr.Text, txtAddresse.Text, txtAddresseAr.Text, txtNumInscription.Text);
            EtudiantDAO etudiantDAO = new EtudiantDAO();
            try
            {
                int rs = etudiantDAO.InsertEtudiant(etudiant);
                if (rs != 1)
                {
                    MessageBox.Show("Il y a un problem de l'insertion ! Vérifier que vous êtes connecté.", "Attention !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Attention !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            MessageBox.Show("Insertion ajouter avec succée.");
            ClearAll();
            btnShow_Click(sender, e);
        }

        private void FrmEtudiant_Load(object sender, EventArgs e)
        {
            btnShow_Click(sender, e);
            FillData();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = null;
            var etudiants = new EtudiantDAO().GetEtudiants();
            dataGridView.DataSource = etudiants;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (rdCNI.Checked)
            {
                var etudiant = new EtudiantDAO().GetEtudiantByCNI(txtRdCNI.Text);
                dataGridView.DataSource = null;
                dataGridView.DataSource = etudiant;
            }
            else if (rdCNE.Checked)
            {
                var etudiant = new EtudiantDAO().GetEtudiantByCNE(txtRdCNE.Text);
                dataGridView.DataSource = null;
                dataGridView.DataSource = etudiant;
            }
            else
            {
                var etudiant = new EtudiantDAO().GetEtudiantByMassar(txtRdMassar.Text);
                dataGridView.DataSource = null;
                dataGridView.DataSource = etudiant;
            }
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            FillData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var eDAO = new EtudiantDAO();
            var etudiant = eDAO.GetEtudiant(int.Parse(dataGridView.CurrentRow.Cells[0].Value.ToString()));
            etudiant.NomEtudiant = txtNom.Text;
            etudiant.PrenomEtudiant = txtPrenom.Text;
            etudiant.NomEtudiantArabe = txtNomAr.Text;
            etudiant.PrenomEtudiantArabe = txtPrenomAr.Text;
            etudiant.Cne = txtCNE.Text;
            etudiant.Cni = txtCNI.Text;
            etudiant.Massar = txtMassar.Text;
            etudiant.DateDeNaissance = dtNaissance.Value;
            etudiant.DateInscription = dtInscription.Value;
            etudiant.LieuDeNaissance = txtLieu.Text;
            etudiant.LieuDeNaissanceArabe = txtLieuAr.Text;
            etudiant.Adresse = txtAddresse.Text;
            etudiant.AdresseArabe = txtAddresseAr.Text;
            etudiant.NumInsricption = txtNumInscription.Text;
            try
            {
                eDAO.UpdateEtudiant(etudiant);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("L'étudiant a été modifier avec succée.");
            ClearAll();
            btnShow_Click(sender, e);
        }

        private void FillData()
        {
            try
            {
                txtNom.Text = dataGridView.CurrentRow.Cells[1].Value == null ? "" : dataGridView.CurrentRow.Cells[1].Value.ToString();
                txtNomAr.Text = dataGridView.CurrentRow.Cells[2].Value == null ? "" : dataGridView.CurrentRow.Cells[2].Value.ToString();
                txtPrenom.Text = dataGridView.CurrentRow.Cells[3].Value == null ? "" : dataGridView.CurrentRow.Cells[3].Value.ToString();
                txtPrenomAr.Text = dataGridView.CurrentRow.Cells[4].Value == null ? "" : dataGridView.CurrentRow.Cells[4].Value.ToString();
                txtCNE.Text = dataGridView.CurrentRow.Cells[5].Value == null ? "" : dataGridView.CurrentRow.Cells[5].Value.ToString();
                txtCNI.Text = dataGridView.CurrentRow.Cells[6].Value == null ? "" : dataGridView.CurrentRow.Cells[6].Value.ToString();
                txtMassar.Text = dataGridView.CurrentRow.Cells[7].Value == null ? "" : dataGridView.CurrentRow.Cells[7].Value.ToString();
                dtNaissance.Value = Convert.ToDateTime(dataGridView.CurrentRow.Cells[8].Value.ToString());
                dtInscription.Value = Convert.ToDateTime(dataGridView.CurrentRow.Cells[9].Value.ToString());
                txtLieu.Text = dataGridView.CurrentRow.Cells[10].Value == null ? "" : dataGridView.CurrentRow.Cells[10].Value.ToString();
                txtLieuAr.Text = dataGridView.CurrentRow.Cells[11].Value == null ? "" : dataGridView.CurrentRow.Cells[11].Value.ToString();
                txtAddresse.Text = dataGridView.CurrentRow.Cells[12].Value == null ? "" : dataGridView.CurrentRow.Cells[12].Value.ToString();
                txtAddresseAr.Text = dataGridView.CurrentRow.Cells[13].Value == null ? "" : dataGridView.CurrentRow.Cells[13].Value.ToString();
                txtNumInscription.Text = dataGridView.CurrentRow.Cells[14].Value == null ? "" : dataGridView.CurrentRow.Cells[14].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                dataGridView.Enabled = false;
                dataGridView.GetNextControl(dataGridView, true).Focus();
                dataGridView.Enabled = true;
                e.Handled = true;
            }
            switch (e.KeyCode)
            {
                case Keys.Down: FillData(); break;
                case Keys.Up: FillData(); break;
                default: return;
            }
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            FillData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var eDAO = new EtudiantDAO();
                eDAO.DeleteEtudiant(int.Parse(dataGridView.CurrentRow.Cells[0].Value.ToString()));
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Cet étudiant a des notes ou association en annee scolaire s'il vous plaît supprimer toutes les notes ou/et les annee scolaires puis supprimez l'étudiant \n" + ex.Message, "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("L'étudiant a été supptimer avec succée.");
            ClearAll();
            btnShow_Click(sender, e);
            dataGridView_SelectionChanged(sender, e);
        }

        private async void txtNom_LeaveAsync(object sender, EventArgs e)
        {
            if(txtNomAr.Text == "")
                await Translate(txtNom, txtNomAr);
        }

        private async Task Translate(TextBox txtSource, TextBox txtDest)
        {
            var translator = new GoogleTranslator();

            Language from = Language.Auto;
            Language to = GoogleTranslator.GetLanguageByISO("ar");

            TranslationResult result = await translator.TranslateLiteAsync(txtSource.Text, from, to);

            //You can get all text using MergedTranslation property
            string resultMerged = result.MergedTranslation;

            txtDest.Text = resultMerged;
        }

        private async void txtPrenom_LeaveAsync(object sender, EventArgs e)
        {
            if (txtPrenomAr.Text == "")
                await Translate(txtPrenom, txtPrenomAr);
        }

        private async void txtAddresse_LeaveAsync(object sender, EventArgs e)
        {
            if (txtAddresseAr.Text == "")
                await Translate(txtAddresse, txtAddresseAr);
        }

        private async void txtLieu_LeaveAsync(object sender, EventArgs e)
        {
            if (txtLieuAr.Text == "")
                await Translate(txtLieu, txtLieuAr);
        }

        private void txtNom_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrenom_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmEtudiant_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainFrm f1 = new MainFrm();
            f1.Show();
        }
    }
}
