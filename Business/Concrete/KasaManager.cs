using Business.Abstract;
using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class KasaManager : IKasaService
    {

        IKasaDal _kasa;
        public KasaManager(IKasaDal kasa)
        {
            _kasa = kasa;
        }
        public List<Kasa> GetAll()
        {
            return _kasa.GetAll();
        }
    }
}
