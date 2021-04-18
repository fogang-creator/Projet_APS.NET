#region MyRegion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
#endregion

namespace Metier.Domaine
{

    
    public class Ticket
    {

        public int TicketID { get; set; }

        public string Libelle { get; set; }

        //public string Description { get; set; }
        //public string EstActif { get; set; }

        public Statut Statuts { get; set; }

        public String Statut { get; set; }

        public Priorite Priorites { get; set; }

        public String Priorite { get; set; }

        public Motif Motifs { get; set; }

        public String Motif { get; set; }

        public Categorie Categories { get; set; }
        public String Categorie { get; set; }
        public Application Applications { get; set; }

        //public String Resolution { get; set; }

        public String Application { get; set; }

        public String TypeTicket { get; set; }

        public TypeTicket TypeTickets { get; set; }

        public DateTime DateCreation { get; set; }

        public DateTime DateResolution { get; set; }


        //public decimal Temps { get; set; }

       /* public decimal TempsJours
        {
            get { return this.Temps / 6; }
        }
*/
        //public Assistant Assistant { get; set; }


        //public Commentaire Commentaire { get; set; }


        //public Resolution Resolution { get; set; }

        //public Reponse Reponse { get; set; }


        //public PieceJointe PieceJointe { get; set; }


        //public Niveau Niveau { get; set; }


        //public string Description { get; set; }


        //public DateTime DateModification { get; set; }
        //public DateTime DateResolution { get; set; }




        //public Historique  Historique { get; set; }



        //public Utilisateur Utilisateur { get; set; }





    }

}
