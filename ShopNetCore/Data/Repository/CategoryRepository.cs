using ShopNetCore.Data.Interfaces;
using ShopNetCore.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopNetCore.Data.Repository
{
    public class CategoryRepository : ICarsCategory
    {
        private readonly AppDBContent appDBContent;
        public CategoryRepository(AppDBContent _appDBContent)
        {
            appDBContent = _appDBContent;
        }
        IEnumerable<Category> ICarsCategory.AllCategories => appDBContent.Category;
    }
}
