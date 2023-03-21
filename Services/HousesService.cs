using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpGregslist.Services
{
    public class HousesService
    {
        private readonly HousesRepository _repo;
        public HousesService(HousesRepository repo)
        {
            _repo = repo;
        }
    }
}