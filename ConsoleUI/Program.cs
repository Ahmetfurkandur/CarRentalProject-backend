using Business.Concrete.Managers;
using DataAccess.Concrete.InMemory;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("Car List: " + car.Id + " " + car.ModelYear + " " + car.DailyPrice + " " + car.Description);
            }
        }
    }
}