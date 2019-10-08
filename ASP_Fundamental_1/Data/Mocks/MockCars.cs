using ASP_Fundamental_1.Data.Interfaces;
using ASP_Fundamental_1.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Fundamental_1.Data.Mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory _categoryCars = new MockCategory();
        public IEnumerable<Car> Cars {
            get { 
            return new List<Car> { 
                new Car { 
                    name = "Tesla", 
                    shortDesc = "short desc", 
                    longtDesc= "long desc", 
                    img = "",  
                    price = 45000, 
                    isFavourite = true,  
                    available = true, 
                    Category =  _categoryCars.AllCategories.First()}
                };
            }
        }
        public IEnumerable<Car> getFavCars { get; set ; }

        public Car getObjectCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
