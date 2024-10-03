namespace InterviewProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            ////Task 01
            /// Declare and initialize the following variables:
            string name = "John Doe";
            int age = 25;
            bool isAdmin = true;

            //Print the values of these variables to the console.

            Console.WriteLine(name);
            Console.WriteLine(age);
            Console.WriteLine(isAdmin);


            //Task 02
            // Write a program that takes an integer input from the user and prints out whether the number is even or odd.
            //
            Console.WriteLine("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }



            //Task 03
            //Write a program that prints out the numbers 1 to 10 using a for loop.
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }



            //Task 04
            //Declare and initialize an integer array with the values 2, 4, 6, 8, 10.
            int[] numbers = { 2, 4, 6, 8, 10 };
            int sum = 0;

            foreach (int num in numbers)
            {
                Console.WriteLine(num);
                sum += num;
            }

            Console.WriteLine("Sum of array elements: " + sum);


            // Task 05
            //Write a method named Greet that takes a string parameter name and prints out a personalized greeting message.
            static void Greet(string name)
            {
                Console.WriteLine("Hello, " + name + "!");
            }
            Greet("Alice");

        }
    }
}
