
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
            this.listEmprunt = new System.Windows.Forms.ListBox();
            this.ListeDisques = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.suivant = new System.Windows.Forms.Button();
            this.precedent = new System.Windows.Forms.Button();
            this.ProlAllEmprunt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Prolongation
            // 
            this.Prolongation.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Prolongation.Location = new System.Drawing.Point(1028, 439);
            this.Prolongation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Prolongation.Name = "Prolongation";
            this.Prolongation.Size = new System.Drawing.Size(204, 28);
            this.Prolongation.TabIndex = 12;
            this.Prolongation.Text = "Prolonger Emprunt";
            this.Prolongation.UseVisualStyleBackColor = false;
            this.Prolongation.Click += new System.EventHandler(this.Prolongation_Click);
            // 
            // retourne
            // 
            this.retourne.BackColor = System.Drawing.SystemColors.MenuBar;
            this.retourne.Location = new System.Drawing.Point(592, 439);
            this.retourne.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.retourne.Name = "retourne";
            this.retourne.Size = new System.Drawing.Size(191, 28);
            this.retourne.TabIndex = 10;
            this.retourne.Text = "Retourner";
            this.retourne.UseVisualStyleBackColor = false;
            this.retourne.Click += new System.EventHandler(this.retourne_Click);
            // 
            // emprunt
            // 
            this.emprunt.BackColor = System.Drawing.SystemColors.MenuBar;
            this.emprunt.Location = new System.Drawing.Point(198, 425);
            this.emprunt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.emprunt.Name = "emprunt";
            this.emprunt.Size = new System.Drawing.Size(151, 28);
            this.emprunt.TabIndex = 9;
            this.emprunt.Text = "Emprunter";
            this.emprunt.UseVisualStyleBackColor = false;
            this.emprunt.Click += new System.EventHandler(this.emprunt_Click);
            // 
            // listEmprunt
            // 
            this.listEmprunt.FormattingEnabled = true;
            this.listEmprunt.ItemHeight = 16;
            this.listEmprunt.Location = new System.Drawing.Point(592, 14);
            this.listEmprunt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listEmprunt.Name = "listEmprunt";
            this.listEmprunt.Size = new System.Drawing.Size(639, 404);
            this.listEmprunt.TabIndex = 8;
            // 
            // ListeDisques
            // 
            this.ListeDisques.FormattingEnabled = true;
            this.ListeDisques.ItemHeight = 16;
            this.ListeDisques.Location = new System.Drawing.Point(15, 14);
            this.ListeDisques.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ListeDisques.Name = "ListeDisques";
            this.ListeDisques.Size = new System.Drawing.Size(523, 404);
            this.ListeDisques.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 464);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Recherche : ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(132, 460);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(405, 22);
            this.textBox1.TabIndex = 15;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // suivant
            // 
            this.suivant.Location = new System.Drawing.Point(425, 425);
            this.suivant.Margin = new System.Windows.Forms.Padding(4);
            this.suivant.Name = "suivant";
            this.suivant.Size = new System.Drawing.Size(113, 28);
            this.suivant.TabIndex = 16;
            this.suivant.Text = "Suivant";
            this.suivant.UseVisualStyleBackColor = true;
            // 
            // precedent
            // 
            this.precedent.Location = new System.Drawing.Point(16, 425);
            this.precedent.Margin = new System.Windows.Forms.Padding(4);
            this.precedent.Name = "precedent";
            this.precedent.Size = new System.Drawing.Size(113, 28);
            this.precedent.TabIndex = 17;
            this.precedent.Text = "Précédent";
            this.precedent.UseVisualStyleBackColor = true;
            // 
            // ProlAllEmprunt
            // 
            this.ProlAllEmprunt.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ProlAllEmprunt.Location = new System.Drawing.Point(791, 439);
            this.ProlAllEmprunt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ProlAllEmprunt.Name = "ProlAllEmprunt";
            this.ProlAllEmprunt.Size = new System.Drawing.Size(231, 28);
            this.ProlAllEmprunt.TabIndex = 18;
            this.ProlAllEmprunt.Text = "Prolonger Tout Emprunt";
            this.ProlAllEmprunt.UseVisualStyleBackColor = false;
            this.ProlAllEmprunt.Click += new System.EventHandler(this.ProlAllEmprunt_Click);
            // 
            // USER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1303, 554);
            this.Controls.Add(this.ProlAllEmprunt);
            this.Controls.Add(this.precedent);
            this.Controls.Add(this.suivant);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ListeDisques);
            this.Controls.Add(this.Prolongation);
            this.Controls.Add(this.retourne);
            this.Controls.Add(this.emprunt);
            this.Controls.Add(this.listEmprunt);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "USER";
            this.Text = "USER";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Prolongation;
        private System.Windows.Forms.Button retourne;
        private System.Windows.Forms.Button emprunt;
        private System.Windows.Forms.ListBox listEmprunt;
        private System.Windows.Forms.ListBox ListeDisques;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button suivant;
        private System.Windows.Forms.Button precedent;
        private System.Windows.Forms.Button ProlAllEmprunt;
    }
}