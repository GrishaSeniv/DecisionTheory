using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data
{
    public class DBObjects
    {
        public static void Initial(AppDBContent content)
        {
          
            if (!content.Category.Any())
                content.Category.AddRange(Categories.Select(c => c.Value));

            if (!content.Car.Any())
            {
                content.AddRange(

                    new Car
                    {
                        name = "Худі з принтом Gucci",
                        shortDesc = "Прекрасний вибір, якщо ТИ хочеш виглядати модним та сучасним",
                        longDesc = "Оригінальне худі від Gucci",
                        img = "/img/crewneck.jpg",
                        price = 2000,
                        isFavourite = true,
                        available = true,
                        Category = Categories["Електромобілі"]
                    },
                    new Car
                    {
                        name = "Кросівки Gucci",
                        shortDesc = "Легкі та елегантні",
                        longDesc = "Зручні та модні, чудовий вибір, щоб здивувати друзів",
                        img = "/img/gucci_sneakers.jpg",
                        price = 5000,
                        isFavourite = false,
                        available = true,
                        Category = Categories["Класичні автомобілі"]
                    },
                    new Car
                    {
                        name = "Штани Gucci",
                        shortDesc = "Штани, які зачаровують...",
                        longDesc = "Зручні штани саме для тебе",
                        img = "/img/gucci_trousers.jpg",
                        price = 3000,
                        isFavourite = true,
                        available = true,
                        Category = Categories["Класичні автомобілі"]
                    },
                    new Car
                    {
                        name = "Кросівки Gucci",
                        shortDesc = "Білі кросівки з принтом",
                        longDesc = "Зручні кросівки",
                        img = "/img/sneakers.jpg",
                        price = 2500,
                        isFavourite = false,
                        available = false,
                        Category = Categories["Класичні автомобілі"]
                    },
                    new Car
                    {
                        name = "Чорні штани",
                        shortDesc = "У наявності всі розміри",
                        longDesc = "ЕЕЕЕЕЕЕмейзінг-саме так відреагують твої друзі",
                        img = "/img/trousers.jpg",
                        price = 20000,
                        isFavourite = true,
                        available = true,
                        Category = Categories["Електромобілі"]
                    },

                     new Car
                     {
                         name = "Кросівки",
                         shortDesc = "Прекрасний вибір, якщо ТИ хочеш виглядати модним та сучасним",
                         longDesc = "Оригінальне худі від Gucci",
                         img = "/img/Ultrapace-sneaker.jpg",
                         price = 3000,
                         isFavourite = true,
                         available = true,
                         Category = Categories["Електромобілі"]

                     });
            }

            content.SaveChanges();

        }

        private static Dictionary<string, Category> category;
        public static Dictionary<string,Category> Categories
        {
            get
            {
                if(category == null)
                {
                    var list = new Category[]
                    {
                        new Category {categoryName = "Електромобілі", desc = "Сучасний вид транспорту"},
                        new Category {categoryName = "Класичні автомобілі", desc = "Машини з двигунами внутрішнього запалювання"},
                         new Category {categoryName = "Джинси", desc = "Найпопулярніший вибір молоді"}
                    };

                    category = new Dictionary<string, Category>();
                    foreach (Category el in list)
                        category.Add(el.categoryName, el);
                }

                return category;
            }
        }
    }
}
