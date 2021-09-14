using Business.Abstract;
using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
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
