namespace DotNetFandamental0504.MyConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            string name;

            Console.WriteLine("What is your name ?");
            name = Console.ReadLine();
            Console.WriteLine("your name is " + name);

            Console.WriteLine("What is your last name ?");
            string lastName = Console.ReadLine();

            if (name.Length < 3 || lastName.Length < 3)
            {
                Console.WriteLine("Error: Name and Last name must be at least 3 characters!");
                return;
            }

            Console.WriteLine("What is your phone number ?");
            string phoneNumber = Console.ReadLine();

            if (phoneNumber.StartsWith("+98"))
            {
                phoneNumber = phoneNumber.Replace("+98", "0");
            }
            Console.WriteLine("your phone number is: " + phoneNumber);


            Console.WriteLine("What is your card(PAN) ?");
            string card = Console.ReadLine();

            if (card.Length >= 4)
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

            }

            Console.WriteLine("What is your national code ?");
            string code = Console.ReadLine();




        }
    }
}
