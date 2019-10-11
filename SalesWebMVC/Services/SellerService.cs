using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMVC.Models;

namespace SalesWebMVC.Services
{
    public class SellerService
    {
        private readonly SalesWebMVCContext _context;

        public SellerService(SalesWebMVCContext context)
        {
            _context = context;
        }

        public List<Sellers> FindAll()
        {
            return _context.Seller.ToList();
        }
        
        public void Insert(Sellers obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }
        
    }
}
