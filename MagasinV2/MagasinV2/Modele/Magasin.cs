using System;
using System.Collections.Generic;
using System.Text;

namespace MagasinV2.Modele
{
    class Magasin
    {
        #region Attributs

        public static List<Magasin> CollClasse = new List<Magasin>();

        private string _nom;
        private string _adresse;

        private Dictionary<Jour, int> _dictionnaireSalariesParJour;



        #endregion

        #region Constructeurs

        public Magasin(string nom, string adresse)
        {
            Magasin.CollClasse.Add(this);
            Nom = nom;
            Adresse = adresse;
            DictionnaireSalariesParJour = new Dictionary<Jour, int>();
        }


        #endregion

        #region Getters/Setters
        public string Nom { get => _nom; set => _nom = value; }
        public string Adresse { get => _adresse; set => _adresse = value; }
        public Dictionary<Jour, int> DictionnaireSalariesParJour { get => _dictionnaireSalariesParJour; set => _dictionnaireSalariesParJour = value; }

        #endregion

        #region Methodes

        public bool AffecterLesSalaries()
        {
            bool resultat = false;
            int nbSalariesretenus = 0;
            //parcourir le dictionnaire -> les jours et les besoins
            foreach(var unElement in DictionnaireSalariesParJour)
            {
                foreach(Salarie unSalarie in Salarie.CollClasse)
                {
                    this.SubAffecterLesSalaries(unSalarie, nbSalariesretenus, unElement.Value, unElement.Key);
                }
                nbSalariesretenus = 0;
            }
            return resultat;
        }

        public bool SubAffecterLesSalaries(Salarie unSalarie, int nbSalariesretenus, int nb, Jour j)
        {
            bool resultat = false;
            if (unSalarie.GetNbreJoursTravailles() < 5 || nbSalariesretenus < nb || !unSalarie.JoursDeConges.Contains(j))
            {
                unSalarie.DictionnaireJourDansMagasin.Add(j, this);
                nbSalariesretenus++;
                resultat = true;
            }
            else
            {
                resultat = false;
            }
            return resultat;
        }


        #endregion
    }
}
