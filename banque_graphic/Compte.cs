using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banque_graphic
{
    public class Compte
    {

        private int num;
        private Client proprio;
        private double solde;
        private double decouv = 0;

        public int Num { get => num; }


        /// <summary>
        /// méthode qui affecte un certain montant de découvert
        /// </summary>
        /// <param name="value">double représentant le découvert</param>
        public double Decouv
        {
            get => decouv;

            set
            {
                if (this.solde >= (-value)) { decouv = value; }


            }

        }


        public Compte(int n, Client c)
        {
            num = n;
            solde = 0;
            proprio = c;
        }


        public string Description
        {
            get { return "Compte n° " + num + " | " + "Client :  " + proprio + " | " + " Solde actuel : " + solde + " Euros | " + " Decouvert :" + decouv + " Euros"; }
        }



        public void crediter(double mont)
        {
            solde = solde + mont;
        }

        public bool debiter(double mont)
        {
            if (solde - mont < -decouv)
            {
                return false;
            }
            else
            {
                solde = solde - mont;
                return true;
            }
        }

        public Boolean decouvert(double mont)
        {
            if (this.solde >= (-mont))
            { 
                decouv = mont;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
