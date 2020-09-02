using inffrd_assignment.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using inffrd_assignment.Models;

namespace inffrd_assignment.Repo
{
  public interface IExpense
    {
        Expenses AddExpense(ExpenseViewModel model);

    }
}
