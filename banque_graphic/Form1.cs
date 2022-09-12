using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace banque_graphic
{
    public partial class Form1 : Form
    {
        List<Compte> cList = new List<Compte>();
        private String choix;

        
        public Form1()
        {
            InitializeComponent();
        }

        public void afficher()
        {
            lbx.DataSource = null;
            lbx.DataSource = cList;
            lbx.DisplayMember = "Description";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Client cl1 = new Client(1, "Dupont", "Toto", "adresse1");
            Client cl2 = new Client(2, "Abdala", "Momo", "adresse2");

            Compte c1 = new Compte(10, cl1);
            Compte c2 = new Compte(11, cl2);
            Compte c3 = new Compte(12, cl2);
            cList.Add(c1);
            cList.Add(c2);
            cList.Add(c3);
            afficher();
            lblMontant.Visible = false;
            txtBMontant.Visible = false;
            btnValider.Visible = false;
        }

        private void btnCrediter_Click(object sender, EventArgs e)
        {
            choix = "crediter";
            lblMontant.Text = "Montant du crédit : ";
            lblMontant.Visible = true;
            txtBMontant.Visible = true;
            btnValider.Visible = true;
        }


        private void btnValider_Click(object sender, EventArgs e)
        {
            Compte c = (Compte)lbx.SelectedItem;
            if (choix == "crediter")
            {
                c.crediter(Convert.ToDouble(txtBMontant.Text));
                lblMontant.Text = "Crédit effectué.";
                txtBMontant.Visible = false;
                btnValider.Visible = false;

            }
           
            else if (choix == "debiter")
            {
                if (c.debiter(Convert.ToDouble(txtBMontant.Text)))
                {
                    lblMontant.Text = "Débit effectué.";
                    txtBMontant.Visible = false;
                    btnValider.Visible = false;
                }
                else
                {
                    lblMontant.Text = "Débit impossible.";
                    txtBMontant.Visible = false;
                    btnValider.Visible = false;
                }
                
            }

            else if (choix == "decouvert")
            {
                if (c.decouvert(Convert.ToDouble(txtBMontant.Text)))
                {
                    lblMontant.Text = "Decouvert changé avec succès !";
                    txtBMontant.Visible = false;
                    btnValider.Visible = false;
                }
                else
                {
                    lblMontant.Text = "Decouvert refusé !";
                    lblMontant.Visible = false;
                    btnValider.Visible = false;
                }
            }
            

            afficher();
            txtBMontant.Text = "";
        }

        private void btnDebiter_Click(object sender, EventArgs e)
        {
            choix = "debiter";
            lblMontant.Text = "Montant du débit : ";
            lblMontant.Visible = true;
            txtBMontant.Visible = true;
            btnValider.Visible = true;
        }

        private void decouvertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            choix = "decouvert";
            lblMontant.Text = "Montant du decouvert : ";
            lblMontant.Visible = true;
            txtBMontant.Visible = true;
            btnValider.Visible = true;
        }

        private void propriétaireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            choix = "propriétaire";
            lblMontant.Text = "Changement de propriétaire : ";
            lblMontant.Visible = true;
            txtBMontant.Visible = true;
            btnValider.Visible = true;
        }
    }
}
