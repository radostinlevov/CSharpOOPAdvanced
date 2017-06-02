using System;
using Ferrari.Cars;

namespace Ferrari
{
    public class StartUp
    {
        public static void Main()
        {
            string nameOfDriver = Console.ReadLine();
            ICar car = new Cars.Ferrari(nameOfDriver);

            Console.WriteLine($"{car.Model}/{car.UseBrakes()}/{car.PushTheGasPedal()}/{car.NameOfDriver}");

            string ferrariName = typeof(Cars.Ferrari).Name;
            string iCarInterfaceName = typeof(ICar).Name;

            bool isCreated = typeof(ICar).IsInterface;
            if (!isCreated)
            {
                throw new Exception("No interface ICar was created");
            }
        }
    }
}
