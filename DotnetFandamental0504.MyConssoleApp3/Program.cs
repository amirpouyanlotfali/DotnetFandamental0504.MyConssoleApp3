using System.Text.RegularExpressions;
using System;
using System.Globalization;
using DotnetFandamental0504.MyConssoleApp3.Entity;
using DotnetFandamental0504.MyConssoleApp3.StartUp;

namespace DotNetFandamental0504.MyConsoleApp3
{
    internal class Program
    {
        
        static void Main(string[] args)
        {Console.WriteLine("Hello !");
           
            ShowWelcomeMessage messageObj = new ShowWelcomeMessage();

            
            messageObj.ShowWellcomeMessage();


            
            Student student = new Student();





       

            string firstname;
            do
            {
                Console.WriteLine("What is your name ?");
                firstname = Console.ReadLine();

                if (firstname.Length < 3)
                {
                    Console.WriteLine("Error: Name must be at least 3 characters!");
                }

            } while (firstname.Length < 3);


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



            string pattern = "^09\\d{9}$";
            string phoneNumber; 
            do
            {
                
                Console.WriteLine("Enter your phone number:");
                phoneNumber = Console.ReadLine();

                if (Regex.IsMatch(phoneNumber, pattern))
                {
                    Console.WriteLine("Phone number is VALID!");
                    break; 
                }
                else
                {
                    Console.WriteLine("Phone number is INVALID! Please enter a valid number");
                }

            } while (true);















            

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




            


           

            student.firstName = firstname;
            student.lastName = lastName;
            student.phoneNumber = phoneNumber;
            student.cart = card;
            student.code = code;

            student.age = age.ToString();













        }
    }
}    
    

