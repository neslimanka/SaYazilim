using Core.Utilities.Results;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business1.Abstract
{
    public interface IBankaService
    {

        IDataResult<List<Banka>> GetAll();
        IResult Add(Banka banka);
        IResult Update(Banka banka);
        IResult Delete(Banka banka);


    }
}
