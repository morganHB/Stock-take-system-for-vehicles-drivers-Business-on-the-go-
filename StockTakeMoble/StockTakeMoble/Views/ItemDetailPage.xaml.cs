using StockTakeMoble.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace StockTakeMoble.Views
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