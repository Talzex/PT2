
namespace PT2
{
    partial class USER
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
            this.Prolongation = new System.Windows.Forms.Button();
            this.retourne = new System.Windows.Forms.Button();
            this.emprunt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.suivant = new System.Windows.Forms.Button();
            this.precedent = new System.Windows.Forms.Button();
            this.ProlAllEmprunt = new System.Windows.Forms.Button();
            this.Suggestions = new System.Windows.Forms.Button();
            this.GridDisques = new System.Windows.Forms.DataGridView();
            this.Titre_Album = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editeur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Emprunté = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prolongé = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date_emprunt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date_retour_attendue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date_retour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GridDisques)).BeginInit();
            this.SuspendLayout();
            // 
            // Prolongation
            // 
            this.Prolongation.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Prolongation.Location = new System.Drawing.Point(1067, 345);
            this.Prolongation.Margin = new System.Windows.Forms.Padding(2);
            this.Prolongation.Name = "Prolongation";
            this.Prolongation.Size = new System.Drawing.Size(152, 23);
            this.Prolongation.TabIndex = 12;
            this.Prolongation.Text = "Prolonger Emprunt";
            this.Prolongation.UseVisualStyleBackColor = false;
            this.Prolongation.Click += new System.EventHandler(this.Prolongation_Click);
            // 
            // retourne
            // 
            this.retourne.BackColor = System.Drawing.SystemColors.MenuBar;
            this.retourne.Location = new System.Drawing.Point(640, 345);
            this.retourne.Margin = new System.Windows.Forms.Padding(2);
            this.retourne.Name = "retourne";
            this.retourne.Size = new System.Drawing.Size(142, 23);
            this.retourne.TabIndex = 10;
            this.retourne.Text = "Retourner";
            this.retourne.UseVisualStyleBackColor = false;
            this.retourne.Click += new System.EventHandler(this.retourne_Click);
            // 
            // emprunt
            // 
            this.emprunt.BackColor = System.Drawing.SystemColors.MenuBar;
            this.emprunt.Location = new System.Drawing.Point(165, 399);
            this.emprunt.Margin = new System.Windows.Forms.Padding(2);
            this.emprunt.Name = "emprunt";
            this.emprunt.Size = new System.Drawing.Size(153, 23);
            this.emprunt.TabIndex = 9;
            this.emprunt.Text = "Emprunter";
            this.emprunt.UseVisualStyleBackColor = false;
            this.emprunt.Click += new System.EventHandler(this.emprunt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 377);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Recherche : ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(99, 374);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(359, 20);
            this.textBox1.TabIndex = 15;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // suivant
            // 
            this.suivant.Location = new System.Drawing.Point(333, 345);
            this.suivant.Name = "suivant";
            this.suivant.Size = new System.Drawing.Size(125, 23);
            this.suivant.TabIndex = 16;
            this.suivant.Text = "Suivant";
            this.suivant.UseVisualStyleBackColor = true;
            // 
            // precedent
            // 
            this.precedent.Location = new System.Drawing.Point(12, 345);
            this.precedent.Name = "precedent";
            this.precedent.Size = new System.Drawing.Size(134, 23);
            this.precedent.TabIndex = 17;
            this.precedent.Text = "Précédent";
            this.precedent.UseVisualStyleBackColor = true;
            // 
            // ProlAllEmprunt
            // 
            this.ProlAllEmprunt.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ProlAllEmprunt.Location = new System.Drawing.Point(832, 345);
            this.ProlAllEmprunt.Margin = new System.Windows.Forms.Padding(2);
            this.ProlAllEmprunt.Name = "ProlAllEmprunt";
            this.ProlAllEmprunt.Size = new System.Drawing.Size(172, 23);
            this.ProlAllEmprunt.TabIndex = 18;
            this.ProlAllEmprunt.Text = "Prolonger Tout Emprunt";
            this.ProlAllEmprunt.UseVisualStyleBackColor = false;
            this.ProlAllEmprunt.Click += new System.EventHandler(this.ProlAllEmprunt_Click);
            // 
            // Suggestions
            // 
            this.Suggestions.Location = new System.Drawing.Point(165, 345);
            this.Suggestions.Name = "Suggestions";
            this.Suggestions.Size = new System.Drawing.Size(153, 23);
            this.Suggestions.TabIndex = 19;
            this.Suggestions.Text = "Suggestions";
            this.Suggestions.UseVisualStyleBackColor = true;
            this.Suggestions.Click += new System.EventHandler(this.Suggestions_Click);
            // 
            // GridDisques
            // 
            this.GridDisques.AllowUserToAddRows = false;
            this.GridDisques.AllowUserToDeleteRows = false;
            this.GridDisques.AllowUserToOrderColumns = true;
            this.GridDisques.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridDisques.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Titre_Album,
            this.Genre,
            this.Editeur,
            this.Emprunté,
            this.Prolongé,
            this.Date_emprunt,
            this.Date_retour_attendue,
            this.Date_retour});
            this.GridDisques.Location = new System.Drawing.Point(12, 12);
            this.GridDisques.Name = "GridDisques";
            this.GridDisques.Size = new System.Drawing.Size(1207, 327);
            this.GridDisques.TabIndex = 20;
            this.GridDisques.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridDisques_CellContentClick);
            // 
            // Titre_Album
            // 
            this.Titre_Album.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Titre_Album.HeaderText = "Titre_Album";
            this.Titre_Album.Name = "Titre_Album";
            this.Titre_Album.ReadOnly = true;
            this.Titre_Album.Width = 88;
            // 
            // Genre
            // 
            this.Genre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Genre.HeaderText = "Genre";
            this.Genre.Name = "Genre";
            this.Genre.ReadOnly = true;
            this.Genre.Width = 61;
            // 
            // Editeur
            // 
            this.Editeur.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Editeur.HeaderText = "Editeur";
            this.Editeur.Name = "Editeur";
            this.Editeur.ReadOnly = true;
            this.Editeur.Width = 65;
            // 
            // Emprunté
            // 
            this.Emprunté.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Emprunté.HeaderText = "Emprunté";
            this.Emprunté.Name = "Emprunté";
            this.Emprunté.ReadOnly = true;
            this.Emprunté.Width = 77;
            // 
            // Prolongé
            // 
            this.Prolongé.HeaderText = "Prolongé";
            this.Prolongé.Name = "Prolongé";
            this.Prolongé.ReadOnly = true;
            // 
            // Date_emprunt
            // 
            this.Date_emprunt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Date_emprunt.HeaderText = "Date_emprunt";
            this.Date_emprunt.Name = "Date_emprunt";
            this.Date_emprunt.ReadOnly = true;
            this.Date_emprunt.Width = 99;
            // 
            // Date_retour_attendue
            // 
            this.Date_retour_attendue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Date_retour_attendue.HeaderText = "Date_retour_attendue";
            this.Date_retour_attendue.Name = "Date_retour_attendue";
            this.Date_retour_attendue.ReadOnly = true;
            this.Date_retour_attendue.Width = 136;
            // 
            // Date_retour
            // 
            this.Date_retour.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Date_retour.HeaderText = "Date_retour";
            this.Date_retour.Name = "Date_retour";
            this.Date_retour.ReadOnly = true;
            this.Date_retour.Width = 88;
            // 
            // USER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 450);
            this.Controls.Add(this.GridDisques);
            this.Controls.Add(this.Suggestions);
            this.Controls.Add(this.ProlAllEmprunt);
            this.Controls.Add(this.precedent);
            this.Controls.Add(this.suivant);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Prolongation);
            this.Controls.Add(this.retourne);
            this.Controls.Add(this.emprunt);
            this.Name = "USER";
            this.Text = "USER";
            ((System.ComponentModel.ISupportInitialize)(this.GridDisques)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Prolongation;
        private System.Windows.Forms.Button retourne;
        private System.Windows.Forms.Button emprunt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button suivant;
        private System.Windows.Forms.Button precedent;
        private System.Windows.Forms.Button ProlAllEmprunt;
        private System.Windows.Forms.Button Suggestions;
        private System.Windows.Forms.DataGridView GridDisques;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titre_Album;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Editeur;
        private System.Windows.Forms.DataGridViewTextBoxColumn Emprunté;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prolongé;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_emprunt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_retour_attendue;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_retour;
    }
}