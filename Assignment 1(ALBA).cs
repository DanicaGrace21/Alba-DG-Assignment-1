namespace Assignment_1_ALBA_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = "Admin";
          
            string password = "Admin1234";
            
            int Tries = 3;

            while (Tries >= 1)
            {
                Console.Write("Username : ");
                string A = Console.ReadLine();

                Console.Write("Password : ");
                string B = Console.ReadLine();

                if (A == username && B == password) break;
                else
                {
                    Tries--;
                    Console.WriteLine("Wrong Credentials");
                    Console.WriteLine();

                    if (Tries >= 1)
                    {
                        Console.WriteLine(Tries + " more attempts");
                        Console.WriteLine();
                    }
                }
            }
            if (Tries >= 1)
            {
                Console.WriteLine("Login Successfully");
            }
            else
            {
                Console.WriteLine("maximum number of attempts made");
            }
        }
    }
}
