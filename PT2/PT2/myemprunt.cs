﻿using System;
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
            return  ALBUMS.TITRE_ALBUM.Trim() + "    " + DATE_EMPRUNT +  "    " + DATE_RETOUR_ATTENDUE + "    " + DATE_RETOUR;
        }

        
    }
}
