using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IBakiyeBankaDal
    {
        List<Bakiye_Banka> GetAll();
        void Add(Bakiye_Banka bakiyeBanka);
        void Update(Bakiye_Banka bakiyeBanka);
        void Delete(Bakiye_Banka bakiyeBanka);
    }
}
