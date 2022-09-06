using System;
using System.Collections.Generic;
using System.Text;

namespace Projet06092022Achat.Modeles
{
    class Achat
    {
        #region Attributs

        public static List<Achat> CollClasse = new List<Achat>();
        private string _nomProduit;
        private int _prix;
        private int _quantite;
        private string _photo;
        #endregion

        #region Constructeurs

        public Achat(string nomProduit, int prix, int quantite, string photo)
        {
            Achat.CollClasse.Add(this);
            NomProduit = nomProduit;
            Prix = prix;
            Quantite = quantite;
            Photo = photo;
        }

        #endregion

        #region Getters/Setters
        public string NomProduit { get => _nomProduit; set => _nomProduit = value; }
        public int Prix { get => _prix; set => _prix = value; }
        public int Quantite { get => _quantite; set => _quantite = value; }
        public string Photo { get => _photo; set => _photo = value; }

        #endregion

        #region Methodes

        public int GetCalculMontant()
        {
            return Quantite * Prix;
        }

        #endregion
    }
}
