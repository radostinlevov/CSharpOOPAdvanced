namespace DependencyInversion
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            PrimitiveCalculator calculator = new PrimitiveCalculator();

            calculator.CalcDivision += CalculatorCalcDivision;
            calculator.CalcMultiplication += CalculatorCalcMultiplication;

            string inputLine = Console.ReadLine();

            while (inputLine != "End")
            {
                string[] inputTokens = inputLine.Split();
                string firstElement = inputTokens[0];

                if (firstElement == "mode")
                {
                    char @operator = char.Parse(inputTokens[1]);

                    calculator.ChangeStrategy(@operator);
                }
                else
                {
                    int firstOperand = int.Parse(inputTokens[0]);
                    int secondOperand = int.Parse(inputTokens[1]);

                    Console.WriteLine(calculator.PerformCalculation(firstOperand, secondOperand));
                }

                inputLine = Console.ReadLine();
            }
        }

        private static int CalculatorCalcMultiplication(int firstOperand, int secondOperand)
        {
            return firstOperand * secondOperand;
        }

        private static int CalculatorCalcDivision(int firstOperand, int secondOperand)
        {
            return firstOperand / secondOperand;
        }
    }
}
