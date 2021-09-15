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
    public class BakiyeKasaManager : IBakiyeKasaService
    {
        IBakiyeKasaDal _bakiyeKasa;
        public BakiyeKasaManager(IBakiyeKasaDal bakiyeKasa)
        {
            _bakiyeKasa = bakiyeKasa;
        }

        public IResult Add(Bakiye_Kasa bakiyeKasa)
        {
            _bakiyeKasa.Add(bakiyeKasa);
            return new SuccessResult();
        }

        public IResult Delete(Bakiye_Kasa bakiyeKasa)
        {
            _bakiyeKasa.Delete(bakiyeKasa);
            return new SuccessResult();
        }

        public IDataResult<List<Bakiye_Kasa>> GetAll()
        {
            return new SuccessDataResult<List<Bakiye_Kasa>>(_bakiyeKasa.GetAll(), Messages.Listed);
        }

        public IResult Update(Bakiye_Kasa bakiyeKasa)
        {
            _bakiyeKasa.Update(bakiyeKasa);
            return new SuccessResult();
        }
    }
}
