namespace EventImmplementationToMyWay
{
    using System;
    
    public class Startup
    {       
        public static void Main()
        {
            var name = Console.ReadLine();
            while (name != "End")
            {
                Dispatcher dispatcher = new Dispatcher(name);
                dispatcher.ChangeName();

                name = Console.ReadLine();
            }
        }

         
    }
}