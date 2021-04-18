using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metier.Domaine
{
   public class Personne
    {

        public int PersonneID { get; set; }
        
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Email { get; set; }
        public string MotPasse { get; set; }
        public string information { get; set; }
        public string Telephone { get; set; }
    }
}
