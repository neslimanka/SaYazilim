using Business1.Abstract;
using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business1.Concrete
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
