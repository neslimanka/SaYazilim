using Business.Abstract;
using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class TahsilatOdemeManager : ITahsilatOdemeService
    {

        ITahsilatOdemeDal _tahsilatOdeme;

        public TahsilatOdemeManager(ITahsilatOdemeDal tahsilatOdeme)
        {
            _tahsilatOdeme = tahsilatOdeme;
        }
        public List<Tahsilat_odeme> GetAll()
        {
            return _tahsilatOdeme.GetAll();
        }
    }

  
  
}
