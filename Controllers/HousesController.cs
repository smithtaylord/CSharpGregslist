using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpGregslist.Controllers
{
    public class HousesController
    {
        private readonly HousesService housesService;
        public HousesController(HousesService housesService)
        {
            this.housesService = housesService;
        }
    }
}