using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Category
    {
        //Erişim belirleyici türü - Değişken tür isim {get set}
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }    
        public string CategoryDescription { get; set; }         
        public bool CategoryStatus{ get; set; } //Category türlerini aktif veya pasif yapmak için bool kullanılır

    }
}
