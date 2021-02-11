using InterfaceKavramıDetayli.Concrete;
using InterfaceKavramıDetayli.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceKavramıDetayli.Abstract
{
    public abstract class BaseCustomerManager : ICustomerService
    {
        public virtual void Save(Customer customer)
        {
            Console.WriteLine("Save to DB : " + customer.FirstName);
        }

        
    }
}
