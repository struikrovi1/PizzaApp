using DataAccess;
using Entitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class SliderService
    {
        private readonly FafoDbContext _context;

        public SliderService(FafoDbContext context)
        {
            _context = context;
        }


        public void Add(MainSlider slider)
        {

            _context.Add(slider);
            _context.SaveChanges();
        }

        public void Update(MainSlider slider)
        {

            _context.Update(slider);
            _context.SaveChanges();
        }
        public List<MainSlider> GetAll()
        {
            return _context.Sliders.OrderBy(x=>x.Id).ToList();
        }
        public MainSlider GetById(int? id)
        {
            return _context.Sliders.FirstOrDefault(c => c.Id == id);
        }

        public void Delete(int? id)
        {
            var selectedProduct = _context.Sliders.Find(id);
            _context.Sliders.Remove(selectedProduct);

            _context.SaveChanges();
        }





    }
}
