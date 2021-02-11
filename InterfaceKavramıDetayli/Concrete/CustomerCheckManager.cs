using InterfaceKavramıDetayli.Abstract;
using InterfaceKavramıDetayli.Entities;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceKavramıDetayli.Concrete
{
    class CustomerCheckManager : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            return true; //başlangıçta doğrulanmış varsaydık
        }

        
    }
}
