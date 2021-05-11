using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Resturent.Models
{
    public class SupplierService
    {
        private readonly OmDemoContext _db;

        public SupplierService(OmDemoContext db)
        {
            _db = db;
        }

        //crud
        //display all user
        public List<Supplier> GetSupplier()
        {
            var supplierList = _db.Suppliers.ToList();
            return supplierList;
        }

        //Insert

        public string Create(Supplier objSupplier)
        {
            _db.Suppliers.Add(objSupplier);
            _db.SaveChanges();
            return "save successfully";
        }

        //get user by ID

        public Supplier GetSupplierById(int id)
        {
            Supplier supplier = _db.Suppliers.FirstOrDefault(s => s.SupplierId == id);
            return supplier;
        }

        //Update
        public string Update(Supplier objSupplier)
        {
            _db.Suppliers.Update(objSupplier);
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

        public string Delete(long SupplierId)
        {
            var supplier = _db.Suppliers.FirstOrDefault(s => s.SupplierId == SupplierId);
            if (supplier != null)
            {
                _db.Suppliers.Remove(supplier);
                _db.SaveChanges();
            }
            return "Deleted";
        }

    }
}
