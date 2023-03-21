using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpGregslist.Repositories
{
    public class HousesRepository
    {
        private readonly IDbConnection _db;
        public HousesRepository(IDbConnection db)
        {
            _db = db;
        }
    }
}