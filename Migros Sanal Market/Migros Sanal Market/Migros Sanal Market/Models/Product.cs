using System;
using System.Collections.Generic;
using System.Text;

namespace Migros_Sanal_Market.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ImageUrll { get; set; }
        public string ProductNamee { get; set; }
        public double Türü { get; set; }//Buraya girilen rakamlarla kategori içlerinin de türlenmesini sağlayacağız.Show us.
        public string Rating { get; set; }
        public string HomeSelected { get; set; }
        public double Price { get; set; }
        public int CategoryId { get; set; }
       
    }
}
