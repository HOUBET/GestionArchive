namespace GestionArchive
{
    partial class FrmClasse
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
            this.Add = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Table = new System.Windows.Forms.DataGridView();
            this.btnshow = new System.Windows.Forms.Button();
            this.nivclasse = new System.Windows.Forms.ComboBox();
            this.nclasse = new System.Windows.Forms.ComboBox();
            this.Modifier = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Table)).BeginInit();
            this.SuspendLayout();
            // 
            // Add
            // 
            this.Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Add.Location = new System.Drawing.Point(391, 24);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(81, 21);
            this.Add.TabIndex = 0;
            this.Add.Text = "Ajouter";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Delete
            // 
            this.Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Delete.Location = new System.Drawing.Point(505, 24);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(81, 21);
            this.Delete.TabIndex = 2;
            this.Delete.Text = "Supprimer";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nom de Classe :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Niveau de Classe :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Modifier);
            this.groupBox1.Controls.Add(this.Table);
            this.groupBox1.Controls.Add(this.btnshow);
            this.groupBox1.Controls.Add(this.nivclasse);
            this.groupBox1.Controls.Add(this.nclasse);
            this.groupBox1.Controls.Add(this.Delete);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Add);
            this.groupBox1.Location = new System.Drawing.Point(25, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(619, 383);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Classe";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Table
            // 
            this.Table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Table.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Table.Location = new System.Drawing.Point(8, 118);
            this.Table.Name = "Table";
            this.Table.Size = new System.Drawing.Size(603, 259);
            this.Table.TabIndex = 11;
            this.Table.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnshow
            // 
            this.btnshow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnshow.Location = new System.Drawing.Point(391, 59);
            this.btnshow.Name = "btnshow";
            this.btnshow.Size = new System.Drawing.Size(81, 21);
            this.btnshow.TabIndex = 10;
            this.btnshow.Text = "Rechercher";
            this.btnshow.UseVisualStyleBackColor = true;
            this.btnshow.Click += new System.EventHandler(this.button1_Click);
            // 
            // nivclasse
            // 
            this.nivclasse.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.nivclasse.FormattingEnabled = true;
            this.nivclasse.Location = new System.Drawing.Point(107, 64);
            this.nivclasse.Name = "nivclasse";
            this.nivclasse.Size = new System.Drawing.Size(201, 21);
            this.nivclasse.TabIndex = 9;
            this.nivclasse.SelectedIndexChanged += new System.EventHandler(this.nivclasse_SelectedIndexChanged);
            // 
            // nclasse
            // 
            this.nclasse.FormattingEnabled = true;
            this.nclasse.Location = new System.Drawing.Point(107, 24);
            this.nclasse.Name = "nclasse";
            this.nclasse.Size = new System.Drawing.Size(201, 21);
            this.nclasse.TabIndex = 8;
            this.nclasse.SelectedIndexChanged += new System.EventHandler(this.nclasse_SelectedIndexChanged);
            // 
            // Modifier
            // 
            this.Modifier.Location = new System.Drawing.Point(505, 59);
            this.Modifier.Name = "Modifier";
            this.Modifier.Size = new System.Drawing.Size(81, 21);
            this.Modifier.TabIndex = 12;
            this.Modifier.Text = "Modifier";
            this.Modifier.UseVisualStyleBackColor = true;
            this.Modifier.Click += new System.EventHandler(this.Modifier_Click);
            // 
            // FrmClasse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(702, 438);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmClasse";
            this.Opacity = 0.97D;
            this.Text = "FrmClasse";
            this.TransparencyKey = System.Drawing.SystemColors.ActiveBorder;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmClasse_FormClosing);
            this.Load += new System.EventHandler(this.FrmClasse_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Table)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView Table;
        private System.Windows.Forms.Button btnshow;
        private System.Windows.Forms.ComboBox nivclasse;
        private System.Windows.Forms.ComboBox nclasse;
        private System.Windows.Forms.Button Modifier;
    }
}