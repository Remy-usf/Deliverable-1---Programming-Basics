namespace Deliverable_1___Programming_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!"); //outputs Hello World
            Console.WriteLine(""); //used for spacing

            Console.WriteLine("Enter a user's name: ");  // takes user input and reads it back out
            string userName = Console.ReadLine();
            Console.WriteLine("The user's name is "+ userName);
            Console.WriteLine("");

            Console.WriteLine("Enter a user's age: ");  //takes user input, parses, and reads back out if input is in correct format
            int userAge = int.Parse(Console.ReadLine());
            Console.WriteLine("The user's age is "+ userAge);
        }
    }
}