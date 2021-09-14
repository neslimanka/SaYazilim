using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            BankaManager bankaManager = new BankaManager(new InMemoryBankaDal());

            foreach (var item in bankaManager.GetAll())
            {
                Console.WriteLine(item.BankaAdi);
            }
            Console.WriteLine("Hello World!");
        }
    }
}
