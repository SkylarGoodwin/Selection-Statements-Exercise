namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
          
            var r = new Random();
            var favNumber = r.Next(1,10);

            Console.WriteLine("Guess a number between 1 and 10");
            var userInput = int.Parse(Console.ReadLine());

            if (userInput > favNumber){
                Console.WriteLine("Too High!");}
            else if(userInput < favNumber){
                Console.WriteLine("Too Low!");}
            else if(userInput == favNumber){
                Console.WriteLine("Correct!");}
        }



        
    }
}
