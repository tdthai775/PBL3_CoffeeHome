using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3_CoffeeHome.DAL.Repository;
using PBL3_CoffeeHome.DTO;
using PBL3_CoffeeHome.BLL;

namespace PBL3_CoffeeHome.BLL
{
    public class RevenueBLL
    {
        private readonly RevenueDAL _revenueDAL;
        private readonly InventoryTransactionBLL _inventoryTransactionBLL;

        public RevenueBLL()
        {
            _revenueDAL = new RevenueDAL();
            _inventoryTransactionBLL = new InventoryTransactionBLL();

        }

    }
}