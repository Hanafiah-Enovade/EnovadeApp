using EnovadeApp.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace EnovadeApp.Views
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