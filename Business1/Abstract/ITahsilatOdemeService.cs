using Core.Utilities.Results;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business1.Abstract
{
    public interface ITahsilatOdemeService
    {
        IDataResult<List<Tahsilat_odeme>> GetAll();
        IResult Add(Tahsilat_odeme tahsilatOdeme);
        IResult Update(Tahsilat_odeme tahsilatOdeme);
        IResult Delete(Tahsilat_odeme tahsilatOdeme);
    }
}
