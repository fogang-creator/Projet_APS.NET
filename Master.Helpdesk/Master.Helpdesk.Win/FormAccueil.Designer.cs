
namespace Master.Helpdesk.Win
{
    partial class FormAccueil
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.propriétésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sauvegarderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exporterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.configurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.applicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.collaborateurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assistantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.envoyerUnMessageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siteInternetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.astuceDuJourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.astuceDuJourToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.créerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.timerDateHeure = new System.Windows.Forms.Timer(this.components);
            this.utilisateursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.statusStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.configurationToolStripMenuItem,
            this.versionToolStripMenuItem,
            this.toolStripMenuItem3,
            this.toolStripMenuItem2});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(896, 33);
            this.menuStrip2.TabIndex = 0;
            this.menuStrip2.Text = "menuStrip2";
            this.menuStrip2.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip2_ItemClicked);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.propriétésToolStripMenuItem,
            this.sauvegarderToolStripMenuItem,
            this.exporterToolStripMenuItem,
            this.toolStripMenuItem5});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(83, 29);
            this.toolStripMenuItem1.Text = "Fichier ";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // propriétésToolStripMenuItem
            // 
            this.propriétésToolStripMenuItem.Name = "propriétésToolStripMenuItem";
            this.propriétésToolStripMenuItem.Size = new System.Drawing.Size(273, 34);
            this.propriétésToolStripMenuItem.Text = "&Propriétés";
            // 
            // sauvegarderToolStripMenuItem
            // 
            this.sauvegarderToolStripMenuItem.Name = "sauvegarderToolStripMenuItem";
            this.sauvegarderToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.sauvegarderToolStripMenuItem.Size = new System.Drawing.Size(273, 34);
            this.sauvegarderToolStripMenuItem.Text = " &Sauvegarde";
            this.sauvegarderToolStripMenuItem.Click += new System.EventHandler(this.sauvegarderToolStripMenuItem_Click);
            // 
            // exporterToolStripMenuItem
            // 
            this.exporterToolStripMenuItem.Name = "exporterToolStripMenuItem";
            this.exporterToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.exporterToolStripMenuItem.Size = new System.Drawing.Size(273, 34);
            this.exporterToolStripMenuItem.Text = "&Exporter";
            this.exporterToolStripMenuItem.Click += new System.EventHandler(this.GestionCentralisee);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.toolStripMenuItem5.Size = new System.Drawing.Size(273, 34);
            this.toolStripMenuItem5.Text = "&Quitter";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // configurationToolStripMenuItem
            // 
            this.configurationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.applicationToolStripMenuItem,
            this.collaborateurToolStripMenuItem,
            this.assistantToolStripMenuItem,
            this.utilisateursToolStripMenuItem});
            this.configurationToolStripMenuItem.Name = "configurationToolStripMenuItem";
            this.configurationToolStripMenuItem.Size = new System.Drawing.Size(137, 29);
            this.configurationToolStripMenuItem.Text = "Configuration";
            this.configurationToolStripMenuItem.Click += new System.EventHandler(this.configurationToolStripMenuItem_Click);
            // 
            // applicationToolStripMenuItem
            // 
            this.applicationToolStripMenuItem.Name = "applicationToolStripMenuItem";
            this.applicationToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.applicationToolStripMenuItem.Text = "&Applications";
            this.applicationToolStripMenuItem.Click += new System.EventHandler(this.GestionCentralisee);
            // 
            // collaborateurToolStripMenuItem
            // 
            this.collaborateurToolStripMenuItem.Name = "collaborateurToolStripMenuItem";
            this.collaborateurToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.collaborateurToolStripMenuItem.Text = "&Collaborateurs";
            this.collaborateurToolStripMenuItem.Click += new System.EventHandler(this.GestionCentralisee);
            // 
            // assistantToolStripMenuItem
            // 
            this.assistantToolStripMenuItem.Name = "assistantToolStripMenuItem";
            this.assistantToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.assistantToolStripMenuItem.Text = "&Assistants";
            this.assistantToolStripMenuItem.Click += new System.EventHandler(this.GestionCentralisee);
            // 
            // versionToolStripMenuItem
            // 
            this.versionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.versionToolStripMenuItem.Name = "versionToolStripMenuItem";
            this.versionToolStripMenuItem.Size = new System.Drawing.Size(74, 29);
            this.versionToolStripMenuItem.Text = "Outils";
            this.versionToolStripMenuItem.Click += new System.EventHandler(this.versionToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(190, 34);
            this.optionsToolStripMenuItem.Text = "&Options...";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.envoyerUnMessageToolStripMenuItem,
            this.siteInternetToolStripMenuItem,
            this.astuceDuJourToolStripMenuItem,
            this.astuceDuJourToolStripMenuItem1});
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(64, 29);
            this.toolStripMenuItem3.Text = "Aide";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // envoyerUnMessageToolStripMenuItem
            // 
            this.envoyerUnMessageToolStripMenuItem.Name = "envoyerUnMessageToolStripMenuItem";
            this.envoyerUnMessageToolStripMenuItem.Size = new System.Drawing.Size(277, 34);
            this.envoyerUnMessageToolStripMenuItem.Text = "Envoyer un message";
            // 
            // siteInternetToolStripMenuItem
            // 
            this.siteInternetToolStripMenuItem.Name = "siteInternetToolStripMenuItem";
            this.siteInternetToolStripMenuItem.Size = new System.Drawing.Size(277, 34);
            this.siteInternetToolStripMenuItem.Text = "Site internet";
            // 
            // astuceDuJourToolStripMenuItem
            // 
            this.astuceDuJourToolStripMenuItem.Name = "astuceDuJourToolStripMenuItem";
            this.astuceDuJourToolStripMenuItem.Size = new System.Drawing.Size(277, 34);
            this.astuceDuJourToolStripMenuItem.Text = "Astuce du jour";
            // 
            // astuceDuJourToolStripMenuItem1
            // 
            this.astuceDuJourToolStripMenuItem1.Name = "astuceDuJourToolStripMenuItem1";
            this.astuceDuJourToolStripMenuItem1.Size = new System.Drawing.Size(277, 34);
            this.astuceDuJourToolStripMenuItem1.Text = "Astuce du jour...";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.créerToolStripMenuItem,
            this.listeToolStripMenuItem});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(81, 29);
            this.toolStripMenuItem2.Text = "Tickets";
            // 
            // créerToolStripMenuItem
            // 
            this.créerToolStripMenuItem.Name = "créerToolStripMenuItem";
            this.créerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.créerToolStripMenuItem.Size = new System.Drawing.Size(219, 34);
            this.créerToolStripMenuItem.Text = "&Créer";
            // 
            // listeToolStripMenuItem
            // 
            this.listeToolStripMenuItem.Name = "listeToolStripMenuItem";
            this.listeToolStripMenuItem.Size = new System.Drawing.Size(219, 34);
            this.listeToolStripMenuItem.Text = "Liste";
            this.listeToolStripMenuItem.Click += new System.EventHandler(this.listeToolStripMenuItem_Click);
            // 
            // statusStrip2
            // 
            this.statusStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4,
            this.toolStripProgressBar1});
            this.statusStrip2.Location = new System.Drawing.Point(0, 393);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Size = new System.Drawing.Size(896, 32);
            this.statusStrip2.TabIndex = 1;
            this.statusStrip2.Text = "statusStrip2";
            this.statusStrip2.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip2_ItemClicked);
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(179, 25);
            this.toolStripStatusLabel3.Text = "toolStripStatusLabel3";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(179, 25);
            this.toolStripStatusLabel4.Text = "toolStripStatusLabel4";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 24);
            // 
            // timerDateHeure
            // 
            this.timerDateHeure.Enabled = true;
            this.timerDateHeure.Interval = 1000;
            this.timerDateHeure.Tick += new System.EventHandler(this.timerDateHeure_Tick);
            // 
            // utilisateursToolStripMenuItem
            // 
            this.utilisateursToolStripMenuItem.Name = "utilisateursToolStripMenuItem";
            this.utilisateursToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.utilisateursToolStripMenuItem.Text = "&Utilisateurs";
            this.utilisateursToolStripMenuItem.DropDownOpening += new System.EventHandler(this.utilisateursToolStripMenuItem_DropDownOpening);
            this.utilisateursToolStripMenuItem.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // FormAccueil
            // 
            this.ClientSize = new System.Drawing.Size(896, 425);
            this.Controls.Add(this.statusStrip2);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip2;
            this.Name = "FormAccueil";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.statusStrip2.ResumeLayout(false);
            this.statusStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sauvegardeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ticketsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem congigurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aideToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sauvegarderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem configurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem versionToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripMenuItem listeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem propriétésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exporterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem applicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem collaborateurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assistantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem créerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem envoyerUnMessageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem siteInternetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem astuceDuJourToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem astuceDuJourToolStripMenuItem1;
        private System.Windows.Forms.Timer timerDateHeure;
        private System.Windows.Forms.ToolStripMenuItem utilisateursToolStripMenuItem;
    }
}

