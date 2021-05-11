using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Resturent.Models
{
    public class StockPurchesService
    {
        private readonly OmDemoContext _db;

        public StockPurchesService(OmDemoContext db)
        {
            _db = db;
        }

        //crud
        //display all user
        public List<StockPurch> GetStock()
        {
            var stockList = _db.StockPurches.ToList();
            return stockList;
        }

        //Insert

        public string Create(StockPurch objStock)
        {
            _db.StockPurches.Add(objStock);
            _db.SaveChanges();
            return "save successfully";
        }

        //get user by ID

        public StockPurch GetStockById(int id)
        {
            StockPurch stock = _db.StockPurches.FirstOrDefault(s => s.PurchesItemId == id);
            return stock;
        }

        //Update
        public string Update(StockPurch objStock)
        {
            _db.StockPurches.Update(objStock);
            _db.SaveChanges();
            return "Update successfully";
        }

        //Delete
        /* public string Delete(User objUser)
         {
             _db.Remove(objUser);
             _db.SaveChanges();
             return "deleted";
         }*/

        public string Delete(long purchesId)
        {
            var stock = _db.StockPurches.FirstOrDefault(s => s.PurchesItemId == purchesId);
            if (stock != null)
            {
                _db.StockPurches.Remove(stock);
                _db.SaveChanges();
            }
            return "Deleted";
        }

    }
}
