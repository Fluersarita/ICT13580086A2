using System;
using SQLite;

namespace ICT13580086A2.Models
{
    public class Product
    {
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }

        [NotNull]
        [MaxLength(200)]
        public string Name { get; set; }

        public string Descrpition { get; set; }

        [NotNull]
        [MaxLength(100)]
        public string Category { get; set; }

        public decimal ProductPrice { get; set; }
        public decimal SellPrice { get; set; }
        public int Stock { get; set; }
            
    }
}
