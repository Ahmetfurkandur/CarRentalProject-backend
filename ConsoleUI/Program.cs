using Business.Concrete.Managers;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace ConsoleUI
{
    internal class Program
    {
        static CarManager _carManager = new CarManager(new EfCarDal());
        static void Main(string[] args)
        {
            GetAll();
            Console.WriteLine("******************************** \n");
            GetCarsByBrandId();
            Console.WriteLine("******************************** \n");
            GetCarsByColorId(); 
            Console.WriteLine("******************************** \n");
            Add();
        }

        private static void GetCarsByBrandId()
        {
            Console.WriteLine("Marka Id'sini giriniz: ");
            int brandId = Convert.ToInt32(Console.ReadLine());

            foreach (var car in _carManager.GetCarsByBrandId(brandId))
            {
                Console.WriteLine("Filtered Car List: " + car.Id + " " + car.ModelYear + " " + car.DailyPrice + " " + car.Description);
            }

        }

        private static void GetCarsByColorId()
        {
            Console.WriteLine("Renk Id'sini giriniz: ");
            int colorId = Convert.ToInt32(Console.ReadLine());

            foreach (var car in _carManager.GetCarsByBrandId(colorId))
            {
                Console.WriteLine("Filtered Car List: " + car.Id + " " + car.ModelYear + " " + car.DailyPrice + " " + car.Description);
            }

        }

        static void GetAll()
        {
            foreach (var car in _carManager.GetAll())
            {
                Console.WriteLine("Car List: " + car.Id + " " + car.ModelYear + " " + car.DailyPrice + " " + car.Description);
            }
        }

        static void Add()
        {

            Console.WriteLine("Arabanın renk Id'sini giriniz: ");
            int colorId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Arabanın marka Id'sini giriniz: ");
            int brandId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Arabanın kaç model olduğunu giriniz: ");
            int modelYear = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Günlük fiyatı giriniz: ");
            int dailyPrice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Açıklama (örn: arabanın markası) giriniz: ");
            string description = Console.ReadLine();

            Car car = new Car()
            {
                ColorId = colorId,
                BrandId = brandId,
                ModelYear = modelYear,
                DailyPrice = dailyPrice,
                Description = description
            };

            _carManager.Add(car);

        }
    }
}