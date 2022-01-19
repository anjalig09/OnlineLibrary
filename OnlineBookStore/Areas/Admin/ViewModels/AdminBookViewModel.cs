using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OnlineBookStore.Models;
namespace OnlineBookStore.Areas.Admin.ViewModels
{
    public class AdminBookViewModel
    {
        public IEnumerable<Category> CategoriesList { get; set; }
        public Book Book  { get; set; }
        public Category Category { get; set; }
        

        
    }
}
