using MagasinV2.VueModele;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MagasinV2.Vue
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PlanningVue : ContentPage
    {
        PlanningVueModele vueModele;
        public PlanningVue()
        {

            InitializeComponent();
            BindingContext = vueModele = new PlanningVueModele();


        }
    }
}