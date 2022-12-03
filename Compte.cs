using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo_Banque
{
    internal class Compte
    {
        private static int compteur;
        private int numeroCompte;
        private string nomTitulaire;
        private double solde;
        private int decouvertAuthorise;

        public int NumeroCompte { get => numeroCompte;  }
        public string NomTitulaire { get => nomTitulaire;  }
        public double Solde { get => solde;  }
        public int DecouvertAuthorise { get => decouvertAuthorise; }
        
        public Compte()
        {

        }

        public Compte(string nomTitulaire, double solde, int decouvertAuthorise)
        {
            this.nomTitulaire = nomTitulaire;
            this.solde = solde;
            this.decouvertAuthorise = decouvertAuthorise;
            this.numeroCompte = ++Compte.compteur;
        }

        public bool Crediter(double _montant)
        {
            if(_montant > 0)
            {
                this.solde += _montant;
                return true;
            }
           
            return false;
                
        }

        public bool Debiter(double _montant)
        {
            if (_montant>0)
            {
                if ((this.solde + this.decouvertAuthorise) > _montant)
                {
                    this.solde-= _montant;
                    return true;
                }
            }
            return false;
           
        }

        public bool Superieur(Compte _autreCompte)
        {
            return (this.solde > _autreCompte.solde) ? true : false;
        }

        public string ToString(string _symbole ="€")
        {
            return $" Compte : {this.numeroCompte} \nTitulaire : {this.nomTitulaire} \nSolde : {this.solde} {_symbole}\nDecouvert Authorise : {this.decouvertAuthorise} {_symbole}";
        }

        public bool Transferer(double _montant,Compte _autreCompte )
        {
            return (this.Debiter(_montant) && _autreCompte.Crediter(_montant)) ? true: false; 
           
       
        }
    }
}
