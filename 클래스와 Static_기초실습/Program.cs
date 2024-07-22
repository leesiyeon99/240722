namespace 클래스와_Static_기초실습
{
    internal class Program
    {
        static class MyCalculator
        {
            public static double Add(double first, double second)
            {
                return first + second;
            }

            public static double Subtract(double first, double second)
            {
                return first - second;
            }

            public static double Multiply(double first, double second)
            {
                return first * second;
            }

            public static double Divide(double first, double second)
            {
                if (second == 0)
                {
                    Console.WriteLine("두번째 값은 0이 될 수 없습니다.");
                    return 0;
                }
                else
                return first / second;

            }

            public static double Squarded(double first, double second)
            {
                double sum = 1;
                for (int i = 0; i < second; i++)
                {
                    sum *= first;
                }
                return sum;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(MyCalculator.Squarded(2,3));
            Console.WriteLine(MyCalculator.Divide(4,0));
        }
    }
}
