namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(2,2));
            Console.WriteLine(Add(3.3,3.7));
            Console.WriteLine(Add(1,0,false));
        }

        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static double Add(double a, double b)
        {
            return a + b;
        }

        public static string Add(int a, int b, bool addOrNot)
        {
            if (addOrNot)
            {
                if (a + b != 1)
                {
                    return $"{a + b} dollars";
                }
                else
                {
                    return "1 dollar";
                }
            }
            else
            {
                return "ah ah ah it says not to add those";
            }
        }
    }
}

