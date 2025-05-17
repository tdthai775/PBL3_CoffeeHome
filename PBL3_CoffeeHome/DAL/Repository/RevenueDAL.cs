using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3_CoffeeHome.DTO;

namespace PBL3_CoffeeHome.DAL.Repository
{
    public class RevenueDAL
    {
        private readonly CoffeeDbContext _context;

        public RevenueDAL()
        {
            _context = new CoffeeDbContext();
        }
    }
}