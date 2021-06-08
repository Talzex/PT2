
namespace PT2
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.listEdition = new System.Windows.Forms.ListBox();
            this.listEmprunt = new System.Windows.Forms.ListBox();
            this.supp = new System.Windows.Forms.Button();
            this.ajouter = new System.Windows.Forms.Button();
            this.emprunt = new System.Windows.Forms.Button();
            this.retourne = new System.Windows.Forms.Button();
            this.ConsulE = new System.Windows.Forms.Button();
            this.Prolongation = new System.Windows.Forms.Button();
            this.ConsulEmpProlongé = new System.Windows.Forms.Button();
            this.listProlongement = new System.Windows.Forms.ListBox();
            this.RefreshRetards = new System.Windows.Forms.Button();
            this.listPurge = new System.Windows.Forms.ListBox();
            this.Purgeur = new System.Windows.Forms.Button();
            this.ProlongeTousEmprunts = new System.Windows.Forms.Button();
            this.AlbumNonEmp = new System.Windows.Forms.Button();
            this.TopAlbumEmp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listEdition
            // 
            this.listEdition.ForeColor = System.Drawing.SystemColors.InfoText;
            this.listEdition.FormattingEnabled = true;
            this.listEdition.Location = new System.Drawing.Point(183, 26);
            this.listEdition.Margin = new System.Windows.Forms.Padding(2);
            this.listEdition.Name = "listEdition";
            this.listEdition.Size = new System.Drawing.Size(483, 69);
            this.listEdition.TabIndex = 0;
            // 
            // listEmprunt
            // 
            this.listEmprunt.FormattingEnabled = true;
            this.listEmprunt.Location = new System.Drawing.Point(183, 143);
            this.listEmprunt.Margin = new System.Windows.Forms.Padding(2);
            this.listEmprunt.Name = "listEmprunt";
            this.listEmprunt.Size = new System.Drawing.Size(483, 69);
            this.listEmprunt.TabIndex = 1;
            // 
            // supp
            // 
            this.supp.BackColor = System.Drawing.SystemColors.MenuBar;
            this.supp.Location = new System.Drawing.Point(440, 99);
            this.supp.Margin = new System.Windows.Forms.Padding(2);
            this.supp.Name = "supp";
            this.supp.Size = new System.Drawing.Size(70, 24);
            this.supp.TabIndex = 2;
            this.supp.Text = "Supprimer";
            this.supp.UseVisualStyleBackColor = false;
            this.supp.Click += new System.EventHandler(this.supp_Click);
            // 
            // ajouter
            // 
            this.ajouter.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ajouter.Location = new System.Drawing.Point(333, 99);
            this.ajouter.Margin = new System.Windows.Forms.Padding(2);
            this.ajouter.Name = "ajouter";
            this.ajouter.Size = new System.Drawing.Size(70, 23);
            this.ajouter.TabIndex = 3;
            this.ajouter.Text = "Ajouter Abonné";
            this.ajouter.UseVisualStyleBackColor = false;
            this.ajouter.Click += new System.EventHandler(this.ajouter_Click);
            // 
            // emprunt
            // 
            this.emprunt.BackColor = System.Drawing.SystemColors.MenuBar;
            this.emprunt.Location = new System.Drawing.Point(544, 216);
            this.emprunt.Margin = new System.Windows.Forms.Padding(2);
            this.emprunt.Name = "emprunt";
            this.emprunt.Size = new System.Drawing.Size(66, 24);
            this.emprunt.TabIndex = 4;
            this.emprunt.Text = "Emprunter";
            this.emprunt.UseVisualStyleBackColor = false;
            this.emprunt.Click += new System.EventHandler(this.emprunt_Click);
            // 
            // retourne
            // 
            this.retourne.BackColor = System.Drawing.SystemColors.MenuBar;
            this.retourne.Location = new System.Drawing.Point(614, 216);
            this.retourne.Margin = new System.Windows.Forms.Padding(2);
            this.retourne.Name = "retourne";
            this.retourne.Size = new System.Drawing.Size(64, 24);
            this.retourne.TabIndex = 5;
            this.retourne.Text = "Retourner";
            this.retourne.UseVisualStyleBackColor = false;
            this.retourne.Click += new System.EventHandler(this.retourne_Click);
            // 
            // ConsulE
            // 
            this.ConsulE.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ConsulE.Location = new System.Drawing.Point(425, 216);
            this.ConsulE.Margin = new System.Windows.Forms.Padding(2);
            this.ConsulE.Name = "ConsulE";
            this.ConsulE.Size = new System.Drawing.Size(115, 25);
            this.ConsulE.TabIndex = 6;
            this.ConsulE.Text = "Consulter Emprunt";
            this.ConsulE.UseVisualStyleBackColor = false;
            this.ConsulE.Click += new System.EventHandler(this.ConsulE_Click);
            // 
            // Prolongation
            // 
            this.Prolongation.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Prolongation.Location = new System.Drawing.Point(163, 216);
            this.Prolongation.Margin = new System.Windows.Forms.Padding(2);
            this.Prolongation.Name = "Prolongation";
            this.Prolongation.Size = new System.Drawing.Size(115, 25);
            this.Prolongation.TabIndex = 7;
            this.Prolongation.Text = "Prolonger Emprunt";
            this.Prolongation.UseVisualStyleBackColor = false;
            this.Prolongation.Click += new System.EventHandler(this.Prolongation_Click);
            // 
            // ConsulEmpProlongé
            // 
            this.ConsulEmpProlongé.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ConsulEmpProlongé.Location = new System.Drawing.Point(275, 343);
            this.ConsulEmpProlongé.Margin = new System.Windows.Forms.Padding(2);
            this.ConsulEmpProlongé.Name = "ConsulEmpProlongé";
            this.ConsulEmpProlongé.Size = new System.Drawing.Size(145, 23);
            this.ConsulEmpProlongé.TabIndex = 8;
            this.ConsulEmpProlongé.Text = "ConsulEmpruntProlongé";
            this.ConsulEmpProlongé.UseVisualStyleBackColor = false;
            this.ConsulEmpProlongé.Click += new System.EventHandler(this.ConsulEmpProlongé_Click);
            // 
            // listProlongement
            // 
            this.listProlongement.FormattingEnabled = true;
            this.listProlongement.Location = new System.Drawing.Point(183, 271);
            this.listProlongement.Margin = new System.Windows.Forms.Padding(2);
            this.listProlongement.Name = "listProlongement";
            this.listProlongement.Size = new System.Drawing.Size(483, 69);
            this.listProlongement.TabIndex = 7;
            // 
            // RefreshRetards
            // 
            this.RefreshRetards.BackColor = System.Drawing.SystemColors.MenuBar;
            this.RefreshRetards.Location = new System.Drawing.Point(440, 343);
            this.RefreshRetards.Name = "RefreshRetards";
            this.RefreshRetards.Size = new System.Drawing.Size(112, 23);
            this.RefreshRetards.TabIndex = 8;
            this.RefreshRetards.Text = "Actualiser Retards";
            this.RefreshRetards.UseVisualStyleBackColor = false;
            this.RefreshRetards.Click += new System.EventHandler(this.RefreshRetards_Click);
            // 
            // listPurge
            // 
            this.listPurge.FormattingEnabled = true;
            this.listPurge.Location = new System.Drawing.Point(183, 402);
            this.listPurge.Margin = new System.Windows.Forms.Padding(2);
            this.listPurge.Name = "listPurge";
            this.listPurge.Size = new System.Drawing.Size(483, 69);
            this.listPurge.TabIndex = 9;
            // 
            // Purgeur
            // 
            this.Purgeur.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Purgeur.Location = new System.Drawing.Point(376, 476);
            this.Purgeur.Name = "Purgeur";
            this.Purgeur.Size = new System.Drawing.Size(112, 23);
            this.Purgeur.TabIndex = 10;
            this.Purgeur.Text = "Purgeur";
            this.Purgeur.UseVisualStyleBackColor = false;
            this.Purgeur.Click += new System.EventHandler(this.Purgeur_Click);
            // 
            // ProlongeTousEmprunts
            // 
            this.ProlongeTousEmprunts.Location = new System.Drawing.Point(283, 215);
            this.ProlongeTousEmprunts.Name = "ProlongeTousEmprunts";
            this.ProlongeTousEmprunts.Size = new System.Drawing.Size(137, 26);
            this.ProlongeTousEmprunts.TabIndex = 11;
            this.ProlongeTousEmprunts.Text = "Prolonger Tous Emprunts";
            this.ProlongeTousEmprunts.UseVisualStyleBackColor = true;
            this.ProlongeTousEmprunts.Click += new System.EventHandler(this.ProlongeTousEmprunts_Click);
            // 
            // AlbumNonEmp
            // 
            this.AlbumNonEmp.BackColor = System.Drawing.SystemColors.MenuBar;
            this.AlbumNonEmp.Location = new System.Drawing.Point(146, 343);
            this.AlbumNonEmp.Name = "AlbumNonEmp";
            this.AlbumNonEmp.Size = new System.Drawing.Size(112, 23);
            this.AlbumNonEmp.TabIndex = 11;
            this.AlbumNonEmp.Text = "AlbumNonEmp";
            this.AlbumNonEmp.UseVisualStyleBackColor = false;
            this.AlbumNonEmp.Click += new System.EventHandler(this.AlbumNonEmp_Click);
            // 
            // TopAlbumEmp
            // 
            this.TopAlbumEmp.Location = new System.Drawing.Point(571, 343);
            this.TopAlbumEmp.Name = "TopAlbumEmp";
            this.TopAlbumEmp.Size = new System.Drawing.Size(75, 23);
            this.TopAlbumEmp.TabIndex = 7;
            this.TopAlbumEmp.Text = "TopAlbum";
            this.TopAlbumEmp.UseVisualStyleBackColor = true;
            this.TopAlbumEmp.Click += new System.EventHandler(this.TopAlbumEmp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 378);
            this.Controls.Add(this.AlbumNonEmp);
            this.Controls.Add(this.ProlongeTousEmprunts);
            this.Controls.Add(this.Purgeur);
            this.Controls.Add(this.listPurge);
            this.Controls.Add(this.ConsulEmpProlongé);
            this.Controls.Add(this.Prolongation);
            this.Controls.Add(this.ConsulE);
            this.Controls.Add(this.RefreshRetards);
            this.Controls.Add(this.listProlongement);
            this.Controls.Add(this.TopAlbumEmp);
            this.Controls.Add(this.retourne);
            this.Controls.Add(this.emprunt);
            this.Controls.Add(this.ajouter);
            this.Controls.Add(this.supp);
            this.Controls.Add(this.listEmprunt);
            this.Controls.Add(this.listEdition);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listEdition;
        private System.Windows.Forms.ListBox listEmprunt;
        private System.Windows.Forms.Button supp;
        private System.Windows.Forms.Button ajouter;
        private System.Windows.Forms.Button emprunt;
        private System.Windows.Forms.Button retourne;
        private System.Windows.Forms.Button TopAlbumEmp;
        private System.Windows.Forms.Button ConsulE;
        private System.Windows.Forms.Button Prolongation;
        private System.Windows.Forms.Button ConsulEmpProlongé;
        private System.Windows.Forms.ListBox listProlongement;
        private System.Windows.Forms.Button RefreshRetards;
        private System.Windows.Forms.ListBox listPurge;
        private System.Windows.Forms.Button Purgeur;
        private System.Windows.Forms.Button ProlongeTousEmprunts;
        private System.Windows.Forms.Button AlbumNonEmp;
    }
}

