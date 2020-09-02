using System;
using System.Collections.Generic;

namespace inffrd_assignment.Models
{
    public partial class Expenses
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
