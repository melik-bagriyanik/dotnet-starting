using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace api.models
{
    public class Stock
    {
        public int Id { get; set; }
        public string Symbol { get; set; } = string.Empty;
        public string CompanyName { get; set; } = string.Empty;  //bunu yapmamızın sebebi, bu alanın null olmasını istemememizdir.
        [Column(TypeName = "decimal(18,2)")]
        // Veritabanında decimal olarak saklanacak
        public decimal Purchase { get; set; } // Veritabanında decimal olarak saklanacak
        [Column(TypeName = "decimal(18,2)")]

        public decimal LastDiv { get; set; }
        public string Industry { get; set; } = string.Empty;

        public long MarketCap { get; set; } // Veritabanında long olarak saklanacak ,long, büyük sayılar için kullanılır.

        public List<Comment> Comments { get; set; } = new List<Comment>(); // Stock ile Comment arasında bir ilişki var, bu yüzden List<Comment> kullanıyoruz.

    }
}

