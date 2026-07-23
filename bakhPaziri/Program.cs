using System.IO.Pipelines;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace bakhPaziri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your first number");
            string number1 = Console.ReadLine();
            int firstNumber = Convert.ToInt32(number1);
            Console.WriteLine("enter your second number");
            string number2 = Console.ReadLine();
            int secondNumber = Convert.ToInt32(number2);

            if (secondNumber == 0)
            {
                Console.WriteLine("Error: Cannot divide by zero!");
            }
            else if (firstNumber % secondNumber  == 0)
            {
                Console.WriteLine("Yes! " + number1 + " is divisible by " + number2);
            }
            else
            {

                Console.WriteLine("No! " + number1 + " is NOT divisible by " + number2);
            }

            Console.WriteLine("enter your number for check primeNumber");
            string primeNumber1 = Console.ReadLine();
            int primeNumber2 = Convert.ToInt32(primeNumber1);

            //2 3 5 7 اعداد اولن
            if (primeNumber2 == 1)
            {
                Console.WriteLine("this " + primeNumber2 + " is NOT Prime Number");
            }
            // شرط دوم: خودِ اعداد 2، 3، 5 و 7 قطعا اول هستند
            else if (primeNumber2 == 2 || primeNumber2 == 3 || primeNumber2 == 5 || primeNumber2 == 7)
            {
                Console.WriteLine("this " + primeNumber2 + " is Prime Number");
            }
            // شرط سوم: آیا این عدد به هیچ‌کدام از اعداد پایه بخش‌پذیر هست؟
            else if (primeNumber2 % 2 == 0 || primeNumber2 % 3 == 0 || primeNumber2 % 5 == 0 || primeNumber2 % 7 == 0)
            {
                // اگر باقیمانده تقسیمش به حتی یکی از این‌ها صفر بشه، یعنی مقسوم‌علیه داره و اول نیست
                Console.WriteLine("this " + primeNumber2 + " is NOT Prime Number");
            }
            // شرط آخر: اگر از تمام فیلترهای بالا جون سالم به در برد، قطعا عدد اوله!
            else
            {
                Console.WriteLine("this " + primeNumber2 + " is Prime Number");
            }


            if (primeNumber2 == 2)
            {
                Console.WriteLine("this " + primeNumber2 + "is Prime Number");
            }
            else if (primeNumber2 == 1)
            {
                Console.WriteLine("this " + primeNumber2 + "is NOT Prime Number");
            }

            Console.WriteLine("enter a number to check even or odd");
            string inputEvenOdd = Console.ReadLine();
            int numEvenOdd = Convert.ToInt32(inputEvenOdd);

            if (numEvenOdd % 2 == 0)
            {
                Console.WriteLine(numEvenOdd + "is Even.");
            }
            else
            {
                Console.WriteLine(numEvenOdd + "is Odd");
            }

            Random randomMachine = new Random();
            int randomNumber = randomMachine.Next(1, 1000);
            Console.WriteLine("The random number is: " + randomNumber);

            if (randomNumber % 5 == 0)
            {
                Console.WriteLine(randomNumber + " is divisible by 5.");
            }
            else
            {
                Console.WriteLine(randomNumber + " is NOT divisible by 5.");
            }


                Console.WriteLine("Enter number 1:");
            string input1 = Console.ReadLine();
            int num1 = Convert.ToInt32(input1);

            // دریافت عدد دوم
            Console.WriteLine("Enter number 2:");
            string input2 = Console.ReadLine();
            int num2 = Convert.ToInt32(input2);

            // دریافت عدد سوم
            Console.WriteLine("Enter number 3:");
            string input3 = Console.ReadLine();
            int num3 = Convert.ToInt32(input3);

            int sum = num1 + num2 + num3;
            int average = sum / 3;
            Console.WriteLine("avrage is " + average);




            Console.WriteLine("Enter number 1:");
            string middle = Console.ReadLine();
            int middleInt = Convert.ToInt32(middle);

            // دریافت عدد دوم
            Console.WriteLine("Enter number 2:");
            string middle2 = Console.ReadLine();
            int middleInt2 = Convert.ToInt32(middle2);

            // دریافت عدد سوم
            Console.WriteLine("Enter number 3:");
            string middle3 = Console.ReadLine();
            int middleInt3 = Convert.ToInt32(input3);

            int median = 0;

            if ((num1 >= num2 && num1 <= num3) || (num1 >= num3 && num1 <= num2))
            {
                median = num1;
            }
            // بررسی اینکه آیا عدد دوم (num2) در وسط قرار دارد؟
            else if ((num2 >= num1 && num2 <= num3) || (num2 >= num3 && num2 <= num1))
            {
                median = num2;
            }
            // اگر نه عدد اول وسط بود و نه عدد دوم، پس قطعاً عدد سوم (num3) در وسط است!
            else
            {
                median = num3;
            }

            // چاپ نتیجه نهایی
            Console.WriteLine("The Median is: " + median);







        }
    }
}
