using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banque_graphic
{
    public class Client
    {
        private int num;
        private string nom;
        private string prenom;
        private string adresse;
        private List<Compte> comptes = new List<Compte>();

        public Client(int num, string nom, string prenom, string ad)
        {
            this.num = num;
            this.nom = nom;
            this.prenom = prenom;
            this.adresse = ad;
        }





        public int Num { get => num; }
        public string Nom { get => nom; }
        public string Prenom { get => prenom; }
        public string Adresse { get => adresse; set => adresse = value; }

        public override string ToString()

        {

            return (this.Num + "   " + this.Nom + " " + this.prenom + " " + this.Adresse);
        }

    }
}
