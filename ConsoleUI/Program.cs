
using Business1.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            BankaTest();

        }
        public static void BankaTest()
        {
            BankaManager bankaManager = new BankaManager(new EfBankaDal());
            bankaManager.Add(new Banka { BankaAdi = "NesBank", BankaKodu = 1423, HesapNo = 1995, Iban = 781039005, Id = 7, SubeAdi = "Gölbaşı" });
            foreach (var item in bankaManager.GetAll().Data)
            {
                Console.WriteLine(item.BankaAdi);
            }




        }

     
    }
}
