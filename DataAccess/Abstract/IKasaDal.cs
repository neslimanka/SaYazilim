using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IKasaDal
    {

        List<Kasa> GetAll();
        void Add(Kasa kasa);
        void Update(Kasa kasa);
        void Delete(Kasa kasa);
    }
}
