
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
            this.components = new System.ComponentModel.Container();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.supp = new System.Windows.Forms.Button();
            this.ajouter = new System.Windows.Forms.Button();
            this.emprunt = new System.Windows.Forms.Button();
            this.retourne = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(375, 95);
            this.listBox1.TabIndex = 0;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(12, 168);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(375, 95);
            this.listBox2.TabIndex = 1;
            // 
            // supp
            // 
            this.supp.Location = new System.Drawing.Point(393, 12);
            this.supp.Name = "supp";
            this.supp.Size = new System.Drawing.Size(75, 23);
            this.supp.TabIndex = 2;
            this.supp.Text = "Supprimer";
            this.supp.UseVisualStyleBackColor = true;
            this.supp.Click += new System.EventHandler(this.supp_Click);
            // 
            // ajouter
            // 
            this.ajouter.Location = new System.Drawing.Point(393, 84);
            this.ajouter.Name = "ajouter";
            this.ajouter.Size = new System.Drawing.Size(75, 23);
            this.ajouter.TabIndex = 3;
            this.ajouter.Text = "Ajouter Abonné";
            this.ajouter.UseVisualStyleBackColor = true;
            this.ajouter.Click += new System.EventHandler(this.ajouter_Click);
            // 
            // emprunt
            // 
            this.emprunt.Location = new System.Drawing.Point(12, 269);
            this.emprunt.Name = "emprunt";
            this.emprunt.Size = new System.Drawing.Size(75, 23);
            this.emprunt.TabIndex = 4;
            this.emprunt.Text = "Emprunter";
            this.emprunt.UseVisualStyleBackColor = true;
            this.emprunt.Click += new System.EventHandler(this.emprunt_Click);
            // 
            // retourne
            // 
            this.retourne.Location = new System.Drawing.Point(119, 269);
            this.retourne.Name = "retourne";
            this.retourne.Size = new System.Drawing.Size(75, 23);
            this.retourne.TabIndex = 5;
            this.retourne.Text = "Retourner";
            this.retourne.UseVisualStyleBackColor = true;
            this.retourne.Click += new System.EventHandler(this.retourne_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.retourne);
            this.Controls.Add(this.emprunt);
            this.Controls.Add(this.ajouter);
            this.Controls.Add(this.supp);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
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
    }
}

