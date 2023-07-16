using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using daldazTCS7.ViewModels;
using daldazTCS7.Views;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace daldazTCS7.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ItemsPage : ContentPage
    {
        ItemsViewModel _viewModel;

        public ItemsPage()
        {
            InitializeComponent();

            BindingContext = _viewModel = new ItemsViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }
    }
}