using Business1.Abstract;
using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business1.Concrete
{
    public class BankaManager : IBankaService
    {

        IBankaDal _bankaDal;

        public BankaManager(IBankaDal bankaDal)
        {
            _bankaDal = bankaDal;
        }

        public List<Banka> GetAll()
        {
            return _bankaDal.GetAll();
        }
    }
}
