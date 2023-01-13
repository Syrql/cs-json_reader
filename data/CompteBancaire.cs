using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    public class CompteBancaire
    {
        public string titulaire { get; set; }
        public double solde { get; set; }
        public string devise { get; set; }
        public CompteBancaire(String titulaire, double solde, String devise)
        {
            this.titulaire = titulaire;
            this.solde = solde;
            this.devise = devise;
        }


        public String printAccount()
        {
            return "Le titulaire " + this.titulaire + " possède ce compte avec " + this.solde + this.devise +  ".";
        }

    }
}
