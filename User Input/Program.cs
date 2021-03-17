using System;

namespace User_Input
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter username:");
            string userName = Console.ReadLine();
            Console.WriteLine("Username is:" + userName);
            Console.WriteLine("Enter your age:");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your age is:" + age);
            Console.WriteLine("Enter your Bloodgroup:");
            string BloodGroup = Console.ReadLine();
            Console.WriteLine  ("Bloodgroup is:" + BloodGroup);
            Console.WriteLine("Solve this sum to prove you are human:");
            Console.WriteLine("9+5");
            int sum = Convert.ToInt32(Console.ReadLine());
            if (sum == 14)
                Console.WriteLine("Its correct");
            else
                Console.WriteLine("Its wrong. So you are a robot.");



        }
    }
}
