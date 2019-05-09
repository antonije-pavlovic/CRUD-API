using DataAccess;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public abstract class BaseRepository
    {
        protected readonly Context _context;
        public BaseRepository(Context context)
        {
            _context = context;
        }
    }
}
