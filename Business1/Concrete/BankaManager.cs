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
    public class BankaManager : IBankaService
    {

        IBankaDal _bankaDal;

        public BankaManager(IBankaDal bankaDal)
        {
            _bankaDal = bankaDal;
        }


        public IResult Add(Banka banka)
        {
            _bankaDal.Add(banka);
            return new SuccessResult();
        }

        public IResult Delete(Banka banka)
        {
            _bankaDal.Delete(banka);
            return new SuccessResult();
        }

        public IDataResult<List<Banka>> GetAll()
        {
            return new SuccessDataResult<List<Banka>>(_bankaDal.GetAll(),Messages.Listed);
        }

        public IResult Update(Banka banka)
        {
            _bankaDal.Update(banka);
            return new SuccessResult();
        }
    }
}
