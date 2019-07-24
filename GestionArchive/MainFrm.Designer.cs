namespace GestionArchive
{
    partial class MainFrm
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
            this.Etudient = new System.Windows.Forms.Button();
            this.Classe = new System.Windows.Forms.Button();
            this.Note = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Etudient
            // 
            this.Etudient.Location = new System.Drawing.Point(58, 12);
            this.Etudient.Name = "Etudient";
            this.Etudient.Size = new System.Drawing.Size(75, 23);
            this.Etudient.TabIndex = 0;
            this.Etudient.Text = "Etudient";
            this.Etudient.UseVisualStyleBackColor = true;
            this.Etudient.Click += new System.EventHandler(this.Etudient_Click);
            // 
            // Classe
            // 
            this.Classe.Location = new System.Drawing.Point(58, 50);
            this.Classe.Name = "Classe";
            this.Classe.Size = new System.Drawing.Size(75, 23);
            this.Classe.TabIndex = 1;
            this.Classe.Text = "Classe";
            this.Classe.UseVisualStyleBackColor = true;
            this.Classe.Click += new System.EventHandler(this.Classe_Click);
            // 
            // Note
            // 
            this.Note.Location = new System.Drawing.Point(58, 88);
            this.Note.Name = "Note";
            this.Note.Size = new System.Drawing.Size(75, 23);
            this.Note.TabIndex = 2;
            this.Note.Text = "Note";
            this.Note.UseVisualStyleBackColor = true;
            this.Note.Click += new System.EventHandler(this.Note_Click);
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(178, 123);
            this.Controls.Add(this.Note);
            this.Controls.Add(this.Classe);
            this.Controls.Add(this.Etudient);
            this.Name = "MainFrm";
            this.Text = "MainFrm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFrm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Etudient;
        private System.Windows.Forms.Button Classe;
        private System.Windows.Forms.Button Note;
    }
}