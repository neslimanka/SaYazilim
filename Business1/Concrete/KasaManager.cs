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
    public class KasaManager : IKasaService
    {

        IKasaDal _kasaDal;
        public KasaManager(IKasaDal kasa)
        {
            _kasaDal = kasa;
        }

        public IResult Add(Kasa kasa)
        {
            _kasaDal.Add(kasa);
            return new SuccessResult();
        }

        public IResult Delete(Kasa kasa)
        {
            _kasaDal.Delete(kasa);
            return new SuccessResult();
        }

        public IDataResult<List<Kasa>> GetAll()
        {
            return new SuccessDataResult<List<Kasa>>(_kasaDal.GetAll(), Messages.Listed);
        }

        public IResult Update(Kasa kasa)
        {
            _kasaDal.Update(kasa);
            return new SuccessResult();
        }
    }
}
