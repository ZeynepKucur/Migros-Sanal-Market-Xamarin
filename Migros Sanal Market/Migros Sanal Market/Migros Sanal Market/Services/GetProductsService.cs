using Firebase.Database;
using Migros_Sanal_Market.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Migros_Sanal_Market.Services
{
    public class GetProductsService
    {
        FirebaseClient firebaseClient;

        public GetProductsService()
        {
            firebaseClient = new FirebaseClient("https://ourprojectapp-6e544-default-rtdb.firebaseio.com/");

        }

        public async Task<List<Product>> GetProductsAsync()
        {
            var products = (await firebaseClient.Child("Products")
                .OnceAsync<Product>())
                .Select(f => new Product
                {
                    CategoryId=f.Object.CategoryId,
                    ProductId=f.Object.ProductId,
                    HomeSelected=f.Object.HomeSelected,
                    Price=f.Object.Price,
                    ProductNamee=f.Object.ProductNamee,
                    ImageUrll=f.Object.ImageUrll,
                    Rating=f.Object.Rating, 
                    Türü=f.Object.Türü

                }).ToList();

            return products;
        }

        public async Task <ObservableCollection<Product>> GetProductsByCategoryAsync(int categoryID)
        {
            var productsByCategory = new ObservableCollection<Product>();
            var items = (await GetProductsAsync()).Where(p => p.CategoryId == categoryID).ToList();

            foreach (var item in items)
            {
                productsByCategory.Add(item);
            }

            return productsByCategory;
        }

        public async Task<ObservableCollection<Product>> GetLatestProductAsync()
        {
            var latestProduct = new ObservableCollection<Product>();
            var items = (await GetProductsAsync()).OrderByDescending(f => f.ProductId).Take(5);

            foreach (var item in items)
            {
                latestProduct.Add(item);
            }
            return latestProduct;
        }


    }
}
