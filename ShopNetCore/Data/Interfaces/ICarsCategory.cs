using ShopNetCore.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopNetCore.Data.Interfaces
{
    public interface ICarsCategory
    {
        //Возвращает список
        IEnumerable<Category> AllCategories { get; }


    }
}
