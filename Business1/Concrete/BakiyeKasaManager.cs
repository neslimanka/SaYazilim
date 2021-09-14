using Business1.Abstract;
using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business1.Concrete
{
    public class BakiyeKasaManager : IBakiyeKasaService
    {
        IBakiyeKasaDal _bakiyeKasa;
        public BakiyeKasaManager(IBakiyeKasaDal bakiyeKasa)
        {
            _bakiyeKasa = bakiyeKasa;
        }

        public List<Bakiye_Kasa> GetAll()
        {
            return _bakiyeKasa.GetAll();
        }
    }
}
