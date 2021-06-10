
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
            this.Purgeur.Location = new System.Drawing.Point(692, 358);
            this.Purgeur.Name = "Purgeur";
            this.Purgeur.Size = new System.Drawing.Size(112, 23);
            this.Purgeur.TabIndex = 15;
            this.Purgeur.Text = "Purgeur";
            this.Purgeur.UseVisualStyleBackColor = false;
            this.Purgeur.Click += new System.EventHandler(this.Purgeur_Click);
            // 
            // listAbonne
            // 
            this.listAbonne.FormatString = "D";
            this.listAbonne.FormattingEnabled = true;
            this.listAbonne.HorizontalScrollbar = true;
            this.listAbonne.Location = new System.Drawing.Point(544, 11);
            this.listAbonne.Margin = new System.Windows.Forms.Padding(2);
            this.listAbonne.Name = "listAbonne";
            this.listAbonne.Size = new System.Drawing.Size(406, 342);
            this.listAbonne.TabIndex = 14;
            // 
            // ConsulEmpProlongé
            // 
            this.ConsulEmpProlongé.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ConsulEmpProlongé.Location = new System.Drawing.Point(11, 366);
            this.ConsulEmpProlongé.Margin = new System.Windows.Forms.Padding(2);
            this.ConsulEmpProlongé.Name = "ConsulEmpProlongé";
            this.ConsulEmpProlongé.Size = new System.Drawing.Size(145, 23);
            this.ConsulEmpProlongé.TabIndex = 12;
            this.ConsulEmpProlongé.Text = "ConsulEmpruntProlongé";
            this.ConsulEmpProlongé.UseVisualStyleBackColor = false;
            this.ConsulEmpProlongé.Click += new System.EventHandler(this.ConsulEmpProlongé_Click);
            // 
            // RefreshRetards
            // 
            this.RefreshRetards.BackColor = System.Drawing.SystemColors.MenuBar;
            this.RefreshRetards.Location = new System.Drawing.Point(161, 366);
            this.RefreshRetards.Name = "RefreshRetards";
            this.RefreshRetards.Size = new System.Drawing.Size(112, 23);
            this.RefreshRetards.TabIndex = 13;
            this.RefreshRetards.Text = "Retards Emprunts";
            this.RefreshRetards.UseVisualStyleBackColor = false;
            this.RefreshRetards.Click += new System.EventHandler(this.RetardsRetourEmprunt_Click);
            // 
            // listEmprunt
            // 
            this.listEmprunt.FormattingEnabled = true;
            this.listEmprunt.HorizontalScrollbar = true;
            this.listEmprunt.Location = new System.Drawing.Point(11, 11);
            this.listEmprunt.Margin = new System.Windows.Forms.Padding(2);
            this.listEmprunt.Name = "listEmprunt";
            this.listEmprunt.Size = new System.Drawing.Size(530, 342);
            this.listEmprunt.TabIndex = 11;
            // 
            // AlbumNonEmp
            // 
            this.AlbumNonEmp.BackColor = System.Drawing.SystemColors.MenuBar;
            this.AlbumNonEmp.Location = new System.Drawing.Point(279, 366);
            this.AlbumNonEmp.Name = "AlbumNonEmp";
            this.AlbumNonEmp.Size = new System.Drawing.Size(124, 23);
            this.AlbumNonEmp.TabIndex = 17;
            this.AlbumNonEmp.Text = "Album Non Emprunté";
            this.AlbumNonEmp.UseVisualStyleBackColor = false;
            this.AlbumNonEmp.Click += new System.EventHandler(this.AlbumNonEmp_Click);
            // 
            // TopAlbumEmp
            // 
            this.TopAlbumEmp.BackColor = System.Drawing.SystemColors.MenuBar;
            this.TopAlbumEmp.Location = new System.Drawing.Point(409, 366);
            this.TopAlbumEmp.Name = "TopAlbumEmp";
            this.TopAlbumEmp.Size = new System.Drawing.Size(124, 23);
            this.TopAlbumEmp.TabIndex = 18;
            this.TopAlbumEmp.Text = "Top Album Emprunté";
            this.TopAlbumEmp.UseVisualStyleBackColor = false;
            this.TopAlbumEmp.Click += new System.EventHandler(this.TopAlbumEmp_Click);
            // 
            // Administrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 450);
            this.Controls.Add(this.TopAlbumEmp);
            this.Controls.Add(this.AlbumNonEmp);
            this.Controls.Add(this.Purgeur);
            this.Controls.Add(this.listAbonne);
            this.Controls.Add(this.ConsulEmpProlongé);
            this.Controls.Add(this.RefreshRetards);
            this.Controls.Add(this.listEmprunt);
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