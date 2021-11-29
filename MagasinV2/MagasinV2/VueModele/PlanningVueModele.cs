
using System.Windows.Input;
using Xamarin.Forms;

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

        public ICommand commandTest => new Command(ActioncommandTest);

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

        public void ActioncommandTest()
        {
            string resultat = Test;
            Test = "Au revoir";
        }
        #endregion
    }
}
