#region MyRegion
using Metier.Domaine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion

namespace Metier
{
    public class Service
    {
        #region attribut
        private List<Statut> statuts;
        #endregion




        #region Initialisation
        public void Initialisations()
        {


            this.statuts = new List<Statut>
             {


            new Statut { StatutID = 10, Libelle = "Nouveau" },
            new Statut { StatutID = 20, Libelle = "Ouvert" },
            new Statut { StatutID = 30, Libelle = "En cours" },
            new Statut { StatutID = 40, Libelle = "En attente" },
            new Statut { StatutID = 50, Libelle = "Résolut" },
            new Statut { StatutID = 60, Libelle = "Fermé" },

             };

        } 
        #endregion



    }



}

 

