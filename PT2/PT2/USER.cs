using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PT2
{
    public partial class USER : Form
    {
        MusiquePT2_MEntities musique;
        ABONNÉS abonne;
        OpUSER opu;
        int indexSelected;
        int min;
        int max;
        public USER(int code)
        {
            InitializeComponent();
            musique = new MusiquePT2_MEntities();
            var a = from j in musique.ABONNÉS
                    where j.CODE_ABONNÉ == code
                    select j;
            this.abonne = a.First();
            opu = new OpUSER(musique);
            chargerGridDisques();
        }

        private void chargerGridDisques()
        {
            GridDisques.ColumnHeadersDefaultCellStyle.BackColor = Color.Cyan;
            String estEmprunté;
            var disques = (from j in musique.ALBUMS
                           select j).ToList();
            var emprunt = (from j in musique.EMPRUNTER
                           where j.CODE_ABONNÉ == abonne.CODE_ABONNÉ
                           select j).ToList();
            GridDisques.Rows.Clear();
            foreach (EMPRUNTER j in emprunt)
            {
                estEmprunté = "non";
                String prolongé = "non";
                if (j.DATE_RETOUR == null)
                {
                    estEmprunté = "oui";
                }
                if (opu.Prolonge(j))
                {
                    prolongé = "oui";
                }

                int i = GridDisques.Rows.Add(j.ALBUMS.TITRE_ALBUM, j.ALBUMS.GENRES.LIBELLÉ_GENRE, j.ALBUMS.EDITEURS.NOM_EDITEUR, estEmprunté, prolongé, j.DATE_EMPRUNT, j.DATE_RETOUR_ATTENDUE, j.DATE_RETOUR);
                GridDisques.Rows[i].DefaultCellStyle.BackColor = Color.Cyan;
            }
            foreach (ALBUMS a in disques)
            {
                estEmprunté = "non";
                bool emprunté = false;
                foreach (EMPRUNTER emp in emprunt)
                {
                    if (a.EMPRUNTER.Contains(emp))
                    {
                        emprunté = true;
                        estEmprunté = "oui, par un autre abonné";
                    }
                }
                if (!emprunté)
                {
                    int i = GridDisques.Rows.Add(a.TITRE_ALBUM, a.GENRES.LIBELLÉ_GENRE, a.EDITEURS.NOM_EDITEUR, estEmprunté);
                    GridDisques.Rows[i].DefaultCellStyle.BackColor = Color.Cyan;
                }
            }
        }

        private void retourne_Click(object sender, EventArgs e)
        {
            if (GridDisques.Rows[indexSelected] != null)
            {
                EMPRUNTER emprunt = null;
                var emprunts = (from j in musique.EMPRUNTER
                                orderby j.DATE_EMPRUNT ascending
                                select j).ToList();
                String titremprunt = (String)GridDisques.Rows[indexSelected].Cells[0].Value;
                foreach (EMPRUNTER emp in emprunts)
                {
                    if (emp.ALBUMS.TITRE_ALBUM.Equals(titremprunt) && emp.DATE_RETOUR == null)
                    {
                        emprunt = emp;
                    }
                }
                if (emprunt != null)
                {
                    opu.retourner(emprunt);
                    chargerGridDisques();
                }
                else
                {
                    MessageBox.Show("erreur : cette albums ne fait pas partie de vos emprunts");
                }
            }
        }

        private void emprunt_Click(object sender, EventArgs e)
        {
            if (GridDisques.Rows[indexSelected] != null)
            {
                String titreAlbum = (String)GridDisques.Rows[indexSelected].Cells[0].Value;
                var album = (from j in musique.ALBUMS
                             where j.TITRE_ALBUM == titreAlbum
                             select j);
                ALBUMS a = album.FirstOrDefault();
                bool emprunté = opu.emprunte(a, abonne);
                if (emprunté)
                {
                    MessageBox.Show("erreur : vous avez déjà emprunté ce disque");
                }
                else
                {
                    MessageBox.Show("disque emprunté");
                    chargerGridDisques();
                }
            }
        }

        private void Prolongation_Click(object sender, EventArgs e)
        {
            EMPRUNTER albumsEmprunte = null;
            var emprunt = (from j in musique.EMPRUNTER
                           where j.CODE_ABONNÉ == abonne.CODE_ABONNÉ
                           where j.DATE_RETOUR == null
                           orderby j.DATE_EMPRUNT ascending
                           select j).ToList();
            if (GridDisques.Rows[indexSelected] != null)
            {
                String titreAlbumsEmprunte = (String)GridDisques.Rows[indexSelected].Cells[0].Value;
                foreach (EMPRUNTER emp in emprunt)
                {
                    if (emp.ALBUMS.TITRE_ALBUM.Equals(titreAlbumsEmprunte))
                    {
                        albumsEmprunte = emp;
                    }
                }
                if (albumsEmprunte != null)
                {
                    bool prolongé = opu.prolongation(albumsEmprunte);
                    if (prolongé)
                    {
                        MessageBox.Show("Emprunt prolongé");
                        chargerGridDisques();
                    }
                    else
                    {
                        MessageBox.Show("Emprunt déjà prolongé");
                    }
                }
                else
                {
                    MessageBox.Show("erreur : Prolongation impossible : emprunt introuvable");
                }
            }
            else
            {
                MessageBox.Show("erreur : Prolongation Impossible : aucun album sélectionné");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            GridDisques.Rows.Clear();
            if (textBox1.Text != "")
            {
                foreach (ALBUMS al in opu.RechercheAlbum(textBox1.Text))
                {
                    GridDisques.Rows.Add(al);
                }
            }
            else
            {
                chargerGridDisques();
            }

        }

        private void ProlAllEmprunt_Click(object sender, EventArgs e)
        {
            opu.prolongationAll();
            chargerGridDisques();
        }

        private void Suggestions_Click(object sender, EventArgs e)
        {
            GridDisques.Rows.Clear();
            List<ALBUMS> suggestions = opu.Suggestions(abonne);
            if (suggestions.Count() != 0)
            {
                foreach (ALBUMS a in suggestions)
                {
                    GridDisques.Rows.Add(a.TITRE_ALBUM, a.GENRES.LIBELLÉ_GENRE, a.EDITEURS.NOM_EDITEUR);
                }
            }
            else
            {
                GridDisques.Rows.Add("Aucune suggestion disponible : aucun disque n'a été emprunté");
            }
        }

        private void GridDisques_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            indexSelected = e.RowIndex;
        }

    }
}
