using Core.Utilities.Results;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business1.Abstract
{
    public interface IBakiyeKasaService
    {
        IDataResult<List<Bakiye_Kasa>> GetAll();
        IResult Add(Bakiye_Kasa bakiyeKasa);
        IResult Update(Bakiye_Kasa bakiyeKasa);
        IResult Delete(Bakiye_Kasa bakiyeKasa);
    }
}
