using System;
using System.Collections.Generic;
using System.Text;

namespace MagasinV2.Modele
{
    class Salarie
    {
        #region Attributs

        public static List<Salarie> CollClasse = new List<Salarie>();

        private string _nom;
        private string _prenom;
        private List<Jour> _joursDeConges;

        private Dictionary<Jour, Magasin> _dictionnaireJourDansMagasin;

        #endregion

        #region Constructeurs

        public Salarie(string nom, string prenom)
        {
            Salarie.CollClasse.Add(this);
            DictionnaireJourDansMagasin = new Dictionary<Jour, Magasin>();
            _nom = nom;
            _prenom = prenom;
            _joursDeConges = new List<Jour>();
        }


        #endregion

        #region Getters/Setters
        public string Nom { get => _nom; set => _nom = value; }
        public string Prenom { get => _prenom; set => _prenom = value; }
        public  Dictionary<Jour, Magasin> DictionnaireJourDansMagasin { get => _dictionnaireJourDansMagasin; set => _dictionnaireJourDansMagasin = value; }
        public List<Jour> JoursDeConges { get => _joursDeConges; set => _joursDeConges = value; }

        #endregion

        #region Methodes

        public int GetNbreJoursTravailles()
        {    
           return  DictionnaireJourDansMagasin.Count;       
        }

        #endregion
    }
}
