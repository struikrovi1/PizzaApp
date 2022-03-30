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
    public class ChefService
    {
        private readonly FafoDbContext _context;

        public ChefService(FafoDbContext context)
        {
            _context = context;
        }

        public void Add(Chefs chef )
        {

            _context.Add(chef);
            _context.SaveChanges();
        }

        public void Update(Chefs chef)
        {

            _context.Update(chef);
            _context.SaveChanges();
        }
        public List<Chefs> GetAll()
        {
            return _context.Chefs.Include(x=>x.Category).ToList();
        }
        public Chefs GetById(int? id)
        {
            return _context.Chefs.Include(x => x.Category).FirstOrDefault(c => c.Id == id);
        }

       

        public void Delete(int? id)
        {
            var selectedProduct = _context.Chefs.Find(id);
            _context.Chefs.Remove(selectedProduct);

            _context.SaveChanges();
        }

    }
}
