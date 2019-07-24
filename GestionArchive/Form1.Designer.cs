namespace GestionArchive
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rdSemestreTwo = new System.Windows.Forms.RadioButton();
            this.rdSemestreOne = new System.Windows.Forms.RadioButton();
            this.cbMatiere = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbClasse = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.LbMassar = new System.Windows.Forms.Label();
            this.LbCne = new System.Windows.Forms.Label();
            this.LbPrenom = new System.Windows.Forms.Label();
            this.LbNom = new System.Windows.Forms.Label();
            this.cbEtudiant = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.18649F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.81351F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1264, 681);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox5, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox2, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox4, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnAdd, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnEdit, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnDelete, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnShow, 3, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1258, 219);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.rdSemestreTwo);
            this.groupBox5.Controls.Add(this.rdSemestreOne);
            this.groupBox5.Controls.Add(this.cbMatiere);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(631, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(308, 176);
            this.groupBox5.TabIndex = 12;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Nom Matiere";
            // 
            // rdSemestreTwo
            // 
            this.rdSemestreTwo.AutoSize = true;
            this.rdSemestreTwo.Dock = System.Windows.Forms.DockStyle.Top;
            this.rdSemestreTwo.Location = new System.Drawing.Point(3, 64);
            this.rdSemestreTwo.Name = "rdSemestreTwo";
            this.rdSemestreTwo.Padding = new System.Windows.Forms.Padding(5);
            this.rdSemestreTwo.Size = new System.Drawing.Size(302, 27);
            this.rdSemestreTwo.TabIndex = 2;
            this.rdSemestreTwo.Text = "2eme Semstre";
            this.rdSemestreTwo.UseVisualStyleBackColor = true;
            // 
            // rdSemestreOne
            // 
            this.rdSemestreOne.AutoSize = true;
            this.rdSemestreOne.Checked = true;
            this.rdSemestreOne.Dock = System.Windows.Forms.DockStyle.Top;
            this.rdSemestreOne.Location = new System.Drawing.Point(3, 37);
            this.rdSemestreOne.Name = "rdSemestreOne";
            this.rdSemestreOne.Padding = new System.Windows.Forms.Padding(5);
            this.rdSemestreOne.Size = new System.Drawing.Size(302, 27);
            this.rdSemestreOne.TabIndex = 1;
            this.rdSemestreOne.TabStop = true;
            this.rdSemestreOne.Text = "1ere Semestre";
            this.rdSemestreOne.UseVisualStyleBackColor = true;
            // 
            // cbMatiere
            // 
            this.cbMatiere.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbMatiere.FormattingEnabled = true;
            this.cbMatiere.Location = new System.Drawing.Point(3, 16);
            this.cbMatiere.Name = "cbMatiere";
            this.cbMatiere.Size = new System.Drawing.Size(302, 21);
            this.cbMatiere.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtNote);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(945, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(310, 176);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Note Matiere";
            // 
            // txtNote
            // 
            this.txtNote.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtNote.Location = new System.Drawing.Point(3, 16);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(304, 20);
            this.txtNote.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbClasse);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(317, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(308, 176);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Classe";
            // 
            // cbClasse
            // 
            this.cbClasse.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbClasse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClasse.FormattingEnabled = true;
            this.cbClasse.Location = new System.Drawing.Point(3, 16);
            this.cbClasse.Name = "cbClasse";
            this.cbClasse.Size = new System.Drawing.Size(302, 21);
            this.cbClasse.TabIndex = 0;
            this.cbClasse.SelectedIndexChanged += new System.EventHandler(this.cbClasse_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.LbMassar);
            this.groupBox3.Controls.Add(this.LbCne);
            this.groupBox3.Controls.Add(this.LbPrenom);
            this.groupBox3.Controls.Add(this.LbNom);
            this.groupBox3.Controls.Add(this.cbEtudiant);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(308, 176);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Etudiant";
            // 
            // LbMassar
            // 
            this.LbMassar.AutoSize = true;
            this.LbMassar.Dock = System.Windows.Forms.DockStyle.Top;
            this.LbMassar.Location = new System.Drawing.Point(3, 106);
            this.LbMassar.Name = "LbMassar";
            this.LbMassar.Padding = new System.Windows.Forms.Padding(5);
            this.LbMassar.Size = new System.Drawing.Size(57, 23);
            this.LbMassar.TabIndex = 2;
            this.LbMassar.Text = "Massar :";
            // 
            // LbCne
            // 
            this.LbCne.AutoSize = true;
            this.LbCne.Dock = System.Windows.Forms.DockStyle.Top;
            this.LbCne.Location = new System.Drawing.Point(3, 83);
            this.LbCne.Name = "LbCne";
            this.LbCne.Padding = new System.Windows.Forms.Padding(5);
            this.LbCne.Size = new System.Drawing.Size(42, 23);
            this.LbCne.TabIndex = 2;
            this.LbCne.Text = "Cne :";
            // 
            // LbPrenom
            // 
            this.LbPrenom.AutoSize = true;
            this.LbPrenom.Dock = System.Windows.Forms.DockStyle.Top;
            this.LbPrenom.Location = new System.Drawing.Point(3, 60);
            this.LbPrenom.Name = "LbPrenom";
            this.LbPrenom.Padding = new System.Windows.Forms.Padding(5);
            this.LbPrenom.Size = new System.Drawing.Size(59, 23);
            this.LbPrenom.TabIndex = 2;
            this.LbPrenom.Text = "Prenom :";
            // 
            // LbNom
            // 
            this.LbNom.AutoSize = true;
            this.LbNom.Dock = System.Windows.Forms.DockStyle.Top;
            this.LbNom.Location = new System.Drawing.Point(3, 37);
            this.LbNom.Name = "LbNom";
            this.LbNom.Padding = new System.Windows.Forms.Padding(5);
            this.LbNom.Size = new System.Drawing.Size(45, 23);
            this.LbNom.TabIndex = 2;
            this.LbNom.Text = "Nom :";
            // 
            // cbEtudiant
            // 
            this.cbEtudiant.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbEtudiant.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbEtudiant.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbEtudiant.FormattingEnabled = true;
            this.cbEtudiant.Location = new System.Drawing.Point(3, 16);
            this.cbEtudiant.Name = "cbEtudiant";
            this.cbEtudiant.Size = new System.Drawing.Size(302, 21);
            this.cbEtudiant.TabIndex = 0;
            this.cbEtudiant.SelectedIndexChanged += new System.EventHandler(this.cbEtudiant_SelectedIndexChangedAsync);
            // 
            // btnAdd
            // 
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdd.Location = new System.Drawing.Point(3, 185);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(308, 31);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Ajouter";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEdit.Location = new System.Drawing.Point(317, 185);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(308, 31);
            this.btnEdit.TabIndex = 14;
            this.btnEdit.Text = "Modifier";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDelete.Location = new System.Drawing.Point(631, 185);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(308, 31);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Supprimer";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnShow
            // 
            this.btnShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnShow.Location = new System.Drawing.Point(945, 185);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(310, 31);
            this.btnShow.TabIndex = 16;
            this.btnShow.Text = "Afficher les notes d\'étudiant";
            this.btnShow.UseVisualStyleBackColor = true;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(3, 228);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(1258, 450);
            this.dataGridView.TabIndex = 2;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "FrmNote";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox cbMatiere;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cbClasse;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbEtudiant;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label LbMassar;
        private System.Windows.Forms.Label LbCne;
        private System.Windows.Forms.Label LbPrenom;
        private System.Windows.Forms.Label LbNom;
        private System.Windows.Forms.RadioButton rdSemestreTwo;
        private System.Windows.Forms.RadioButton rdSemestreOne;
    }
}

