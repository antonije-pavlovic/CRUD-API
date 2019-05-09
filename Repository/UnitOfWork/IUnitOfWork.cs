using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.UnitOfWork
{
    public interface IUnitOfWork
    {
        void Save();
    }
}
