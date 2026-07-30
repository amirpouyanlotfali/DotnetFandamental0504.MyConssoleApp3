using System;
using System.Globalization;

namespace DotNetFandamental0504.MyConsoleApp2
{
    internal class Program
    {
        class Student
        {
            public string Name;
            public int Age;
            public Guid Id;
        }
        static void Main(string[] args)
        {Console.WriteLine("Hello !");

            Student[] students = new Student[3];

           
            for (int i = 0; i < 3; i++)
            {
                students[i] = new Student();

                Console.WriteLine("Enter info for Student " + (i + 1));

                Console.Write("Name: ");
                students[i].Name = Console.ReadLine();

                Console.Write("Age: ");
                students[i].Age = int.Parse(Console.ReadLine());

                students[i].Id = Guid.NewGuid();
                Console.WriteLine("Saved successfully!\n");
            }

            
            Console.WriteLine("\n=== List of Students ===");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Student " + (i + 1) + ": Name = " + students[i].Name + ", Age = " + students[i].Age + ", ID = " + students[i].Id);
            }

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

            string name;
            do
            {
                Console.WriteLine("What is your name ?");
                name = Console.ReadLine();

                if (name.Length < 3)
                {
                    Console.WriteLine("Error: Name must be at least 3 characters!");
                }

            } while (name.Length < 3);


            string lastName;

            while (true)
            {
                Console.WriteLine("What is your last name ?");
                lastName = Console.ReadLine();

                if (lastName.Length < 3 )
                {
                    Console.WriteLine("Error: Last name  must be at least 3 characters!");
                }
                else
                {
                    break;
                }
            }

            string phoneNumber;

            while (true)
            {
                Console.WriteLine(" enter your phone number ");
                phoneNumber = Console.ReadLine();

                if (phoneNumber.Length < 10 )
                {
                    Console.WriteLine(" Error: please enter a valid number");
                }
                else
                {
                    if (phoneNumber.StartsWith("+98"))
                    {
                        phoneNumber = phoneNumber.Replace("+98", "0");
                    }
                    break;
                }       
            }

            string card;
            
            while (true)
            {
                Console.WriteLine("What is your card(PAN) ?");
                card = Console.ReadLine();

                if (card.Length < 16 )
                {
                    Console.WriteLine("Error: Card number must be at least 16 characters!");
                }
                else
                {
                    string bankCode = card.Substring(0, 4);

                    if (bankCode == "6037")
                    {
                        Console.WriteLine("your bank is: Melli");
                    }
                    else if (bankCode == "6104")
                    {
                        Console.WriteLine("your bank is: mellat");
                    }
                    else if (bankCode == "6221")
                    {
                        Console.WriteLine("your bank is: parsian");
                    }
                    else if (bankCode == "6219")
                    {
                        Console.WriteLine("your bank is: saman");
                    }
                    else
                    {
                        Console.WriteLine("unknown bank");
                    }
                    break;
                }
            }

            string code;

            while (true)
            {
                Console.WriteLine("What is your national code?");
                code = Console.ReadLine();

                if (code.Length != 10)
                {
                    Console.WriteLine("Error: National code must be exactly 10 digits!");
                }
                else
                {
                    break;
                }
            }









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

            int age = 0;
            Console.WriteLine("What is your birth year ? (For example: 1999 or 1378)");

            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out int birthYear))
                {
                    Console.WriteLine("Error: Please enter a valid number!");
                }
                else
                {
                    int currentMiladi = DateTime.Now.Year;

                    PersianCalendar pc = new PersianCalendar();
                    int currentShamsi = pc.GetYear(DateTime.Now);

                    if (birthYear < 1300)
                    {
                        Console.WriteLine("Error: Year is too old!");
                    }
                    else if (birthYear <= currentShamsi)
                    {
                        age = currentShamsi - birthYear;
                        Console.WriteLine("Your age based on Persian calendar is: " + age);
                        break;
                    }
                    else if (birthYear < 1900)
                    {
                        Console.WriteLine("Error: Year is out of range!");
                    }
                    else if (birthYear <= currentMiladi)
                    {
                        age = currentMiladi - birthYear;
                        Console.WriteLine("Your age based on Gregorian calendar is: " + age);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Error: Year cannot be in the future!");
                    }

                }

            }

            Guid userId = Guid.NewGuid();

            Console.WriteLine("----------------------------------");
            Console.WriteLine("Registration Successful!");
            Console.WriteLine("Your unique User ID is: " + userId);
            Console.WriteLine("----------------------------------");




        }
    }
}    
    

