using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IBankaDal
    {
        List<Banka> GetAll();
        void Add(Banka banka);
        void Update(Banka banka);
        void Delete(Banka banka);

    }
}
