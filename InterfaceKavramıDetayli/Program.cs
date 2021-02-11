using InterfaceKavramıDetayli.Abstract;
using InterfaceKavramıDetayli.Adapters;
using InterfaceKavramıDetayli.Concrete;
using InterfaceKavramıDetayli.Entities;
using System;

namespace InterfaceKavramıDetayli
{
    public class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer {DateOfBirth = new DateTime(1998,01,22), FirstName = "Oğuz", LastName = "Evirgen", NationalityId = "13895763530" });
            Console.ReadLine();
        }
    }
}

/*
 * Kahve dükkanları için müşteri yönetimi yapan bir sistem yazmak istiyoruz
 * Starbuck ve Nero firmasi için çalıştığımızı düşünelim
 * İki fima da müşterilerini veri tabanına kaydetmek istiyor.
 * Starbuck müşteriler kaydederken mutlaka mernis doğrulaması istiyor. 
 * Nero müşteriler kaydederken böyle bir şey istemiyor
 * Starbuck müşterileri için her kahve alımınında yıldız kazandırmak istiyor
*/