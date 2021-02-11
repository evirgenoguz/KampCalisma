using InterfaceKavramıDetayli.Abstract;
using InterfaceKavramıDetayli.Entities;
using System;
using System.Collections.Generic;
using System.Text;


namespace InterfaceKavramıDetayli.Adapters
{
    public class MernisServiceAdapter : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            MernisServiceReference.KPSPublicSoapClient client = new MernisServiceReference.KPSPublicSoapClient();
            return client.TCKimlikNoDogrula(Convert.ToInt64 (customer.NationalityId), customer.FirstName.ToUpper(), customer.LastName.ToUpper(), customer.DateOfBirth.Year);
        }
    }
}
