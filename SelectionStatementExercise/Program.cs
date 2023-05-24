namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            var favNumber = r.Next(1,10);
            Console.WriteLine("Try to guess my favorite number");
            var userInput = int.Parse(Console.ReadLine());

            if (userInput > favNumber)
            {
                Console.WriteLine("A bit lower");
            }
            else if (userInput == favNumber)
            {
                Console.WriteLine("Correct!");
            }
            else
            {
                Console.WriteLine("A bit higher");
            }









        }

    }

}
