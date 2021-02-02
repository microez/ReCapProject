using Businness.Abstract;
using Businness.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            foreach (var x in carManager.GetAll())
            {
                Console.WriteLine(x.Description + "   " + x.DailyPrice + "TL");
            }
            Console.WriteLine("_______________________________________________________");
            Console.WriteLine();


            //BrandId to BrandName. Use this to print what given Id corresponds to (optional use)
            carManager.WhichBrand(2);
            //and GetById
            foreach (var x in carManager.GetById(2))
            {
                Console.WriteLine(x.Description);
            }
            Console.WriteLine();
            //update
            carManager.Update(new Car { CarId = 3, BrandId = 2, ColorId = 2, DailyPrice = "350", Description = "Audi A4 Sadece 350TL!", ModelYear = 2020 });
            
            //main tests are passed
        }
    }
}
