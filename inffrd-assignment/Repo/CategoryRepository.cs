using inffrd_assignment.Repo;
using inffrd_assignment.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using inffrd_assignment.DatabaseContext;
using Microsoft.EntityFrameworkCore;
using inffrd_assignment.Models;

namespace inffrd_assignment.Repo
{
    public class CategoryRepository : ICategory
    {
        InffrdDBContext _context;

        public CategoryRepository(InffrdDBContext context)
        {
            _context = context;
        }

        public List<Category> GetAllCatgory()
        {
            return _context.Category.Include(x => x.Expenses).ToList();
        }

        public List<Category> GetCatgory()
        {
            return _context.Category.ToList();
        }

        public void saveCategory()
        {
            throw new NotImplementedException();
        }
    }
}
