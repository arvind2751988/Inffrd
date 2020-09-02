using inffrd_assignment.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using inffrd_assignment.Models;


namespace inffrd_assignment.Repo
{
    public interface ICategory
    {
        void saveCategory();
        List<Category> GetCatgory();
        List<Category> GetAllCatgory();

    }
}
