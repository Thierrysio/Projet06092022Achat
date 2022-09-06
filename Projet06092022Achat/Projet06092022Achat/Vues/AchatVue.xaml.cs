using Projet06092022Achat.VueModeles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Projet06092022Achat.Vues
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AchatVue : ContentPage
    {
        AchatVueModele vueModele;
        public AchatVue()
        {
            InitializeComponent();
            BindingContext = vueModele = new AchatVueModele();

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
          int resultat =  vueModele.GetMontant();
            this.SetChangeCouleur(resultat);
        }

        private void SetChangeCouleur(int param)
        {
            if (param>20)
            { montant.TextColor = Color.DarkGreen; }
            else { montant.TextColor = Color.DarkRed; }
        }

    }
}