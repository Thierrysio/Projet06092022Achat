using Projet06092022Achat.Vues;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Projet06092022Achat
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AchatVue();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
