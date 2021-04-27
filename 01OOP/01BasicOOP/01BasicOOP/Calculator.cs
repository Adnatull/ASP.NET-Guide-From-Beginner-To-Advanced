namespace _01BasicOOP
{
    public class Calculator
    {
        public int X { get; set; }
        public int Y { get; set; }

        public int Sum()
        {
            return X + Y;
        }

        public int Subtraction()
        {
            return X - Y;
        }

        public int Multiplication()
        {
            return X * Y;
        }

        public int Division()
        {
            return X / Y;
        }
    }
}
