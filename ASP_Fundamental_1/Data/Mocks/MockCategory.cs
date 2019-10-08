using ASP_Fundamental_1.Data.Interfaces;
using ASP_Fundamental_1.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Fundamental_1.Data.Mocks
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> AllCategories {
            get {
                return new List<Category> {
                    new Category { categoryName = "Electro cars", desc = "electro bla bla" },
                    new Category { categoryName = "Classic cars", desc = "Classic bla bla" },
                };
            }
        }
    }
}
