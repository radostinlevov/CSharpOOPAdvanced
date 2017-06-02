namespace EventImplementation
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            Dispatcher dispatcher = new Dispatcher();
            Handler handler = new Handler();

            string input = Console.ReadLine();

            while (input != "End")
            {
               handler.OnDispatcherNameChange(dispatcher, new NameChangeEventArgs(input));

                input = Console.ReadLine();
            }
        }
    }
}
