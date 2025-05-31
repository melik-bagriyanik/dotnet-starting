using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace api.models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty; // Yorum metni, boş olamaz.
        public string Content { get; set; } = string.Empty; // Yorum içeriği, boş olamaz.
        public DateTime CreatedOn { get; set; } = DateTime.Now; // Yorumun oluşturulma tarihi, varsayılan olarak UTC zaman diliminde şu anki zamanı alır.
        public int? StockId { get; set; }
        //navigation 
        public Stock? Stock { get; set; } // Stock ile Comment arasında bir ilişki var, bu yüzden Stock kullanıyoruz.
    }
}