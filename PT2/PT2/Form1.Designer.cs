
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_nom = new System.Windows.Forms.TextBox();
            this.textBox_prenom = new System.Windows.Forms.TextBox();
            this.comboBoxPays = new System.Windows.Forms.ComboBox();
            this.textBox_login = new System.Windows.Forms.TextBox();
            this.textBox_mdp = new System.Windows.Forms.TextBox();
            this.textBox_cmdp = new System.Windows.Forms.TextBox();
            this.ajouter = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_mdpIn = new System.Windows.Forms.TextBox();
            this.textBox_loginIn = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.connexion = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            this.label4.Location = new System.Drawing.Point(38, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Login :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Mot de passe :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 352);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Confirmation Mot de passe :";
            // 
            // textBox_nom
            // 
            this.textBox_nom.Location = new System.Drawing.Point(182, 95);
            this.textBox_nom.Name = "textBox_nom";
            this.textBox_nom.Size = new System.Drawing.Size(195, 20);
            this.textBox_nom.TabIndex = 0;
            this.textBox_nom.TextChanged += new System.EventHandler(this.textBox_nom_TextChanged);
            // 
            // textBox_prenom
            // 
            this.textBox_prenom.Location = new System.Drawing.Point(182, 142);
            this.textBox_prenom.Name = "textBox_prenom";
            this.textBox_prenom.Size = new System.Drawing.Size(195, 20);
            this.textBox_prenom.TabIndex = 1;
            this.textBox_prenom.TextChanged += new System.EventHandler(this.textBox_prenom_TextChanged);
            // 
            // comboBoxPays
            // 
            this.comboBoxPays.FormattingEnabled = true;
            this.comboBoxPays.Location = new System.Drawing.Point(182, 191);
            this.comboBoxPays.Name = "comboBoxPays";
            this.comboBoxPays.Size = new System.Drawing.Size(195, 21);
            this.comboBoxPays.TabIndex = 2;
            this.comboBoxPays.SelectedIndexChanged += new System.EventHandler(this.comboBoxPays_SelectedIndexChanged);
            // 
            // textBox_login
            // 
            this.textBox_login.Location = new System.Drawing.Point(182, 251);
            this.textBox_login.Name = "textBox_login";
            this.textBox_login.Size = new System.Drawing.Size(195, 20);
            this.textBox_login.TabIndex = 3;
            this.textBox_login.TextChanged += new System.EventHandler(this.textBox_login_TextChanged);
            // 
            // textBox_mdp
            // 
            this.textBox_mdp.Location = new System.Drawing.Point(182, 300);
            this.textBox_mdp.Name = "textBox_mdp";
            this.textBox_mdp.PasswordChar = '*';
            this.textBox_mdp.Size = new System.Drawing.Size(195, 20);
            this.textBox_mdp.TabIndex = 4;
            this.textBox_mdp.TextChanged += new System.EventHandler(this.textBox_mdp_TextChanged);
            // 
            // textBox_cmdp
            // 
            this.textBox_cmdp.Location = new System.Drawing.Point(182, 349);
            this.textBox_cmdp.Name = "textBox_cmdp";
            this.textBox_cmdp.PasswordChar = '*';
            this.textBox_cmdp.Size = new System.Drawing.Size(195, 20);
            this.textBox_cmdp.TabIndex = 5;
            this.textBox_cmdp.TextChanged += new System.EventHandler(this.textBox_cmdp_TextChanged);
            // 
            // ajouter
            // 
            this.ajouter.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ajouter.Location = new System.Drawing.Point(182, 397);
            this.ajouter.Margin = new System.Windows.Forms.Padding(2);
            this.ajouter.Name = "ajouter";
            this.ajouter.Size = new System.Drawing.Size(70, 23);
            this.ajouter.TabIndex = 6;
            this.ajouter.Text = "Inscription";
            this.ajouter.UseVisualStyleBackColor = false;
            this.ajouter.Click += new System.EventHandler(this.ajouter_Click);
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
            this.textBox_mdpIn.PasswordChar = '*';
            this.textBox_mdpIn.Size = new System.Drawing.Size(195, 20);
            this.textBox_mdpIn.TabIndex = 8;
            this.textBox_mdpIn.TextChanged += new System.EventHandler(this.textBox_mdpIn_TextChanged);
            // 
            // textBox_loginIn
            // 
            this.textBox_loginIn.Location = new System.Drawing.Point(602, 138);
            this.textBox_loginIn.Name = "textBox_loginIn";
            this.textBox_loginIn.Size = new System.Drawing.Size(195, 20);
            this.textBox_loginIn.TabIndex = 7;
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
            this.connexion.TabIndex = 9;
            this.connexion.Text = "Connexion";
            this.connexion.UseVisualStyleBackColor = false;
            this.connexion.Click += new System.EventHandler(this.connexion_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(34, 194);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Pays :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 554);
            this.Controls.Add(this.comboBoxPays);
            this.Controls.Add(this.label10);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_nom;
        private System.Windows.Forms.TextBox textBox_prenom;
        private System.Windows.Forms.ComboBox comboBoxPays;
        private System.Windows.Forms.TextBox textBox_login;
        private System.Windows.Forms.TextBox textBox_mdp;
        private System.Windows.Forms.TextBox textBox_cmdp;
        private System.Windows.Forms.Button ajouter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_mdpIn;
        private System.Windows.Forms.TextBox textBox_loginIn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button connexion;
        private System.Windows.Forms.Label label10;
    }
}

