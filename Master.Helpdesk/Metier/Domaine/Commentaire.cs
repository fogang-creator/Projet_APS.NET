using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metier.Domaine
{
   public class Commentaire
    {
        public int CommentaireID { get; set; }
        public String Description { get; set; }
       // public Ticket Ticket { get; set; }
       //public int TicketID { get; set; }
        public Utilisateur Utilisateur { get; set; }

       //public int UtilisateurID { get; set; }
    }
}
