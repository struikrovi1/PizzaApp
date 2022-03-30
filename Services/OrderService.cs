using DataAccess;
using Entitites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class OrderService
    {
        private readonly FafoDbContext _context;

        public OrderService(FafoDbContext context)
        {
            _context = context;
        }

        public void Add(Order ord)
        {

            _context.Add(ord);
            _context.SaveChanges();
        }

        public void Update(Order ord)
        {

            _context.Update(ord);
            _context.SaveChanges();
        }
        public List<Order> GetAll()
        {
            return _context.Orders.Include(x => x.Product)
                .Include(x => x.Combo)
                
                .ToList();
        }

      
        public Order GetById(int? id)
        {
            return _context.Orders
                .Include(x => x.Product)
                .Include(x=>x.Combo)
                .FirstOrDefault(c => c.Id == id);
        }
       
        public void Delete(int? id)
        {
            var selectedProduct = _context.Products.Find(id);
            _context.Products.Remove(selectedProduct);

            _context.SaveChanges();
        }

    }
}
