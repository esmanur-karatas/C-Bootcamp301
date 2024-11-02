using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Category
    {
        public int CategoryId { get; set; } //eğer sınıf isminin yanına yandaki gibi ıd eklersek bu bunun birincil anahtar olduğunu anlar ama sadece Id yazarsak anlamaz.
        public string CategoryName { get; set; }
        public string CategoryStatus { get; set; }
        //clasın içine direkt tanımlanırsa field
        //yanımda {get;set} varsa property 
        //bir metot içinde tanımlanırsa veriable(değişken)
        //codeFirst yaklaımında değerler propertyy olarak gönderiliyor.
    }
}
