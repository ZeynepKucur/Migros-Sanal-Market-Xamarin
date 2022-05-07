using Migros_Sanal_Market.ViewModels;
using Migros_Sanal_Market.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Migros_Sanal_Market
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ProductView), typeof(ProductView));
            //Routing.RegisterRoute(nameof(MeyveSebzeContentPage), typeof(MeyveSebzeContentPage));
            //Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
