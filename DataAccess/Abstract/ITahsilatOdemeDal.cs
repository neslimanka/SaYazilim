using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ITahsilatOdemeDal
    {
        List<Tahsilat_odeme> GetAll();
        void Add(Tahsilat_odeme tahsilatOdeme);
        void Update(Tahsilat_odeme tahsilatOdeme);
        void Delete(Tahsilat_odeme tahsilatOdeme);

    }
}
