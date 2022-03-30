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
    public class ComboService
    {
        private readonly FafoDbContext _context;

        public ComboService(FafoDbContext context)
        {
            _context = context;
        }

        public void Add(Combo com)
        {

            _context.Add(com);
            _context.SaveChanges();
        }

        public void Update(Combo com)
        {

            _context.Update(com);
            _context.SaveChanges();
        }
        public List<Combo> GetAll()
        {
            return _context.Combos.OrderBy(x=>x.Id).ToList();
        }
        public Combo GetById(int? id)
        {
            return _context.Combos.FirstOrDefault(c => c.Id == id);
        }

        public async Task<List<Combo>> GetByIds(IEnumerable<int> ids)
        {
            return await _context.Combos

               .Where(c => ids.Contains(c.Id))
               .ToListAsync();
        }

        public void Delete(int? id)
        {
            var selectedProduct = _context.Combos.Find(id);
            _context.Combos.Remove(selectedProduct);

            _context.SaveChanges();
        }

    }
}
