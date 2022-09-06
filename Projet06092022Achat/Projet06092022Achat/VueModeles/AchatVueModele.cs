using Projet06092022Achat.Modeles;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projet06092022Achat.VueModeles
{
    class AchatVueModele : BaseVueModele
    {
        #region Attributs

        private Achat _unAchat;
        private int _montant;
        #endregion

        #region Constructeurs

        public AchatVueModele()
        {
            UnAchat = new Achat("P1", 10, 3, "https://www.dvo.com/newsletter/weekly/2014/05-09-115/w_images/hamburgers.jpg");
        }

        #endregion

        #region Getters/Setters
        public Achat  UnAchat
        {
            get
            {
                return _unAchat;
            }
            set
            {
                SetProperty(ref _unAchat, value);
            }
        }
        public int Montant
        {
            get
            {
                return _montant;
            }
            set
            {
                SetProperty(ref _montant, value);
            }
        }
        #endregion

        #region Methodes

        public int GetMontant()
        {
            Montant = UnAchat.GetCalculMontant();
            return Montant;
        }

        #endregion
    }
}
