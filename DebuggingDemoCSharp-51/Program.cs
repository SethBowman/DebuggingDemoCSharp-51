namespace DebuggingDemoCSharp_51;

class Program
{
    static void Main(string[] args)
    {
        //compile time errors
        //int number = "Hey";
        
        //runtime errors
        //throw exceptions

        // Console.WriteLine("Give me a number:");
        //
        // var userInput = int.Parse(Console.ReadLine());
        //
        // Console.WriteLine($"Your number is: {userInput}");
        
        // var numbers = new int[] { 1, 2, 3, 4 };
        //
        // Console.WriteLine(numbers[10]);
        
        //logical errors

        var name = "Bob";
        var age = 50;

        Console.WriteLine($"Hello my name is {age} and I am {name} years old.");
        
//<-- put breakpoint here
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i);
        }
    }
}
