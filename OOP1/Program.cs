using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            Product product2 = new Product {Id = 2, CategoryId = 5, ProductName = "Kalem", UnitPrice = 35, UnitsInStock = 10 }; //bu rastgele sıra ile yazılabilir.

            ProductManager productManager = new ProductManager();
            productManager.Add(product1); //burada product sınıfından oluşan nesnenin adresi gönderirilir aslında primitive tiplerde ise sadece değer gönderilir.
            //Console.WriteLine(product1.ProductName); //kamera yazar çünkü nesnenin referansında değişiklik yapılır
            
            //int double bool ... değer tiplerdir
            //diziler class abstract class interface .... referans tiplerdir
            //ref ve out keywordleri ile değer tipleri ref tip gibi kullanabilirsin.


        }
    }
}
