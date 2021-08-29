using System;

namespace MethodExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Good day, what is your name? ");
            string userName = Console.ReadLine();

            Console.WriteLine($"Hello {userName} what is your favorite color? ");
            string color = Console.ReadLine();

            Console.WriteLine($"Now that we know that your favorite color is {color} what is your favorite animal?");
            string favAnimal = Console.ReadLine();

            Console.WriteLine($"So your favorite animal is a {favAnimal} ? Interesting choice! What is your favorite band to listen to?");
            string favBand = Console.ReadLine();

            Console.WriteLine($"{favBand} is a great band to listen to!");
            Console.WriteLine($"Hello, my name is {userName}. My favorite color is {color}.Out of all the animals, my favorite is {favAnimal}.");
            Console.WriteLine($" My favorite band to listen to is {favBand}.");
            {
                Console.WriteLine("Please give me some numbers to add.");
                int num1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Please provide another number");
                int num2 = int.Parse(Console.ReadLine());

                int Sum = Add(num1, num2);
                Console.WriteLine($"The sum is {Sum}");
            }

            Console.WriteLine("Please give me some numbers to multiply");
            int numb1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Please provide another number");
            int numb2 = int.Parse(Console.ReadLine());

            int product = Multiply(numb1, numb2);
            Console.WriteLine($"The total is {product}");

            Console.WriteLine("Please give me some numbers to subtract");
            int numbr1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Please provide another number");
            int numbr2 = int.Parse(Console.ReadLine());

            int sub = Subtract(numbr1, numbr2);
            Console.WriteLine($"The total is {sub}");

            Console.WriteLine("Please give me some numbers to divide");
            int number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Please provide another number");
            int number2 = int.Parse(Console.ReadLine());

            int total = Divide(number1, number2);
            Console.WriteLine($"The total after division is {total}");

            Console.WriteLine("Please give me numbers to compute");
            int nu1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Please give me another number");
            int nu2 = int.Parse(Console.ReadLine());

            int remain = Modulus(nu1, nu2);

            Console.WriteLine($"The remainder is {remain}");




        }


        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
        public static int Multiply(int x, int y)
        {


            return x * y;
        }
        public static int Subtract(int x, int y)
        {
            return x - y;

        }
        public static int Divide(int x, int y)
        {
            return x / y;
        }
        public static int Modulus(int x, int y)
        {
            return x % y;
        }
        
        
       

    

    }

}
