namespace PT2
{
    public partial class EMPRUNTER
    {
        public override string ToString()
        {
            return  ALBUMS.TITRE_ALBUM + "   " + DATE_EMPRUNT.ToString().PadRight(50) +  "    " + DATE_RETOUR_ATTENDUE.ToString().PadRight(50) + "   " + DATE_RETOUR;
        }
    }
}
