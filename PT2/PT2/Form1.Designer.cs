
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.supp = new System.Windows.Forms.Button();
            this.ajouter = new System.Windows.Forms.Button();
            this.emprunt = new System.Windows.Forms.Button();
            this.retourne = new System.Windows.Forms.Button();
            this.ConsulE = new System.Windows.Forms.Button();
            this.Prolongation = new System.Windows.Forms.Button();
            this.ConsulEmpProlongé = new System.Windows.Forms.Button();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.RefreshRetards = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(9, 10);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(409, 69);
            this.listBox1.TabIndex = 0;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(9, 92);
            this.listBox2.Margin = new System.Windows.Forms.Padding(2);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(409, 69);
            this.listBox2.TabIndex = 1;
            // 
            // supp
            // 
            this.supp.Location = new System.Drawing.Point(422, 5);
            this.supp.Margin = new System.Windows.Forms.Padding(2);
            this.supp.Name = "supp";
            this.supp.Size = new System.Drawing.Size(70, 24);
            this.supp.TabIndex = 2;
            this.supp.Text = "Supprimer";
            this.supp.UseVisualStyleBackColor = true;
            this.supp.Click += new System.EventHandler(this.supp_Click);
            // 
            // ajouter
            // 
            this.ajouter.Location = new System.Drawing.Point(422, 33);
            this.ajouter.Margin = new System.Windows.Forms.Padding(2);
            this.ajouter.Name = "ajouter";
            this.ajouter.Size = new System.Drawing.Size(70, 23);
            this.ajouter.TabIndex = 3;
            this.ajouter.Text = "Ajouter Abonné";
            this.ajouter.UseVisualStyleBackColor = true;
            this.ajouter.Click += new System.EventHandler(this.ajouter_Click);
            // 
            // emprunt
            // 
            this.emprunt.Location = new System.Drawing.Point(422, 86);
            this.emprunt.Margin = new System.Windows.Forms.Padding(2);
            this.emprunt.Name = "emprunt";
            this.emprunt.Size = new System.Drawing.Size(66, 19);
            this.emprunt.TabIndex = 4;
            this.emprunt.Text = "Emprunter";
            this.emprunt.UseVisualStyleBackColor = true;
            this.emprunt.Click += new System.EventHandler(this.emprunt_Click);
            // 
            // retourne
            // 
            this.retourne.Location = new System.Drawing.Point(422, 109);
            this.retourne.Margin = new System.Windows.Forms.Padding(2);
            this.retourne.Name = "retourne";
            this.retourne.Size = new System.Drawing.Size(64, 19);
            this.retourne.TabIndex = 5;
            this.retourne.Text = "Retourner";
            this.retourne.UseVisualStyleBackColor = true;
            this.retourne.Click += new System.EventHandler(this.retourne_Click);
            // 
            // ConsulE
            // 
            this.ConsulE.Location = new System.Drawing.Point(490, 111);
            this.ConsulE.Margin = new System.Windows.Forms.Padding(2);
            this.ConsulE.Name = "ConsulE";
            this.ConsulE.Size = new System.Drawing.Size(115, 23);
            this.ConsulE.TabIndex = 6;
            this.ConsulE.Text = "Consulter Emprunt";
            this.ConsulE.UseVisualStyleBackColor = true;
            this.ConsulE.Click += new System.EventHandler(this.ConsulE_Click);
            // 
            // Prolongation
            // 
            this.Prolongation.Location = new System.Drawing.Point(492, 84);
            this.Prolongation.Margin = new System.Windows.Forms.Padding(2);
            this.Prolongation.Name = "Prolongation";
            this.Prolongation.Size = new System.Drawing.Size(115, 23);
            this.Prolongation.TabIndex = 7;
            this.Prolongation.Text = "Prolonger Emprunt";
            this.Prolongation.UseVisualStyleBackColor = true;
            this.Prolongation.Click += new System.EventHandler(this.Prolongation_Click);
            // 
            // ConsulEmpProlongé
            // 
            this.ConsulEmpProlongé.Location = new System.Drawing.Point(422, 187);
            this.ConsulEmpProlongé.Margin = new System.Windows.Forms.Padding(2);
            this.ConsulEmpProlongé.Name = "ConsulEmpProlongé";
            this.ConsulEmpProlongé.Size = new System.Drawing.Size(145, 23);
            this.ConsulEmpProlongé.TabIndex = 8;
            this.ConsulEmpProlongé.Text = "ConsulEmpruntProlongé";
            this.ConsulEmpProlongé.UseVisualStyleBackColor = true;
            this.ConsulEmpProlongé.Click += new System.EventHandler(this.ConsulEmpProlongé_Click);
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(9, 187);
            this.listBox3.Margin = new System.Windows.Forms.Padding(2);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(409, 69);
            this.listBox3.TabIndex = 7;
            // 
            // RefreshRetards
            // 
            this.RefreshRetards.Location = new System.Drawing.Point(423, 215);
            this.RefreshRetards.Name = "RefreshRetards";
            this.RefreshRetards.Size = new System.Drawing.Size(112, 23);
            this.RefreshRetards.TabIndex = 8;
            this.RefreshRetards.Text = "Actualiser Retards";
            this.RefreshRetards.UseVisualStyleBackColor = true;
            this.RefreshRetards.Click += new System.EventHandler(this.RefreshRetards_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.ConsulEmpProlongé);
            this.Controls.Add(this.Prolongation);
            this.Controls.Add(this.ConsulE);
            this.Controls.Add(this.RefreshRetards);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.retourne);
            this.Controls.Add(this.emprunt);
            this.Controls.Add(this.ajouter);
            this.Controls.Add(this.supp);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button supp;
        private System.Windows.Forms.Button ajouter;
        private System.Windows.Forms.Button emprunt;
        private System.Windows.Forms.Button retourne;
        private System.Windows.Forms.Button ConsulE;
        private System.Windows.Forms.Button Prolongation;
        private System.Windows.Forms.Button ConsulEmpProlongé;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Button RefreshRetards;
    }
}

