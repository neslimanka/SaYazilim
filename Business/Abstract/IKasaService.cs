using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IKasaService
    {
        List<Kasa> GetAll();
    }
}
