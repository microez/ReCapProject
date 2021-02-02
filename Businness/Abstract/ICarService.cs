using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Businness.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        List<Car> GetById(int brandId);
        void Update(Car car);
        void Delete(Car car);
        void Add(Car car);
        void WhichBrand(int brandId);
    }
}
