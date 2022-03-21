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
    public class ProductService
    {
        private readonly FafoDbContext _context;

        public ProductService(FafoDbContext context)
        {
            _context = context;
        }

        public void Add(Product pro)
        {

            _context.Add(pro);
            _context.SaveChanges();
        }

        public void Update(Product pro)
        {

            _context.Update(pro);
            _context.SaveChanges();
        }
        public List<Product> GetAll()
        {
            return _context.Products.Include(x => x.Category)
                .ToList();
        }
        public Product GetById(int? id)
        {
            return _context.Products.Include(x => x.Category).FirstOrDefault(c => c.Id == id);
        }

        public void Delete(int? id)
        {
            var selectedProduct = _context.Products.Find(id);
            _context.Products.Remove(selectedProduct);

            _context.SaveChanges();
        }

    }
}
