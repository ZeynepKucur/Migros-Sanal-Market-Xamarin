using Migros_Sanal_Market.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Migros_Sanal_Market.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProductsDetailView : ContentPage
    {
        public ProductsDetailView(Product ourProduct)
        {
            InitializeComponent();
        }
    }
}