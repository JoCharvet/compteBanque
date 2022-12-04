using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo_Banque
{
    internal class Banque
    {
        private string nomBanque;

        private string villeBanque;

        private List<Compte> comptesClients;

        private int nbComptes;

        public string NomBanque { get => nomBanque; set => nomBanque = value; }
        public string VilleBanque { get => villeBanque; set => villeBanque = value; }
        public int NbComptes { get => nbComptes; set => nbComptes = value; }
        internal List<Compte> ComptesClients { get => comptesClients; set => comptesClients = value; }

        public Banque()
        {

        }

        public Banque(string _nomBanque, string _villeBanque)
        {
            this.nomBanque = _nomBanque;

            this.villeBanque = _villeBanque;

            this.comptesClients = new();

            this.nbComptes = comptesClients.Count();
        }

        public Banque(List<Compte> _listCompteAncienneBanque, string _nomBanque,string _villeBanque)
        {
            this.nomBanque = _nomBanque;
            this.villeBanque=_villeBanque;
            this.comptesClients = _listCompteAncienneBanque;
            this.nbComptes= comptesClients.Count();
        }

        public void AjouterCompte(Compte _nouveauClient)
        {
            this.comptesClients.Add(_nouveauClient);
            ++this.nbComptes;
        }

        public void AjouterCompte( double _solde, string _nom , int _decouvertAuthorise)
        {
            this.AjouterCompte(new Compte(  _nom, _solde, _decouvertAuthorise));
        }


    }
}
