using NutriTEC_Mobile.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace NutriTEC_Mobile.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}