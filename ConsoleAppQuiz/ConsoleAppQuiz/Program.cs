namespace ConsoleAppQuiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Quiz quiz = new Quiz();

            Console.WriteLine("Korte QUIZ\n~~~~~~~~~~~~~~");

            while (!quiz.isGeeindigd)
            {
                Console.Write(quiz.StelVraag());
                string strAntwoord = Console.ReadLine();
                int intAntwoord;
                while (!(int.TryParse(strAntwoord, out intAntwoord) && intAntwoord == 1 || intAntwoord == 2 || intAntwoord == 3))
                {
                    Console.Write("Geef een getal in: ");
                    strAntwoord = Console.ReadLine();
                }
                Console.WriteLine(quiz.ControleerAntwoord(intAntwoord));
                Console.WriteLine(quiz.Score());
                quiz.GaNaarVolgendeVraag();
                Console.ReadLine();
            }
            Console.WriteLine("Einde van de quiz!");
        }
    }
}