using StockTakeMoble.ViewModels;
using StockTakeMoble.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace StockTakeMoble
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
