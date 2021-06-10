using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PT2
{
    public partial class USER : Form
    {
        MusiquePT2_MEntities musique;
        ABONNÉS abonne;
        OpUSER opu;
        int indexSelected;
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
            var disques = (from j in musique.ALBUMS
                           select j).ToList();
            var emprunt = (from j in musique.EMPRUNTER
                           where j.CODE_ABONNÉ == abonne.CODE_ABONNÉ
                           /*where j.DATE_RETOUR == null
                           orderby j.DATE_EMPRUNT ascending*/
                           select j).ToList();
            /*var rendu = (from j in musique.EMPRUNTER
                           where j.CODE_ABONNÉ == abonne.CODE_ABONNÉ
                           where j.DATE_RETOUR != null
                           orderby j.DATE_EMPRUNT ascending
                           select j).ToList();*/
            GridDisques.Rows.Clear();
            foreach (EMPRUNTER j in emprunt)
            {
                bool emprunté = false;
                bool prolongé = false;
                if (j.DATE_RETOUR == null)
                {
                    emprunté = true;
                }
                if (opu.Prolonge(j))
                {
                    prolongé = true;
                }

                GridDisques.Rows.Add(j.ALBUMS.TITRE_ALBUM, j.ALBUMS.GENRES.LIBELLÉ_GENRE, j.ALBUMS.EDITEURS.NOM_EDITEUR , emprunté, prolongé, j.DATE_EMPRUNT, j.DATE_RETOUR_ATTENDUE, j.DATE_RETOUR);
            }
            foreach (ALBUMS a in disques)
            {
                bool emprunté = false;
                foreach (EMPRUNTER emp in emprunt)
                {
                    if (a.EMPRUNTER.Contains(emp))
                    {
                        emprunté = true;
                    }
                }
                if (!emprunté)
                {
                    GridDisques.Rows.Add(a.TITRE_ALBUM, a.GENRES.LIBELLÉ_GENRE, a.EDITEURS.NOM_EDITEUR, emprunté);
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
                bool emprunté = opu.emprunte(a,abonne);
                if (emprunté)
                {
                    MessageBox.Show("erreur : vous avez déjà emprunté ce disque");
                }
                else
                {
                    MessageBox.Show("disque emprunté");
                }
                chargerGridDisques();
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
                    opu.prolongation(albumsEmprunte);
                    chargerGridDisques();
                }
                else
                {
                    MessageBox.Show("erreur : Prolongation impossible");
                }
            }
            else
            {
                MessageBox.Show("Prolongation Impossible");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
   
            GridDisques.Rows.Clear();
            if(textBox1.Text != "")
            {
                foreach (ALBUMS al in opu.RechercheAlbum(textBox1.Text))
                {
                    GridDisques.Rows.Add(al);
                }
            } else
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
