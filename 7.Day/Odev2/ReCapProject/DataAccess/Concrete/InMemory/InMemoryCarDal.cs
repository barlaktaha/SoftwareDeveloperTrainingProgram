using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car {Id=1,BrandId=1,ColorId=1,ModelYear=2019,Description="Renault Clio",DailyPrice=130},
                new Car {Id=2,BrandId=2,ColorId=1,ModelYear=2020,Description="Fiat Egea",DailyPrice=169},
                new Car {Id=3,BrandId=2,ColorId=1,ModelYear=2020,Description="Fiat Doblo",DailyPrice=150},
                new Car {Id=4,BrandId=1,ColorId=2,ModelYear=2016,Description="Renault Kango",DailyPrice=120},
                new Car {Id=5,BrandId=3,ColorId=2,ModelYear=2021,Description="Toyota Corollo",DailyPrice=450},
            };

        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            //Car CarToDelete = null;
            //foreach (var c in _cars)
            //{
            //    if (car.Id == c.Id)
            //    {
            //        CarToDelete = c;
            //    }
            //}
            //_cars.Remove(CarToDelete);

            Car CarToDelete = _cars.SingleOrDefault(c => car.Id == c.Id);
            _cars.Remove(CarToDelete);


        }

       

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int brandId)
        {
           return _cars.Where(c => c.BrandId==brandId).ToList();
        }

        public void Update(Car car)
        {
            Car CarToUpdate = _cars.SingleOrDefault(c => car.Id == c.Id);
            car.BrandId = CarToUpdate.BrandId;
            car.ColorId = CarToUpdate.ColorId;
            car.DailyPrice = CarToUpdate.DailyPrice;
            car.Description = CarToUpdate.Description;
            car.Id = CarToUpdate.Id;
            car.ModelYear = CarToUpdate.ModelYear;
            
        }
    }
}
