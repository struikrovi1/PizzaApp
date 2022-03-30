using DataAccess;
using Entitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class BlogService
    {
        private readonly FafoDbContext _context;

        public BlogService(FafoDbContext context)
        {
            _context = context;
        }

        public void Add(Blog blog)
        {

            _context.Add(blog);
            _context.SaveChanges();
        }

        public void Update(Blog blog)
        {

            _context.Update(blog);
            _context.SaveChanges();
        }
        public List<Blog> GetAll()
        {
            return _context.Blogs.OrderBy(x=>x.Id).ToList();
        }
        public Blog GetById(int? id)
        {
            return _context.Blogs.FirstOrDefault(c => c.Id == id);
        }

        public void Delete(int? id)
        {
            var selectedProduct = _context.Blogs.Find(id);
            _context.Blogs.Remove(selectedProduct);

            _context.SaveChanges();
        }

    }
}
