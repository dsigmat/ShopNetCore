using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using ShopNetCore.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopNetCore.Data
{
    public class DBObjects
    {
        public static void Initial(AppDBContent content)
            {                    
            if (!content.Category.Any())
                    content.Category.AddRange(Categories.Select(c => c.Value));

            if (!content.Car.Any())
                content.AddRange
                    (
                    new Car
                    {
                        Name = "Tesla",
                        ShortDesc = "Быстрый автомобиль",
                        LongDesc = "Красивый, быстрый и тихий автомобиль",
                        Img = "/img/1.jpg",
                        Price = 15000,
                        IsFavorite = true,
                        Available = true,
                        Category = Categories["Классические автомобили"]
                    },
                    new Car
                    {
                        Name = "Mercedes C class",
                        ShortDesc = "Уютный и большой",
                        LongDesc = "Удобный автомобиль для городской жизни",
                        Img = "/img/2.jpg",
                        Price = 14000,
                        IsFavorite = false,
                        Available = false,
                        Category = Categories["Электромобили"]
                    },
                    new Car
                    {
                        Name = "Tesla S",
                        ShortDesc = "Быстрый автомобиль",
                        LongDesc = "Красивый, быстрый и тихий автомобиль",
                        Img = "/img/3.jpg",
                        Price = 8000,
                        IsFavorite = false,
                        Available = true,
                        Category = Categories["Классические автомобили"]
                    },
                    new Car
                    {
                        Name = "BMW",
                        ShortDesc = "Дерзкий и стильный",
                        LongDesc = "Удобный автомобиль для городской жизни",
                        Img = "/img/4.jpg",
                        Price = 14000,
                        IsFavorite = true,
                        Available = true,
                        Category = Categories["Электромобили"]
                    }

                    );
            content.SaveChanges();

        }

        static Dictionary<string, Category> category;
        public static Dictionary<string, Category> Categories
            {
                get
                {
                if (category == null)
                {
                    var list = new Category[]
                    {
                        new Category { CategoryName = "Электромобили", Desc = "Соврменный вид транспорта" },
                        new Category { CategoryName = "Классические автомобили",Desc = "Машины с двигателем внутреннего сгорания" }
                    };
                    category = new Dictionary<string, Category>();
                    foreach (Category el in list)
                    {
                        category.Add(el.CategoryName, el);
                    }
                }
                return category;
            }
        }
    }
}
