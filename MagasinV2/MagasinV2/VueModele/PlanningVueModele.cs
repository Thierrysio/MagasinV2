using System;
using System.Collections.Generic;
using System.Text;

namespace MagasinV2.VueModele
{
    class PlanningVueModele : BaseVueModele
    {
        #region Attributs
        private string _test;
        #endregion

        #region Constructeurs

        public PlanningVueModele()
        {
            Test = "boujour les SIO2";
        }


        #endregion

        #region Getters/Setters
        public string Test {

            get
            {
                return _test;
            }
            set
            {
                SetProperty(ref _test, value);
            }
        }

        #endregion

        #region Methodes

        #endregion
    }
}
