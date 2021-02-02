using Businness.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Businness.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }
        public List<Car> GetById(int brandId)
        {
            return _carDal.GetById(brandId);
        }
        public void Update(Car car)
        {
            _carDal.Update(car);
        }
        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }
        public void Add(Car car)
        {
            _carDal.Add(car);
        }

        public void WhichBrand(int brandId)
        {
            _carDal.WhichBrand(brandId);
        }
    }
}
