namespace xUnit_NET_Framework_MWE
{
    public class SimpleCalculator
    {
        public int Add(int a, int b) => a + b;

        public int Subtract(int a, int b) => a - b;

        public int Multiply(int a, int b) => a * b;

        public double Divide(int a, int b)
        {
            if (b == 0)
                throw new System.DivideByZeroException("Cannot divide by zero");

            return (double)a / b;
        }
    }
}