using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using inffrd_assignment.Models;

namespace inffrd_assignment.ViewModel
{
    public class ExpenseViewModel
    {
        public int Id { get; set; }
        public int? CategoryId { get; set; }
        public DateTime? Year { get; set; }
        public decimal? Amount { get; set; }
        public bool? IsDeleted { get; set; }
        public bool? IsValid { get; set; }

        public virtual Category Category { get; set; }
    }
}
