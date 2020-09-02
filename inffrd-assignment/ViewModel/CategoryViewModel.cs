using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using inffrd_assignment.Models;

namespace inffrd_assignment.ViewModel
{
    public class CategoryViewModel
    {
       
            public CategoryViewModel()
            {
                Expenses = new HashSet<Expenses>();
            }

            public int Id { get; set; }
            public string Name { get; set; }

            public virtual ICollection<Expenses> Expenses { get; set; }
        
    }
    
}
