using Core.Utilities.Results;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business1.Abstract
{
    public interface IKasaService
    {
        IDataResult<List<Kasa>> GetAll();
        IResult Add(Kasa kasa);
        IResult Update(Kasa kasa);
        IResult Delete(Kasa kasa);
    }
}
