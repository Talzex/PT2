﻿
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
            this.ajouter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_cmdp = new System.Windows.Forms.TextBox();
            this.textBox_nom = new System.Windows.Forms.TextBox();
            this.textBox_prenom = new System.Windows.Forms.TextBox();
            this.textBox_login = new System.Windows.Forms.TextBox();
            this.textBox_mdp = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_mdpIn = new System.Windows.Forms.TextBox();
            this.textBox_loginIn = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.connexion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ajouter
            // 
            this.ajouter.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ajouter.Location = new System.Drawing.Point(182, 335);
            this.ajouter.Margin = new System.Windows.Forms.Padding(2);
            this.ajouter.Name = "ajouter";
            this.ajouter.Size = new System.Drawing.Size(70, 23);
            this.ajouter.TabIndex = 3;
            this.ajouter.Text = "Inscription";
            this.ajouter.UseVisualStyleBackColor = false;
            this.ajouter.Click += new System.EventHandler(this.ajouter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(179, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Inscrivez-vous";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nom :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Prénom :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Login :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Mot de passe :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Confirmation Mot de passe :";
            // 
            // textBox_cmdp
            // 
            this.textBox_cmdp.Location = new System.Drawing.Point(182, 287);
            this.textBox_cmdp.Name = "textBox_cmdp";
            this.textBox_cmdp.Size = new System.Drawing.Size(195, 20);
            this.textBox_cmdp.TabIndex = 10;
            this.textBox_cmdp.TextChanged += new System.EventHandler(this.textBox_cmdp_TextChanged);
            // 
            // textBox_nom
            // 
            this.textBox_nom.Location = new System.Drawing.Point(182, 95);
            this.textBox_nom.Name = "textBox_nom";
            this.textBox_nom.Size = new System.Drawing.Size(195, 20);
            this.textBox_nom.TabIndex = 11;
            this.textBox_nom.TextChanged += new System.EventHandler(this.textBox_nom_TextChanged);
            // 
            // textBox_prenom
            // 
            this.textBox_prenom.Location = new System.Drawing.Point(182, 142);
            this.textBox_prenom.Name = "textBox_prenom";
            this.textBox_prenom.Size = new System.Drawing.Size(195, 20);
            this.textBox_prenom.TabIndex = 12;
            this.textBox_prenom.TextChanged += new System.EventHandler(this.textBox_prenom_TextChanged);
            // 
            // textBox_login
            // 
            this.textBox_login.Location = new System.Drawing.Point(182, 189);
            this.textBox_login.Name = "textBox_login";
            this.textBox_login.Size = new System.Drawing.Size(195, 20);
            this.textBox_login.TabIndex = 13;
            this.textBox_login.TextChanged += new System.EventHandler(this.textBox_login_TextChanged);
            // 
            // textBox_mdp
            // 
            this.textBox_mdp.Location = new System.Drawing.Point(182, 238);
            this.textBox_mdp.Name = "textBox_mdp";
            this.textBox_mdp.Size = new System.Drawing.Size(195, 20);
            this.textBox_mdp.TabIndex = 14;
            this.textBox_mdp.TextChanged += new System.EventHandler(this.textBox_mdp_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(582, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Connectez-vous";
            // 
            // textBox_mdpIn
            // 
            this.textBox_mdpIn.Location = new System.Drawing.Point(602, 191);
            this.textBox_mdpIn.Name = "textBox_mdpIn";
            this.textBox_mdpIn.Size = new System.Drawing.Size(195, 20);
            this.textBox_mdpIn.TabIndex = 19;
            this.textBox_mdpIn.TextChanged += new System.EventHandler(this.textBox_mdpIn_TextChanged);
            // 
            // textBox_loginIn
            // 
            this.textBox_loginIn.Location = new System.Drawing.Point(602, 138);
            this.textBox_loginIn.Name = "textBox_loginIn";
            this.textBox_loginIn.Size = new System.Drawing.Size(195, 20);
            this.textBox_loginIn.TabIndex = 18;
            this.textBox_loginIn.TextChanged += new System.EventHandler(this.textBox_loginIn_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(519, 194);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Mot de passe :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(519, 145);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Login :";
            // 
            // connexion
            // 
            this.connexion.BackColor = System.Drawing.SystemColors.MenuBar;
            this.connexion.Location = new System.Drawing.Point(585, 335);
            this.connexion.Margin = new System.Windows.Forms.Padding(2);
            this.connexion.Name = "connexion";
            this.connexion.Size = new System.Drawing.Size(70, 23);
            this.connexion.TabIndex = 20;
            this.connexion.Text = "Connexion";
            this.connexion.UseVisualStyleBackColor = false;
            this.connexion.Click += new System.EventHandler(this.connexion_Click);
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
            // listSuggestions
            // 
            this.listSuggestions.Location = new System.Drawing.Point(740, 99);
            this.listSuggestions.Name = "listSuggestions";
            this.listSuggestions.Size = new System.Drawing.Size(711, 316);
            this.listSuggestions.TabIndex = 12;
            // 
            // sug
            // 
            this.sug.Location = new System.Drawing.Point(910, 458);
            this.sug.Name = "sug";
            this.sug.Size = new System.Drawing.Size(75, 23);
            this.sug.TabIndex = 13;
            this.sug.Text = "Suggestions";
            this.sug.UseVisualStyleBackColor = true;
            this.sug.Click += new System.EventHandler(this.sug_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(47, 99);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ListAbo
            // 
            this.ListAbo.FormattingEnabled = true;
            this.ListAbo.Location = new System.Drawing.Point(27, 143);
            this.ListAbo.Name = "ListAbo";
            this.ListAbo.Size = new System.Drawing.Size(120, 95);
            this.ListAbo.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 554);
            this.Controls.Add(this.connexion);
            this.Controls.Add(this.textBox_mdpIn);
            this.Controls.Add(this.textBox_loginIn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox_mdp);
            this.Controls.Add(this.textBox_login);
            this.Controls.Add(this.textBox_prenom);
            this.Controls.Add(this.textBox_nom);
            this.Controls.Add(this.textBox_cmdp);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ajouter);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ajouter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_cmdp;
        private System.Windows.Forms.TextBox textBox_nom;
        private System.Windows.Forms.TextBox textBox_prenom;
        private System.Windows.Forms.TextBox textBox_login;
        private System.Windows.Forms.TextBox textBox_mdp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_mdpIn;
        private System.Windows.Forms.TextBox textBox_loginIn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button connexion;
    }
}

