﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HL.Core.Data
{
    public interface IUnitOfWork
    {
        int Commit();
        IRepository<T> Respository<T>();
    }
}
