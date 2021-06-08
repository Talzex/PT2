
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
            this.listPurge = new System.Windows.Forms.ListBox();
            this.ConsulEmpProlongé = new System.Windows.Forms.Button();
            this.RefreshRetards = new System.Windows.Forms.Button();
            this.listProlongement = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Purgeur
            // 
            this.Purgeur.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Purgeur.Location = new System.Drawing.Point(334, 291);
            this.Purgeur.Name = "Purgeur";
            this.Purgeur.Size = new System.Drawing.Size(112, 23);
            this.Purgeur.TabIndex = 15;
            this.Purgeur.Text = "Purgeur";
            this.Purgeur.UseVisualStyleBackColor = false;
            // 
            // listPurge
            // 
            this.listPurge.FormattingEnabled = true;
            this.listPurge.Location = new System.Drawing.Point(141, 217);
            this.listPurge.Margin = new System.Windows.Forms.Padding(2);
            this.listPurge.Name = "listPurge";
            this.listPurge.Size = new System.Drawing.Size(483, 69);
            this.listPurge.TabIndex = 14;
            // 
            // ConsulEmpProlongé
            // 
            this.ConsulEmpProlongé.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ConsulEmpProlongé.Location = new System.Drawing.Point(216, 159);
            this.ConsulEmpProlongé.Margin = new System.Windows.Forms.Padding(2);
            this.ConsulEmpProlongé.Name = "ConsulEmpProlongé";
            this.ConsulEmpProlongé.Size = new System.Drawing.Size(145, 23);
            this.ConsulEmpProlongé.TabIndex = 12;
            this.ConsulEmpProlongé.Text = "ConsulEmpruntProlongé";
            this.ConsulEmpProlongé.UseVisualStyleBackColor = false;
            // 
            // RefreshRetards
            // 
            this.RefreshRetards.BackColor = System.Drawing.SystemColors.MenuBar;
            this.RefreshRetards.Location = new System.Drawing.Point(444, 160);
            this.RefreshRetards.Name = "RefreshRetards";
            this.RefreshRetards.Size = new System.Drawing.Size(112, 23);
            this.RefreshRetards.TabIndex = 13;
            this.RefreshRetards.Text = "Actualiser Retards";
            this.RefreshRetards.UseVisualStyleBackColor = false;
            // 
            // listProlongement
            // 
            this.listProlongement.FormattingEnabled = true;
            this.listProlongement.Location = new System.Drawing.Point(141, 86);
            this.listProlongement.Margin = new System.Windows.Forms.Padding(2);
            this.listProlongement.Name = "listProlongement";
            this.listProlongement.Size = new System.Drawing.Size(483, 69);
            this.listProlongement.TabIndex = 11;
            // 
            // Administrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Purgeur);
            this.Controls.Add(this.listPurge);
            this.Controls.Add(this.ConsulEmpProlongé);
            this.Controls.Add(this.RefreshRetards);
            this.Controls.Add(this.listProlongement);
            this.Name = "Administrator";
            this.Text = "Administrator";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Purgeur;
        private System.Windows.Forms.ListBox listPurge;
        private System.Windows.Forms.Button ConsulEmpProlongé;
        private System.Windows.Forms.Button RefreshRetards;
        private System.Windows.Forms.ListBox listProlongement;
    }
}