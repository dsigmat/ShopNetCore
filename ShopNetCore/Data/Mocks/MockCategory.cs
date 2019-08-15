using ShopNetCore.Data.Interfaces;
using ShopNetCore.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopNetCore.Data.Mocks
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category
                    {
                        CategoryName = "Электромобили",
                        Desc = "Соврменный вид транспорта"
                    },
                    new Category
                    {
                        CategoryName = "Классические автомобили",
                        Desc = "Машины с двигателем внутреннего сгорания"
                    }
                };
            }
        }
    }
}
