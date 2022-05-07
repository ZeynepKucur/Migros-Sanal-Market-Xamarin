using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLite;
using Migros_Sanal_Market.Models;
using Android.Widget;
using Migros_Sanal_Market.ViewModels;

namespace Migros_Sanal_Market.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GirişYapPage : ContentPage
    {
        public GirişYapPage()
        {
            InitializeComponent();
            this.BindingContext = new GirisYapViewModel();
        }

       
    } 
}