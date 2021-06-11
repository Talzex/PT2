
namespace PT2
{
    partial class Administrator
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
            this.Purgeur = new System.Windows.Forms.Button();
            this.ConsulEmpProlongé = new System.Windows.Forms.Button();
            this.RefreshRetards = new System.Windows.Forms.Button();
            this.AlbumNonEmp = new System.Windows.Forms.Button();
            this.TopAlbumEmp = new System.Windows.Forms.Button();
            this.Abonnés = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.idname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emprunt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.retour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Abonnés)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // Purgeur
            // 
            this.Purgeur.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Purgeur.Location = new System.Drawing.Point(1147, 547);
            this.Purgeur.Name = "Purgeur";
            this.Purgeur.Size = new System.Drawing.Size(112, 23);
            this.Purgeur.TabIndex = 15;
            this.Purgeur.Text = "Purgeur";
            this.Purgeur.UseVisualStyleBackColor = false;
            this.Purgeur.Click += new System.EventHandler(this.Purgeur_Click);
            // 
            // ConsulEmpProlongé
            // 
            this.ConsulEmpProlongé.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ConsulEmpProlongé.Location = new System.Drawing.Point(12, 546);
            this.ConsulEmpProlongé.Margin = new System.Windows.Forms.Padding(2);
            this.ConsulEmpProlongé.Name = "ConsulEmpProlongé";
            this.ConsulEmpProlongé.Size = new System.Drawing.Size(111, 23);
            this.ConsulEmpProlongé.TabIndex = 12;
            this.ConsulEmpProlongé.Text = "Emprunts Prolongés";
            this.ConsulEmpProlongé.UseVisualStyleBackColor = false;
            this.ConsulEmpProlongé.Click += new System.EventHandler(this.ConsulEmpProlongé_Click);
            // 
            // RefreshRetards
            // 
            this.RefreshRetards.BackColor = System.Drawing.SystemColors.MenuBar;
            this.RefreshRetards.Location = new System.Drawing.Point(141, 546);
            this.RefreshRetards.Name = "RefreshRetards";
            this.RefreshRetards.Size = new System.Drawing.Size(110, 23);
            this.RefreshRetards.TabIndex = 13;
            this.RefreshRetards.Text = "Emprunts en Retard";
            this.RefreshRetards.UseVisualStyleBackColor = false;
            this.RefreshRetards.Click += new System.EventHandler(this.RetardsRetourEmprunt_Click);
            // 
            // AlbumNonEmp
            // 
            this.AlbumNonEmp.BackColor = System.Drawing.SystemColors.MenuBar;
            this.AlbumNonEmp.Location = new System.Drawing.Point(270, 546);
            this.AlbumNonEmp.Name = "AlbumNonEmp";
            this.AlbumNonEmp.Size = new System.Drawing.Size(162, 23);
            this.AlbumNonEmp.TabIndex = 17;
            this.AlbumNonEmp.Text = "Albums Non Empruntés Depuis";
            this.AlbumNonEmp.UseVisualStyleBackColor = false;
            this.AlbumNonEmp.Click += new System.EventHandler(this.AlbumNonEmp_Click);
            // 
            // TopAlbumEmp
            // 
            this.TopAlbumEmp.BackColor = System.Drawing.SystemColors.MenuBar;
            this.TopAlbumEmp.Location = new System.Drawing.Point(602, 547);
            this.TopAlbumEmp.Name = "TopAlbumEmp";
            this.TopAlbumEmp.Size = new System.Drawing.Size(124, 23);
            this.TopAlbumEmp.TabIndex = 18;
            this.TopAlbumEmp.Text = "Top Album Emprunté";
            this.TopAlbumEmp.UseVisualStyleBackColor = false;
            this.TopAlbumEmp.Click += new System.EventHandler(this.TopAlbumEmp_Click);
            // 
            // Abonnés
            // 
            this.Abonnés.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.Abonnés.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Abonnés.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idname,
            this.nom,
            this.prenom,
            this.date,
            this.titre,
            this.emprunt,
            this.delai,
            this.retour});
            this.Abonnés.GridColor = System.Drawing.Color.DodgerBlue;
            this.Abonnés.Location = new System.Drawing.Point(12, 12);
            this.Abonnés.Name = "Abonnés";
            this.Abonnés.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.Abonnés.Size = new System.Drawing.Size(1247, 529);
            this.Abonnés.TabIndex = 19;
            // 
            // idname
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(556, 551);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "jours";
            // 
            // date
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(438, 548);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(112, 20);
            this.numericUpDown1.TabIndex = 23;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // idname
            // 
            this.idname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idname.HeaderText = "Identifiant";
            this.idname.Name = "idname";
            this.idname.ReadOnly = true;
            this.idname.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.idname.Width = 78;
            // 
            // nom
            // 
            this.nom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nom.HeaderText = "Nom";
            this.nom.Name = "nom";
            this.nom.ReadOnly = true;
            this.nom.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.nom.Width = 54;
            // 
            // prenom
            // 
            this.prenom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.prenom.HeaderText = "Prénom";
            this.prenom.Name = "prenom";
            this.prenom.ReadOnly = true;
            this.prenom.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.prenom.Width = 68;
            // 
            // date
            // 
            this.date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.date.HeaderText = "Date du Dernier Emprunt";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            this.date.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.date.Width = 136;
            // 
            // titre
            // 
            this.titre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.titre.HeaderText = "Titre";
            this.titre.Name = "titre";
            this.titre.ReadOnly = true;
            this.titre.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.titre.Width = 53;
            // 
            // emprunt
            // 
            this.emprunt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.emprunt.HeaderText = "Date d\'Emprunt";
            this.emprunt.Name = "emprunt";
            this.emprunt.ReadOnly = true;
            this.emprunt.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.emprunt.Width = 96;
            // 
            // delai
            // 
            this.delai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.delai.HeaderText = "Date de Retour Attendue";
            this.delai.Name = "delai";
            this.delai.ReadOnly = true;
            this.delai.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.delai.Width = 138;
            // 
            // retour
            // 
            this.retour.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.retour.HeaderText = "Date de Retour";
            this.retour.Name = "retour";
            this.retour.ReadOnly = true;
            this.retour.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.retour.Width = 96;
            // 
            // Administrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1271, 651);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Abonnés);
            this.Controls.Add(this.TopAlbumEmp);
            this.Controls.Add(this.AlbumNonEmp);
            this.Controls.Add(this.Purgeur);
            this.Controls.Add(this.ConsulEmpProlongé);
            this.Controls.Add(this.RefreshRetards);
            this.Name = "Administrator";
            this.Text = "Administrator";
            ((System.ComponentModel.ISupportInitialize)(this.Abonnés)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Purgeur;
        private System.Windows.Forms.Button ConsulEmpProlongé;
        private System.Windows.Forms.Button RefreshRetards;
        private System.Windows.Forms.Button AlbumNonEmp;
        private System.Windows.Forms.Button TopAlbumEmp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.DataGridView Abonnés;
        private System.Windows.Forms.DataGridViewTextBoxColumn idname;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn titre;
        private System.Windows.Forms.DataGridViewTextBoxColumn emprunt;
        private System.Windows.Forms.DataGridViewTextBoxColumn delai;
        private System.Windows.Forms.DataGridViewTextBoxColumn retour;
    }
}