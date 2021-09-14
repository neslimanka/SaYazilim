using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryBankaDal : IBankaDal
    {

        List<Banka> _banka;

        public InMemoryBankaDal()
        {
            _banka = new List<Banka>
            {
                new Banka{ BankaAdi="Zirat Bankası", BankaKodu=1, HesapNo=234, Iban=013554801, Id=1, SubeAdi="Yenimahalle"},
                new Banka{ BankaAdi="Halk Bankası", BankaKodu=2, HesapNo=551, Iban=123456789, Id=6, SubeAdi="Keçiören"},
                new Banka{ BankaAdi="Garanti Bankası", BankaKodu=3, HesapNo=456, Iban=123456987, Id=8, SubeAdi="Mamak"},
                new Banka{ BankaAdi="Yapıkredi Bankası", BankaKodu=4, HesapNo=789, Iban=005431864, Id=7, SubeAdi="Pursaklar"},
                new Banka{ BankaAdi="Vakıf Bankası", BankaKodu=5, HesapNo=123, Iban=0257931468, Id=5, SubeAdi="Etimesgut"}
            };
        }
        public void Add(Banka banka)
        {
            _banka.Add(banka);
        }

        public void Delete(Banka banka)
        {
            Banka bankaToDelete= _banka.SingleOrDefault(b=>b.Id==banka.Id);
            _banka.Remove(bankaToDelete);
        }

        public Banka Get(Expression<Func<Banka, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Banka> GetAll()
        {
            return _banka;
        }

        public List<Banka> GetAll(Expression<Func<Banka, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Update(Banka banka)
        {
            Banka bankaToUpdate = _banka.SingleOrDefault(b => b.Id == banka.Id);
            bankaToUpdate.HesapNo = banka.HesapNo;
            bankaToUpdate.Iban = banka.Iban;
            bankaToUpdate.SubeAdi = banka.SubeAdi;
            bankaToUpdate.BankaKodu = banka.BankaKodu;
            bankaToUpdate.BankaAdi = banka.BankaAdi;
        }
    }
}
