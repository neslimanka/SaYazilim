
using Business1.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            BankaManager bankaManager = new BankaManager(new EfBankaDal());

            foreach (var item in bankaManager.GetAll())
            {
                Console.WriteLine(item.BankaAdi);
            }
            Console.WriteLine("Hello World!");
        }
    }
}
