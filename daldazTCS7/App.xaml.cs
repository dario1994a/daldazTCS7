using daldazTCS7.Vistas;
using daldazTCS7.ViewModels;
using daldazTCS7.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace daldazTCS7
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Login());
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
