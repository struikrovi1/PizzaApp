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
    public class BookingService
    {
        private readonly FafoDbContext _context;

        public BookingService(FafoDbContext context)
        {
            _context = context;
        }

        public void Add(Booking book)
        {

            _context.Add(book);
            _context.SaveChanges();
        }

        public void Update(Booking book)
        {

            _context.Update(book);
            _context.SaveChanges();
        }
        public List<Booking> GetAll()
        {
            return _context.Bookings.ToList();
        }
        public Booking GetById(int? id)
        {
            return _context.Bookings.FirstOrDefault(c => c.Id == id);
        }

      

        public void Delete(int? id)
        {
            var selectedProduct = _context.Bookings.Find(id);
            _context.Bookings.Remove(selectedProduct);

            _context.SaveChanges();
        }

    }
}
