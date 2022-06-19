using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>()
            {
                new Car() { Id = 1, ColorId = 1, BrandId = 3, ModelYear = 2015, DailyPrice=1000, Description="Rahat, konforlu tatil yolculukları için birebir."},
                new Car() { Id = 2, ColorId = 1, BrandId = 1, ModelYear = 2005, DailyPrice=500, Description="Description 1"},
                new Car() { Id = 3, ColorId = 2, BrandId = 1, ModelYear = 2018, DailyPrice=700, Description="Description 2"},
                new Car() { Id = 4, ColorId = 2, BrandId = 2, ModelYear = 2010, DailyPrice=675, Description="Description 3"},
                new Car() { Id = 5, ColorId = 2, BrandId = 2, ModelYear = 2006, DailyPrice=950, Description="Description 4"},

            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car deletedCars = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(deletedCars);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
#pragma warning restore CS8625 // Cannot convert null literal to non-nullable reference type.
        {
            throw new NotImplementedException();
        }

        public Car GetCarById(int id)
        {
            Car filteredCars = _cars.SingleOrDefault(c => c.Id == id);
            return filteredCars;
        }

        public void Update(Car car)
        {
            Car updatedCars = _cars.SingleOrDefault(c => c.Id == car.Id);
            updatedCars.ColorId = car.ColorId;
            updatedCars.BrandId = car.BrandId;
            updatedCars.ModelYear  = car.ModelYear;
            updatedCars.DailyPrice = car.DailyPrice;
            updatedCars.Description = car.Description;

        }
    }
}
