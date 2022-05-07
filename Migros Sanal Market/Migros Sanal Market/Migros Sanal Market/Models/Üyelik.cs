using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Migros_Sanal_Market.Models
{
    public class Üyelik
    {
        [PrimaryKey,AutoIncrement]
        public int Id { get; set; }
        [MaxLength(10)]
        public string TelefonNo { get; set; }
        public string Mail { get; set; }
        
        
    }
}
