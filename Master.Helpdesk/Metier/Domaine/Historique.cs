using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metier.Domaine
{
    public class Historique
    {

        public Assistant Assistant { get; set; }
     
        public int HistoriqueID { get; set; }

        public int AssistantID { get; set; }

        public String Libelle { get; set; }
       
        //public int PieceJointeID { get; set; }
        public PieceJointe PieceJointe { get; set; }

       // public int PrioriteID { get; set; }
        public Priorite Priorite { get; set; }

       // public int ResolutionID { get; set; }
        public Resolution Resolution { get; set; }
        //public int StatutID { get; set; }
        public Statut Statut { get; set; }

      

        //public int UtilisateurID { get; set; }
        public Utilisateur Utilisateur { get; set; }

    }
}
