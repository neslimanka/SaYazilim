using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IBakiyeBankaService
    {
        List<Bakiye_Banka> GetAll();
    }
}
