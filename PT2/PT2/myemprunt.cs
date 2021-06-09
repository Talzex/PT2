using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
