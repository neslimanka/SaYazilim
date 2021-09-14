using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IBakiyeKasaDal
    {
        List<Bakiye_Kasa> GetAll();
        void Add(Bakiye_Kasa bakiyeKasa);
        void Update(Bakiye_Kasa bakiyeKasa);
        void Delete(Bakiye_Kasa bakiyeKasa);
    }
}
