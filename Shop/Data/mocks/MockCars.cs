using Shop.Data.interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.mocks
{
    public class MockCars : IAllCars
    {

        private readonly ICarsCategory _categoryCars = new MockCategory();

        public IEnumerable<Car> Cars
        {
            get
            {
                return new List<Car>
                {
                    new Car{
                        name = "Tesla",
                        shortDesc = "Швидкий автомобіль",
                        longDesc = "Красивий і швидкий автомобіль",
                        img = "/img/crewneck.jpg",
                        price = 45000,
                        isFavourite=true,
                        available=true,
                        Category = _categoryCars.AllCategories.First()
                    },
                    new Car {
                         name = "Ford Fiesta",
                        shortDesc = "Тихий і спокійний",
                        longDesc = "Зручний автомобіль для проживання у місті",
                        img = "/img/gucci_sneakers.jpg",
                        price = 50000,
                        isFavourite=false,
                        available=true,
                        Category = _categoryCars.AllCategories.Last()
                    },
                    new Car {
                         name = "BMW M3",
                        shortDesc = "Дєрзка і стильна",
                        longDesc = "Автомобіль для швидкості",
                        img = "/img/gucci_trousers.jpg",
                        price = 65000,
                        isFavourite=true,
                        available=true,
                        Category = _categoryCars.AllCategories.Last()
                    },
                    new Car {
                         name = "Mercedes C class",
                        shortDesc = "Комфортний і великий",
                        longDesc = "Зручний автомобіль",
                        img = "/img/sneakers.jpg",
                        price = 45000,
                        isFavourite=false,
                        available=false,
                        Category = _categoryCars.AllCategories.Last()
                    },
                    new Car {
                         name = "Nissan Leaf",
                        shortDesc = "Безшумний",
                        longDesc = "Автомобіль, з яким можна економити",
                        img = "/img/trousers.jpg",
                        price = 20000,
                        isFavourite=true,
                        available=true,
                        Category = _categoryCars.AllCategories.First()
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
                         Category = _categoryCars.AllCategories.First()
                    } };
            }
        }
        public IEnumerable<Car> getFavCars { get ; set; }

        public Car getOBjectCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
