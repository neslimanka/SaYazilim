using Core.Utilities.Results;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business1.Abstract
{
    public interface IBakiyeBankaService
    {
        IDataResult<List<Bakiye_Banka>> GetAll();
        IResult Add(Bakiye_Banka bakiyeBanka);
        IResult Update(Bakiye_Banka bakiyeBanka);
        IResult Delete(Bakiye_Banka bakiyeBanka);


    }
}
