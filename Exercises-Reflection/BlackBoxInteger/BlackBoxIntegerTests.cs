namespace _02BlackBoxInteger
{
    using System;
    using System.Reflection;

    public class BlackBoxIntegerTests
    {
        public static void Main()
        {
            var type = typeof(BlackBoxInt);
            var classInstance = Activator.CreateInstance(type, true);
            var bindingFlags = BindingFlags.Instance | BindingFlags.NonPublic;

            var field = type.GetField("innerValue", bindingFlags);

            string inputLine = Console.ReadLine();

            while (inputLine != "END")
            {
                string[] inputTokens = inputLine.Split(new[] { "_" }, StringSplitOptions.RemoveEmptyEntries);
                string command = inputTokens[0];
                int value = int.Parse(inputTokens[1]);
                MethodInfo method = null;

                switch (command)
                {
                    case "Add":
                        method = type.GetMethod("Add", bindingFlags);
                        break;
                    case "Subtract":
                        method = type.GetMethod("Subtract", bindingFlags);
                        break;
                    case "Divide":
                        method = type.GetMethod("Divide", bindingFlags);
                        break;
                    case "Multiply":
                        method = type.GetMethod("Multiply", bindingFlags);
                        break;
                    case "RightShift":
                        method = type.GetMethod("RightShift", bindingFlags);
                        break;
                    case "LeftShift":
                        method = type.GetMethod("LeftShift", bindingFlags); 
                        break;
                }

                method.Invoke(classInstance, new object[] { value });

                Console.WriteLine(field.GetValue(classInstance));

                inputLine = Console.ReadLine();
            }
        }
    }
}
