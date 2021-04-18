using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metier.Domaine
{
    /// <summary>
    /// CLASS METIER
    /// </summary>
    public class Assistant
    {
        #region attribut
        public int AssistantID { get; set; }
        public string Matricule { get; set; }
        public string NiveauEscale { get; set; }

        //public int RoleID { get; set; }
        public Role Role { get; set; }

        //public int PersonneID { get; set; }
        public Personne Personne  { get; set; }

        public string Service { get; set; }



        #endregion


        /// <summary>
        /// CONSTRUCTEUR
        /// </summary>
       


    }

}
