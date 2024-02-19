namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int favNumber = 13;
            Console.WriteLine("Try to guess my favorite number.");

            var userInput = int.Parse(Console.ReadLine());

            if (userInput >= 14)
            {
                Console.WriteLine("Your guess is too high!");

            }
            else if (userInput == 13)
            {
                Console.WriteLine("You're correct!");
            }
            else if (userInput <= 12)
            {
                Console.WriteLine("your guess is too low!");
            }
            else
            {
                Console.WriteLine("Nevermind.");
            }
        }
    }
}