using System;

namespace EntityFrameworkDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Entity Framework -- Bir ORM - Object Relational Mapping
            //Alternatif olarak NHibernate
            //Dapper ama biz entityframework kullanacağız.

            NorthwindContext context = new NorthwindContext(); //db ile bağlandığımız class nesnesi

            foreach (var product in context.Products)
            {
                Console.WriteLine(product.ProductName);
                Console.WriteLine("******************");
            }

            GetProductsByCategoryId(2);
   
        }

        private static void GetProductsByCategoryId(int categoryId)
        {
            NorthwindContext context = new NorthwindContext();

            foreach (var product in context.Products)
            {
                Console.WriteLine(product.ProductName);
            }
        }
    }
}
