using Firebase.Database;
using Migros_Sanal_Market.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Migros_Sanal_Market.Services
{
    class GetKategoriService
    {
        FirebaseClient client;
        public GetKategoriService()
        {
            client = new FirebaseClient("https://ourprojectapp-6e544-default-rtdb.firebaseio.com/");
        }

        public async Task<List<Kategoriler>> GetCategoriesAsync()
        {
            var categories = (await client.Child("Categories")
                .OnceAsync<Kategoriler>())
                .Select(c => new Kategoriler
                {
                    CategoryId = c.Object.CategoryId,
                    CategoryName = c.Object.CategoryName,
                    ImageUrl = c.Object.ImageUrl
                }).ToList();
            return categories;
        }
    }
}
