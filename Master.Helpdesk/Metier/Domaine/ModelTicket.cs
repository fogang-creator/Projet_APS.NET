using Metier.Domaine;
using System;
using System.Data.Entity;
using System.Linq;

namespace Metier
{
    public class ModelTicket : DbContext
    {
        // Votre contexte a été configuré pour utiliser une chaîne de connexion « ModelTicket » du fichier 
        // de configuration de votre application (App.config ou Web.config). Par défaut, cette chaîne de connexion cible 
        // la base de données « Metier.ModelTicket » sur votre instance LocalDb. 
        // 
        // Pour cibler une autre base de données et/ou un autre fournisseur de base de données, modifiez 
        // la chaîne de connexion « ModelTicket » dans le fichier de configuration de l'application.
        public ModelTicket()
            : base("name=ModelTicket")
        {
        }

        // Ajoutez un DbSet pour chaque type d'entité à inclure dans votre modèle. Pour plus d'informations 
        // sur la configuration et l'utilisation du modèle Code First, consultez http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Application> Applications { get; set; }
        public virtual DbSet<Ticket> Tickets { get; set; }
        public virtual DbSet<Historique> Historiques { get; set; }
        public virtual DbSet<Motif> Motifs { get; set; }
        public virtual DbSet<Niveau> Niveaus { get; set; }
        public virtual DbSet<PieceJointe> PieceJointes { get; set; }
        public virtual DbSet<Priorite> Priorites { get; set; }
        public virtual DbSet<Reponse> Reponses { get; set; }
        public virtual DbSet<Resolution> Resolutions { get; set; }
        public virtual DbSet<Statut> Statuts { get; set; }
        public virtual DbSet<TypeTicket> TypeTickets { get; set; }
        public virtual DbSet<Categorie> Categories { get; set; }
        public virtual DbSet<Utilisateur> Utilisateurs { get; set; }
        public virtual DbSet<Commentaire> Commentaires { get; set; }
        public virtual DbSet<Assistant> Assistants { get; set; }

        public System.Data.Entity.DbSet<Metier.Domaine.Personne> Personnes { get; set; }




        //public System.Data.Entity.DbSet<Metier.Domaine.Role> Roles { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}