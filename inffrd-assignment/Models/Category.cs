using System;
using System.Collections.Generic;

namespace inffrd_assignment.Models
{
    public partial class Category
    {
        public Category()
        {
            Expenses = new HashSet<Expenses>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Expenses> Expenses { get; set; }
    }
}
