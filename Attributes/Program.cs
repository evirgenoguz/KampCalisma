using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer { Id = 1, LastName = "Evirgen", Age = 22 };
            CustomerDal customerDal = new CustomerDal();
            customerDal.Add(customer);
            Console.ReadLine();
        }
    }

    [ToTable("TblCustomer")]
    [ToTable("Customers")]
    class Customer
    {
        public int Id { get; set; }
        [RequiredProperty]
        public string FirstName { get; set; }
        [RequiredProperty]
        public string LastName { get; set; }
        [RequiredProperty]
        public int Age { get; set; }

    }

    class CustomerDal
    {
        [Obsolete("Don't use Add, instead use AddNew Method")] //hazır attribute 
        public void Add(Customer customer)
        {
            Console.WriteLine("{0}, {1}, {2}, {3} added", customer.Id, customer.FirstName, customer.LastName, customer.Age);
        }
        
        public void AddNew(Customer customer)
        {

        }
    }

    [AttributeUsage(AttributeTargets.Property)]
    class RequiredPropertyAttribute : Attribute
    {

    }

    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    class ToTableAttribute : Attribute
    {
        string _tableName;
        public ToTableAttribute(string tableName)
        {
            _tableName = tableName;
        }
    }

    

}
