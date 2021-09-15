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
    public class TahsilatOdemeManager : ITahsilatOdemeService
    {

        ITahsilatOdemeDal _tahsilatOdeme;

        public TahsilatOdemeManager(ITahsilatOdemeDal tahsilatOdeme)
        {
            _tahsilatOdeme = tahsilatOdeme;
        }

        public IResult Add(Tahsilat_odeme tahsilatOdeme)
        {
            _tahsilatOdeme.Add(tahsilatOdeme);
            return new SuccessResult();
        }

        public IResult Delete(Tahsilat_odeme tahsilatOdeme)
        {
            _tahsilatOdeme.Delete(tahsilatOdeme);
            return new SuccessResult();
        }

        public IDataResult<List<Tahsilat_odeme>> GetAll()
        {
            return new SuccessDataResult<List<Tahsilat_odeme>>(_tahsilatOdeme.GetAll(), Messages.Listed);
        }

        public IResult Update(Tahsilat_odeme tahsilatOdeme)
        {
            _tahsilatOdeme.Update(tahsilatOdeme);
            return new SuccessResult();
        }
    }
}
