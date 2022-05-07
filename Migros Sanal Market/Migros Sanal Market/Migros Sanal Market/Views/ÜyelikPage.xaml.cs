using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Migros_Sanal_Market.Models;
using SQLite;
using Migros_Sanal_Market.ViewModels;

namespace Migros_Sanal_Market.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ÜyelikPage : ContentPage
    {
        public ÜyelikPage()
        {
            InitializeComponent();
            this.BindingContext = new ÜyeOlViewModel();
        }

    }
}