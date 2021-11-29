using System;
using System.Collections.Generic;
using System.Text;

namespace MagasinV2.Modele
{
    class Jour
    {
        #region Attributs

        public static List<Jour> CollClasse = new List<Jour>();

        private string _nom;

        #endregion

        #region Constructeurs

        public Jour()
        {
            Jour.CollClasse.Add(this);
        }

        #endregion

        #region Getters/Setters

        #endregion

        #region Methodes

        #endregion
    }
}
