//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PT2
{
    using System;
    using System.Collections.Generic;
    
    public partial class EMPRUNTER
    {
        public int CODE_ABONNÉ { get; set; }
        public int CODE_ALBUM { get; set; }
        public System.DateTime DATE_EMPRUNT { get; set; }
        public System.DateTime DATE_RETOUR_ATTENDUE { get; set; }
        public Nullable<System.DateTime> DATE_RETOUR { get; set; }
        public Boolean PROLONGE { get; set; }
    
        public virtual ABONNÉS ABONNÉS { get; set; }
        public virtual ALBUMS ALBUMS { get; set; }
    }
}

