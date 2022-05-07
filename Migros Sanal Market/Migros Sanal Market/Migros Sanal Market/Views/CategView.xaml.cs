using Migros_Sanal_Market.Models;
using Migros_Sanal_Market.ViewModels;
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
    public partial class CategView : ContentPage
    {
        CategViewModel cvm;
        public CategView(Kategoriler category)
        {
            InitializeComponent();
            cvm = new CategViewModel(category);
            this.BindingContext = cvm; 
        }

        async void ImageButton_Clicked(System.Object sender,System.EventArgs e)
        {
            await Navigation.PopModalAsync();
        }

        async void CollectionView_SelectionChanged(System.Object sender,Xamarin.Forms.SelectionChangedEventArgs e)
        {
            var selectedProduct = e.CurrentSelection.FirstOrDefault() as Product;
            if (selectedProduct == null)
                return;
            await Navigation.PushModalAsync(new ProductsDetailView(selectedProduct));
            ((CollectionView)sender).SelectedItem = null;


        }
    }
}