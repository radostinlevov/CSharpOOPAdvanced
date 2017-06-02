namespace DependencyInversion
{
    public delegate int Calculator(int firstOperand, int secondOperand);

    public class PrimitiveCalculator
    {
        private string mode;
        private AdditionStrategy additionStrategy;
        private SubtractionStrategy subtractionStrategy;

        public PrimitiveCalculator()
        {
            this.additionStrategy = new AdditionStrategy();
            this.subtractionStrategy = new SubtractionStrategy();
            this.mode = string.Empty;
        }

        public event Calculator CalcDivision;

        public event Calculator CalcMultiplication;

        public void ChangeStrategy(char @operator)
        {
            switch (@operator)
            {
                case '+':
                    this.mode = "Add";
                    break;
                case '-':
                    this.mode = "Subtract";
                    break;
                case '/':
                    this.mode = "Divide";
                    break;
                case '*':
                    this.mode = "Multiply";
                    break;
            }
        }

        public int PerformCalculation(int firstOperand, int secondOperand)
        {
            if (this.mode == "Divide")
            {
                return this.CalcDivision.Invoke(firstOperand, secondOperand);
            }
            else if (this.mode == "Multiply")
            {
                return this.CalcMultiplication.Invoke(firstOperand, secondOperand);
            }
            else if (this.mode == "Subtract")
            {
                return this.subtractionStrategy.Calculate(firstOperand, secondOperand);
            }
            else
            {
                return this.additionStrategy.Calculate(firstOperand, secondOperand);
            }
        }
    }
}
