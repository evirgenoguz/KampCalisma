using InterfaceKavramıDetayli.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceKavramıDetayli.Abstract
{
    public interface ICustomerCheckService
    {
        bool CheckIfRealPerson(Customer customer);
    }
}
