
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(9, 10);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(282, 69);
            this.listBox1.TabIndex = 0;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(9, 136);
            this.listBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(282, 69);
            this.listBox2.TabIndex = 1;
            // 
            // supp
            // 
            this.supp.Location = new System.Drawing.Point(295, 10);
            this.supp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.supp.Name = "supp";
            this.supp.Size = new System.Drawing.Size(56, 19);
            this.supp.TabIndex = 2;
            this.supp.Text = "Supprimer";
            this.supp.UseVisualStyleBackColor = true;
            this.supp.Click += new System.EventHandler(this.supp_Click);
            // 
            // ajouter
            // 
            this.ajouter.Location = new System.Drawing.Point(295, 68);
            this.ajouter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ajouter.Name = "ajouter";
            this.ajouter.Size = new System.Drawing.Size(56, 19);
            this.ajouter.TabIndex = 3;
            this.ajouter.Text = "Ajouter Abonné";
            this.ajouter.UseVisualStyleBackColor = true;
            this.ajouter.Click += new System.EventHandler(this.ajouter_Click);
            // 
            // emprunt
            // 
            this.emprunt.Location = new System.Drawing.Point(9, 219);
            this.emprunt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.emprunt.Name = "emprunt";
            this.emprunt.Size = new System.Drawing.Size(56, 19);
            this.emprunt.TabIndex = 4;
            this.emprunt.Text = "Emprunter";
            this.emprunt.UseVisualStyleBackColor = true;
            this.emprunt.Click += new System.EventHandler(this.emprunt_Click);
            // 
            // retourne
            // 
            this.retourne.Location = new System.Drawing.Point(89, 219);
            this.retourne.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.retourne.Name = "retourne";
            this.retourne.Size = new System.Drawing.Size(56, 19);
            this.retourne.TabIndex = 5;
            this.retourne.Text = "Retourner";
            this.retourne.UseVisualStyleBackColor = true;
            this.retourne.Click += new System.EventHandler(this.retourne_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(406, 181);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "TopAlbum";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.retourne);
            this.Controls.Add(this.emprunt);
            this.Controls.Add(this.ajouter);
            this.Controls.Add(this.supp);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

