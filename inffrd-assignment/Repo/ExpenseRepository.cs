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
    public class ExpenseRepository : IExpense
    {
        InffrdDBContext _context;

        public ExpenseRepository(InffrdDBContext context)
        {
            _context = context;
        }
        public Expenses AddExpense(ExpenseViewModel model)
        {
            var expense = new Expenses // Cannot await void
            {

                CategoryId = model.CategoryId,
                Amount = model.Amount,
                Year = model.Year,
                IsDeleted = false,
                IsValid = true, 
            };

             _context.Add(expense);
            var result =  _context.SaveChanges();
            if (result > 0)
                return expense;
            else
                return null;

           
        }
    }
}
