using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Master.Helpdesk.Win
{
    public partial class FormAccueil : Form
    {
        public FormAccueil()
        {
            InitializeComponent();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void sauvegarderToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            
        }

        private void versionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Version 1.0", "Information", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void statusStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void listeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormListeTicket frm = new FormListeTicket();
            frm.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormUtilisateurs fu = new FormUtilisateurs();
            fu.Show();
        }

       
     

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void GestionCentralisee(object sender, EventArgs e)
        {
            // Recherche du type



            string nom = "";



            if (sender is ToolStripMenuItem)
                nom = ((ToolStripMenuItem)sender).Name;



            // TODO : idem pour bouton etc;



            //action selon composant;



            switch (nom)
            {

                case "utilisateurToolStripMenuItem":

                    FormUtilisateurs fu = new FormUtilisateurs();
                    fu.Show();
                    break;
                case "exporterToolStripMenuItem":
                    MessageBox.Show("exporter ici ");
                    break;

                case "applicationToolStripMenuItem":
                    MessageBox.Show("application s'affiche ");
                    break;


                case "collaborateurToolStripMenuItem":
                    MessageBox.Show("collaboration ici ");
                    break;


                case "assistantToolStripMenuItem":
                    MessageBox.Show("assistant");
                    break;



                default:



                    break;

            }
        }

        private void timerDateHeure_Tick(object sender, EventArgs e)
        {
            //affichage de date et heure
            toolStripStatusLabel4.Text = DateTime.Now.ToString("dd/MM/yyyy/  hh:mm:ss");
               
        }

        private void configurationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void utilisateursToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
        {

            FormUtilisateurs fu = new FormUtilisateurs();
            fu.Show();
        }
    }
}
