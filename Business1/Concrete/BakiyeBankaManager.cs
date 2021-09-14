using Business1.Abstract;
using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business1.Concrete
{
    public class BakiyeBankaManager : IBakiyeBankaService
    {
        IBakiyeBankaDal _bakiyeBanka;
        public BakiyeBankaManager(IBakiyeBankaDal bakiyeBanka)
        {
            _bakiyeBanka = bakiyeBanka;
        }

        public List<Bakiye_Banka> GetAll()
        {
            return _bakiyeBanka.GetAll();
        }
    }
}
