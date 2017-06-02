using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Startup
    {
        static void Main()
        {
            try
            {
                Stack<string> stack = new Stack<string>();

                string inputLine = Console.ReadLine();

                while (inputLine != "END")
                {
                    string[] inputTokens = inputLine.Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
                    string command = inputTokens[0];

                    switch (command)
                    {
                        case "Push":
                            for (int i = 1; i < inputTokens.Length; i++)
                            {
                                stack.Push(inputTokens[i]);
                            }
                            break;
                        case "Pop":
                            stack.Pop();
                            break;
                    }

                    inputLine = Console.ReadLine();
                }

                stack.ToList().ForEach(e => Console.WriteLine(e));
                stack.ToList().ForEach(e => Console.WriteLine(e));
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
