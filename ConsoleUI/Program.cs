using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.EntityFrameWork;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());


            //foreach (var brand in brandManager.GetAll())
            //{
            //    Console.WriteLine(brand.BrandName);
            //}


            //carManager.Add(new Car { CarId = 1, BrandId = 1, ColorId = 1, DailyPrice = 350, Description = "Opel Astra", ModelYear = 2020 });
            //carManager.Add(new Car { CarId = 2, BrandId = 2, ColorId = 2, DailyPrice = 300, Description = "Renault Clio", ModelYear = 2020 });
            //carManager.Add(new Car { CarId = 3, BrandId = 3, ColorId = 3, DailyPrice = 400, Description = "VolksWagen Golf", ModelYear = 2020 });
            //carManager.Add(new Car { CarId = 5, BrandId = 5, ColorId = 4, DailyPrice = 500, Description = "Mercedes A180", ModelYear = 2020 });
            var result = carManager.GetAll();
            if (result.Success)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.Description+" / "+car.DailyPrice);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
            //foreach (var car in carManager.GetAll().Data)
            //{
            //    Console.WriteLine(car.Description + "/" + car.DailyPrice);
            //}
            //carManager.Delete(new Car { CarId = 4 });
            //foreach (var car in carManager.GetAll())
            //{
            //    Console.WriteLine(car.Description);
            //}






        }
    }
}
