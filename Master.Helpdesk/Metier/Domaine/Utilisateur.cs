using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metier.Domaine
{
   public  class Utilisateur
    {

        public int UtilisateurID { get; set; }
        public string Libelle { get; set; }
        public Profil Profil { get; set; }
       //public int ProfilID { get; set; }
        //public int PersonneID { get; set; }
        public Personne Personne { get; set; }
      
    }
}
