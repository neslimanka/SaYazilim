using Business1.Abstract;
using Business1.Constants;
using Core.Utilities.Results;
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


        public IResult Add(Bakiye_Banka bakiyeBanka)
        {
            _bakiyeBanka.Add(bakiyeBanka);
            return new SuccessResult();
        }

        public IResult Delete(Bakiye_Banka bakiyeBanka)
        {
            _bakiyeBanka.Delete(bakiyeBanka);
            return new SuccessResult();
        }

        public IDataResult<List<Bakiye_Banka>> GetAll()
        {
            return new SuccessDataResult<List<Bakiye_Banka>>(_bakiyeBanka.GetAll(), Messages.Listed);
        }

        public IResult Update(Bakiye_Banka bakiyeBanka)
        {
            _bakiyeBanka.Update(bakiyeBanka);
            return new SuccessResult();
        }
    }
}
