using System.IO.Pipelines;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace bakhPaziri
{
    internal class TamrinHa
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
            else if (firstNumber % secondNumber == 0)
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


            if (primeNumber2 == 1)
            {
                Console.WriteLine("this " + primeNumber2 + " is NOT Prime Number");
            }

            else if (primeNumber2 == 2 || primeNumber2 == 3 || primeNumber2 == 5 || primeNumber2 == 7)
            {
                Console.WriteLine("this " + primeNumber2 + " is Prime Number");
            }

            else if (primeNumber2 % 2 == 0 || primeNumber2 % 3 == 0 || primeNumber2 % 5 == 0 || primeNumber2 % 7 == 0)
            {

                Console.WriteLine("this " + primeNumber2 + " is NOT Prime Number");
            }

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


            Console.WriteLine("Enter number 2:");
            string input2 = Console.ReadLine();
            int num2 = Convert.ToInt32(input2);


            Console.WriteLine("Enter number 3:");
            string input3 = Console.ReadLine();
            int num3 = Convert.ToInt32(input3);

            int sum = num1 + num2 + num3;
            int average = sum / 3;
            Console.WriteLine("avrage is " + average);




            Console.WriteLine("Enter number 1:");
            string middle = Console.ReadLine();
            int middleInt = Convert.ToInt32(middle);


            Console.WriteLine("Enter number 2:");
            string middle2 = Console.ReadLine();
            int middleInt2 = Convert.ToInt32(middle2);


            Console.WriteLine("Enter number 3:");
            string middle3 = Console.ReadLine();
            int middleInt3 = Convert.ToInt32(input3);

            int median = 0;

            if ((num1 >= num2 && num1 <= num3) || (num1 >= num3 && num1 <= num2))
            {
                median = num1;
            }

            else if ((num2 >= num1 && num2 <= num3) || (num2 >= num3 && num2 <= num1))
            {
                median = num2;
            }

            else
            {
                median = num3;
            }


            Console.WriteLine("The Median is: " + median);
            ///////////////////////////////////////////////

            //    static int add(int[] items)
            //    {
            //        int resault = 0;
            //        for (int i = 0; i < items.Length; i++)
            //        {
            //            result = result + items[i];
            //        }
            //        return resault;
            //    }


            //    static int add(int[] items)
            //    {
            //        int result;
            //        foreach (var item in items)
            //        {
            //            result = result + item;
            //        }
            //        return result;

            //    }

            //    class Student
            //{
            //    public string Name;
            //    public int Age;
            //    public Guid Id;
            //}


            //int[] numbers = { 10, 20, 30, 40, 50 }; 
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //Console.WriteLine("Enter your name");
            //    string name = Console.ReadLine().ToLower();
            //    string character = "";
            //    for (int i = 0; i < name.Length; i++)
            //    {
            //        char currentChar = name[i];

            //        if (character.Contains(currentChar) ==  false)
            //        {
            //            int count = 0;

            //            for (int j = 0; j < name.Length; j++)
            //            {
            //                if (name[j] == currentChar)
            //                {
            //                    count++;
            //                }

            //            }
            //            Console.WriteLine($"word '{currentChar}' repeat : {count}");
            //            character += currentChar;
            //        }
            //    }


            //    Console.WriteLine("Enter a text:");
            //    string text = Console.ReadLine().ToLower();
            //    Console.WriteLine("Enter the character to search:");

            //    char searchChar = Convert.ToChar(Console.ReadLine().ToLower());


            //    bool isFound = false;


            //    for (int i = 0; i < text.Length; i++)
            //    {
            //                        if (text[i] == searchChar)
            //        {
            //            Console.WriteLine($"Character '{searchChar}' found at index/position: {i}");
            //            isFound = true;                 }
            //    }






            //Student[] students = new Student[3];


            //for (int i = 0; i < 3; i++)
            //{
            //    students[i] = new Student();

            //    Console.WriteLine("Enter info for Student " + (i + 1));

            //    Console.Write("Name: ");
            //    students[i].Name = Console.ReadLine();

            //    Console.Write("Age: ");
            //    students[i].Age = int.Parse(Console.ReadLine());

            //    students[i].Id = Guid.NewGuid();
            //    Console.WriteLine("Saved successfully!\n");
            //}


            //Console.WriteLine("first number");
            //int num1 = int.Parse(Console.ReadLine() ?? "0");
            //Console.WriteLine("second number ");
            //int num2 = int.Parse(Console.ReadLine() ?? "0");

            //int[] numbers = { num1, num2 };
            //int result = Add(numbers);
            //Console.WriteLine(result);


            //static int Add(int[] items)
            //{
            //    int sum = 0;
            //    foreach (int item in items)
            //    {
            //        sum = sum + item;
            //    }
            //    return sum;
            //}








            //Console.WriteLine("\n=== List of Students ===");
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine("Student " + (i + 1) + ": Name = " + students[i].Name + ", Age = " + students[i].Age + ", ID = " + students[i].Id);
            //}

            //for (int i  = 0; i <= 5; i++)
            //{
            //    Console.WriteLine(i * i);
            //}


            //for (int i = 0; i < 20; i++)
            //{
            //    if (i % 2 != 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}


            //for (int i = 0; i < 20; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        break;
            //    }
            //      Console.WriteLine(i);

            //}



            //while (true)
            //{
            //    Console.WriteLine(" enter your phone number ");
            //    phoneNumber = Console.ReadLine();

            //    if (phoneNumber.Length < 10 )
            //    {
            //        Console.WriteLine(" Error: please enter a valid number");
            //    }
            //    else
            //    {
            //        if (phoneNumber.StartsWith("+98"))
            //        {
            //            phoneNumber = phoneNumber.Replace("+98", "0");
            //        }
            //        break;
            //    }       
            //}


            //Console.WriteLine("first number");
            //int number1 = int.Parse(Console.ReadLine() ?? "0");
            //Console.WriteLine("second number "); 
            //int number2 = int.Parse(Console.ReadLine() ?? "0");
            //Console.WriteLine("third number");
            //int number3 = int.Parse(Console.ReadLine() ?? "0");
            //int plus = number1 + number2 + number3;
            //Console.WriteLine(plus);


            //Console.WriteLine("enter Length");
            //int Length = int.Parse(Console.ReadLine() ?? "0");
            //Console.WriteLine("enter Width");
            //int Width = int.Parse(Console.ReadLine() ?? "0");
            //int cross = Length * Width;
            //Console.WriteLine(cross);

            //Console.WriteLine("What is your name ?");
            //name = Console.ReadLine();
            //Console.WriteLine("your name is " + name);

            //Console.WriteLine("What is your last name ?");
            //string lastName = Console.ReadLine();

            //if (name.Length < 3 || lastName.Length < 3)
            //{
            //    Console.WriteLine("Error: Name or Last name must be at least 3 characters!");
            //    return;
            //}

            //Console.WriteLine("What is your phone number ?");
            //string phoneNumber = Console.ReadLine();

            //if (phoneNumber.StartsWith("+98"))
            //{
            //    phoneNumber = phoneNumber.Replace("+98", "0");
            //}
            //Console.WriteLine("your phone number is: " + phoneNumber);


            //Console.WriteLine("What is your card(PAN) ?");
            //string card = Console.ReadLine();

            //if (card.Length >= 4)
            //{
            //string bankCode = card.Substring(0, 4);

            //if (bankCode == "6037")
            //{
            //    Console.WriteLine("your bank is: Melli");
            //}
            //else if (bankCode == "6104")
            //{
            //    Console.WriteLine("your bank is: mellat");
            //}
            //else if (bankCode == "6221")
            //{
            //    Console.WriteLine("your bank is: parsian");
            //}
            //else if (bankCode == "6219")
            //{
            //    Console.WriteLine("your bank is: saman");
            //}
            //else
            //{
            //    Console.WriteLine("unknown bank");
            //}

            ////}

            //Console.WriteLine("What is your national code ?");
            //string code = Console.ReadLine();

            //int age = default;
            //Console.WriteLine("what is your birth year?");


            //for (; ; )
            //{
            //    if (!int.TryParse(Console.ReadLine(), out int birthYear))
            //    {
            //        Console.WriteLine("Please enter a valid year! (Numbers only)");
            //    }
            //    else
            //    {
            //        age = DateTime.Now.Year - birthYear;
            //        Console.WriteLine("Your age is: " + age);
            //        break;
            //    }
            //}

            //Console.WriteLine("Year?");
            //int year = 0;
            //int userAge = 0;

            //for (; ;)
            //{

            //    if (!int.TryParse(Console.ReadLine(), out year))
            //    {
            //        Console.WriteLine("Please enter a valid year!");
            //    }
            //    else
            //    {

            //        userAge = 1405 - year;
            //        Console.WriteLine("Your age is: " + userAge);

            //        break;
            //    }

            //for (int i = 0; i < 20; i++)
            //{
            //    if (i % 2 == 0)
            //        break;

            //}


            //int[] number = { 1, 2, 3, 4, };

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}


            //string sample = "amir pouyan";
            //char[] letters = sample.ToArray();
            //foreach (char letter in letters)
            //{
            //    Console.WriteLine(letter);
            //}



            //Console.WriteLine("Enter your first number");
            //string firstNumber = Console.ReadLine();
            //int num1 = Convert.ToInt32(firstNumber);
            //Console.WriteLine("Enter your second number");
            //string secondNumber = Console.ReadLine();
            //int num2 = Convert.ToInt32(secondNumber);
            //int resault = add(num1, num2);
            //Console.WriteLine(resault);




            //static int add(int num1, int num2)
            //{
            //    return num1 + num2;
            //}



            //Console.WriteLine("first number");
            //string firstNumber = Console.ReadLine();
            //int num1 = Convert.ToInt32(firstNumber);
            //Console.WriteLine("second number");
            //string secondNumber = Console.ReadLine();
            //int num2 = Convert.ToInt32(secondNumber);
            //Console.WriteLine("third number");
            //string thirdNumber = Console.ReadLine();
            //int num3 = Convert.ToInt32(thirdNumber);

            //int resualt = add( num1, num2, num3);
            //Console.WriteLine(resualt);

            //static int add(int num1 , int num2 , int num3)
            //{
            //    return num1 + num2 + num3;
            //}















        }
    }
}
