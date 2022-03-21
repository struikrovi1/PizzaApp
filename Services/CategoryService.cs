using DataAccess;
using Entitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class CategoryService
    {
        private readonly FafoDbContext _context;

        public CategoryService(FafoDbContext context)
        {
            _context = context;
        }

        public void Add(Category cat)
        {

            _context.Add(cat);
            _context.SaveChanges();
        }

        public void Update(Category cat)
        {

            _context.Update(cat);
            _context.SaveChanges();
        }
        public List<Category> GetAll()
        {
            return _context.Categories.ToList();
        }
        public Category GetById(int? id)
        {
            return _context.Categories.FirstOrDefault(c => c.Id == id);
        }

        public void Delete(int? id)
        {
            var selectedProduct = _context.Categories.Find(id);
            _context.Categories.Remove(selectedProduct);

            _context.SaveChanges();
        }

    }
}
