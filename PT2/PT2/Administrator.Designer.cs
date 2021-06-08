
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
            this.listAbonne = new System.Windows.Forms.ListBox();
            this.ConsulEmpProlongé = new System.Windows.Forms.Button();
            this.RefreshRetards = new System.Windows.Forms.Button();
            this.listEmprunt = new System.Windows.Forms.ListBox();
            this.AlbumNonEmp = new System.Windows.Forms.Button();
            this.TopAlbumEmp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Purgeur
            // 
            this.Purgeur.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Purgeur.Location = new System.Drawing.Point(923, 440);
            this.Purgeur.Margin = new System.Windows.Forms.Padding(4);
            this.Purgeur.Name = "Purgeur";
            this.Purgeur.Size = new System.Drawing.Size(149, 28);
            this.Purgeur.TabIndex = 15;
            this.Purgeur.Text = "Purgeur";
            this.Purgeur.UseVisualStyleBackColor = false;
            this.Purgeur.Click += new System.EventHandler(this.Purgeur_Click);
            // 
            // listAbonne
            // 
            this.listAbonne.FormattingEnabled = true;
            this.listAbonne.ItemHeight = 16;
            this.listAbonne.Location = new System.Drawing.Point(725, 14);
            this.listAbonne.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listAbonne.Name = "listAbonne";
            this.listAbonne.Size = new System.Drawing.Size(540, 420);
            this.listAbonne.TabIndex = 14;
            // 
            // ConsulEmpProlongé
            // 
            this.ConsulEmpProlongé.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ConsulEmpProlongé.Location = new System.Drawing.Point(15, 450);
            this.ConsulEmpProlongé.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ConsulEmpProlongé.Name = "ConsulEmpProlongé";
            this.ConsulEmpProlongé.Size = new System.Drawing.Size(193, 28);
            this.ConsulEmpProlongé.TabIndex = 12;
            this.ConsulEmpProlongé.Text = "ConsulEmpruntProlongé";
            this.ConsulEmpProlongé.UseVisualStyleBackColor = false;
            this.ConsulEmpProlongé.Click += new System.EventHandler(this.ConsulEmpProlongé_Click);
            // 
            // RefreshRetards
            // 
            this.RefreshRetards.BackColor = System.Drawing.SystemColors.MenuBar;
            this.RefreshRetards.Location = new System.Drawing.Point(215, 450);
            this.RefreshRetards.Margin = new System.Windows.Forms.Padding(4);
            this.RefreshRetards.Name = "RefreshRetards";
            this.RefreshRetards.Size = new System.Drawing.Size(149, 28);
            this.RefreshRetards.TabIndex = 13;
            this.RefreshRetards.Text = "Actualiser Retards";
            this.RefreshRetards.UseVisualStyleBackColor = false;
            this.RefreshRetards.Click += new System.EventHandler(this.RetardsRetourEmprunt_Click);
            // 
            // listEmprunt
            // 
            this.listEmprunt.FormattingEnabled = true;
            this.listEmprunt.ItemHeight = 16;
            this.listEmprunt.Location = new System.Drawing.Point(15, 14);
            this.listEmprunt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listEmprunt.Name = "listEmprunt";
            this.listEmprunt.Size = new System.Drawing.Size(706, 420);
            this.listEmprunt.TabIndex = 11;
            // 
            // AlbumNonEmp
            // 
            this.AlbumNonEmp.BackColor = System.Drawing.SystemColors.MenuBar;
            this.AlbumNonEmp.Location = new System.Drawing.Point(372, 450);
            this.AlbumNonEmp.Margin = new System.Windows.Forms.Padding(4);
            this.AlbumNonEmp.Name = "AlbumNonEmp";
            this.AlbumNonEmp.Size = new System.Drawing.Size(165, 28);
            this.AlbumNonEmp.TabIndex = 17;
            this.AlbumNonEmp.Text = "Album Non Emprunté";
            this.AlbumNonEmp.UseVisualStyleBackColor = false;
            this.AlbumNonEmp.Click += new System.EventHandler(this.AlbumNonEmp_Click);
            // 
            // TopAlbumEmp
            // 
            this.TopAlbumEmp.BackColor = System.Drawing.SystemColors.MenuBar;
            this.TopAlbumEmp.Location = new System.Drawing.Point(545, 450);
            this.TopAlbumEmp.Margin = new System.Windows.Forms.Padding(4);
            this.TopAlbumEmp.Name = "TopAlbumEmp";
            this.TopAlbumEmp.Size = new System.Drawing.Size(165, 28);
            this.TopAlbumEmp.TabIndex = 18;
            this.TopAlbumEmp.Text = "Top Album Emprunté";
            this.TopAlbumEmp.UseVisualStyleBackColor = false;
            this.TopAlbumEmp.Click += new System.EventHandler(this.TopAlbumEmp_Click);
            // 
            // Administrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1279, 554);
            this.Controls.Add(this.TopAlbumEmp);
            this.Controls.Add(this.AlbumNonEmp);
            this.Controls.Add(this.Purgeur);
            this.Controls.Add(this.listAbonne);
            this.Controls.Add(this.ConsulEmpProlongé);
            this.Controls.Add(this.RefreshRetards);
            this.Controls.Add(this.listEmprunt);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Administrator";
            this.Text = "Administrator";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Purgeur;
        private System.Windows.Forms.ListBox listAbonne;
        private System.Windows.Forms.Button ConsulEmpProlongé;
        private System.Windows.Forms.Button RefreshRetards;
        private System.Windows.Forms.ListBox listEmprunt;
        private System.Windows.Forms.Button AlbumNonEmp;
        private System.Windows.Forms.Button TopAlbumEmp;
    }
}