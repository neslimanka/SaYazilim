﻿using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface IBankaService
    {

        List<Banka> GetAll();
    }
}