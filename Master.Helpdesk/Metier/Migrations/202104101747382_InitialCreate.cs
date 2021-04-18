namespace Metier.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Tickets", name: "Application_ApplicationID", newName: "Applications_ApplicationID");
            RenameColumn(table: "dbo.Tickets", name: "Categorie_CategorieID", newName: "Categories_CategorieID");
            RenameColumn(table: "dbo.Tickets", name: "Motif_motifID", newName: "Motifs_motifID");
            RenameColumn(table: "dbo.Tickets", name: "Priorite_PrioriteID", newName: "Priorites_PrioriteID");
            RenameColumn(table: "dbo.Tickets", name: "Statut_StatutID", newName: "Statuts_StatutID");
            RenameColumn(table: "dbo.Tickets", name: "TypeTicket_TypeTicketID", newName: "TypeTickets_TypeTicketID");
            RenameIndex(table: "dbo.Tickets", name: "IX_Application_ApplicationID", newName: "IX_Applications_ApplicationID");
            RenameIndex(table: "dbo.Tickets", name: "IX_Categorie_CategorieID", newName: "IX_Categories_CategorieID");
            RenameIndex(table: "dbo.Tickets", name: "IX_Motif_motifID", newName: "IX_Motifs_motifID");
            RenameIndex(table: "dbo.Tickets", name: "IX_Priorite_PrioriteID", newName: "IX_Priorites_PrioriteID");
            RenameIndex(table: "dbo.Tickets", name: "IX_Statut_StatutID", newName: "IX_Statuts_StatutID");
            RenameIndex(table: "dbo.Tickets", name: "IX_TypeTicket_TypeTicketID", newName: "IX_TypeTickets_TypeTicketID");
            AddColumn("dbo.Tickets", "Statut", c => c.String());
            AddColumn("dbo.Tickets", "Priorite", c => c.String());
            AddColumn("dbo.Tickets", "Motif", c => c.String());
            AddColumn("dbo.Tickets", "Categorie", c => c.String());
            AddColumn("dbo.Tickets", "Application", c => c.String());
            AddColumn("dbo.Tickets", "TypeTicket", c => c.String());
            DropColumn("dbo.Tickets", "Statuts");
            DropColumn("dbo.Tickets", "Priorites");
            DropColumn("dbo.Tickets", "Motifs");
            DropColumn("dbo.Tickets", "Categories");
            DropColumn("dbo.Tickets", "Resolution");
            DropColumn("dbo.Tickets", "Applications");
            DropColumn("dbo.Tickets", "TypeTickets");
            DropColumn("dbo.Tickets", "Temps");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Tickets", "Temps", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Tickets", "TypeTickets", c => c.String());
            AddColumn("dbo.Tickets", "Applications", c => c.String());
            AddColumn("dbo.Tickets", "Resolution", c => c.String());
            AddColumn("dbo.Tickets", "Categories", c => c.String());
            AddColumn("dbo.Tickets", "Motifs", c => c.String());
            AddColumn("dbo.Tickets", "Priorites", c => c.String());
            AddColumn("dbo.Tickets", "Statuts", c => c.String());
            DropColumn("dbo.Tickets", "TypeTicket");
            DropColumn("dbo.Tickets", "Application");
            DropColumn("dbo.Tickets", "Categorie");
            DropColumn("dbo.Tickets", "Motif");
            DropColumn("dbo.Tickets", "Priorite");
            DropColumn("dbo.Tickets", "Statut");
            RenameIndex(table: "dbo.Tickets", name: "IX_TypeTickets_TypeTicketID", newName: "IX_TypeTicket_TypeTicketID");
            RenameIndex(table: "dbo.Tickets", name: "IX_Statuts_StatutID", newName: "IX_Statut_StatutID");
            RenameIndex(table: "dbo.Tickets", name: "IX_Priorites_PrioriteID", newName: "IX_Priorite_PrioriteID");
            RenameIndex(table: "dbo.Tickets", name: "IX_Motifs_motifID", newName: "IX_Motif_motifID");
            RenameIndex(table: "dbo.Tickets", name: "IX_Categories_CategorieID", newName: "IX_Categorie_CategorieID");
            RenameIndex(table: "dbo.Tickets", name: "IX_Applications_ApplicationID", newName: "IX_Application_ApplicationID");
            RenameColumn(table: "dbo.Tickets", name: "TypeTickets_TypeTicketID", newName: "TypeTicket_TypeTicketID");
            RenameColumn(table: "dbo.Tickets", name: "Statuts_StatutID", newName: "Statut_StatutID");
            RenameColumn(table: "dbo.Tickets", name: "Priorites_PrioriteID", newName: "Priorite_PrioriteID");
            RenameColumn(table: "dbo.Tickets", name: "Motifs_motifID", newName: "Motif_motifID");
            RenameColumn(table: "dbo.Tickets", name: "Categories_CategorieID", newName: "Categorie_CategorieID");
            RenameColumn(table: "dbo.Tickets", name: "Applications_ApplicationID", newName: "Application_ApplicationID");
        }
    }
}
