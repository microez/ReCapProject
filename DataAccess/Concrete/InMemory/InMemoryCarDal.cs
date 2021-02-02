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
        List<Car> _car;
        List<Model> _models;
        public InMemoryCarDal()
        {
            _car = new List<Car>()
            {
            new Car{CarId=1, BrandId=1, ColorId=1, DailyPrice="500", Description="Mercedes C Coupe Otomatik Benzinli", ModelYear=2018},
            new Car{CarId=2, BrandId=1, ColorId=5, DailyPrice="300", Description="Mercedes CLA 200 Otomatik Benzinli", ModelYear=2016},
            new Car{CarId=3, BrandId=2, ColorId=2, DailyPrice="700", Description="Audi A4 Otomatik Dizel", ModelYear=2020},
            new Car{CarId=4, BrandId=2, ColorId=1, DailyPrice="500", Description="Audi A7 Otomatik Dizel", ModelYear=2012},
            new Car{CarId=5, BrandId=3, ColorId=1, DailyPrice="1400", Description="Porsche Panamera Otomatik Dizel", ModelYear=2013},
            new Car{CarId=6, BrandId=4, ColorId=1, DailyPrice="2750", Description="Ford Mustang Cabrio Otomatik Benzinli", ModelYear=2017}
            };

            _models = new List<Model>()
            {
                new Model {BrandId=1, BrandName="Mercedes" },
                new Model {BrandId=2, BrandName="Audi"},
                new Model {BrandId=3, BrandName="Porsche"},
                new Model {BrandId=4, BrandName="Mustang" }
            };
        }

        public void Add(Car car)
        {
            _car.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _car.SingleOrDefault(p => p.CarId == car.CarId);
            _car.Remove(carToDelete);
        }

        public List<Car> GetById(int brandId)
        {
            return _car.Where(p => p.BrandId == brandId).ToList();
        }

        //self-made BrandId to BrandName (optional use in UI) ONLY USE BEFORE GetById
        public void WhichBrand(int brandId)
        {
            foreach (var x in _models.Where(p => p.BrandId == brandId))
            {
                Console.WriteLine(x.BrandName + " Listesi:");
            }
        }

        public void Update(Car car)
        {
            Car carToUpdate = _car.SingleOrDefault(p => p.CarId == car.CarId);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;

            Console.WriteLine("Id:"+car.CarId+" have been updated --> "+carToUpdate.Description);
        }

        public List<Car> GetAll()
        {
            return _car;
        }
    }
}
