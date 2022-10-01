public class Applications
{
    public void RandomAIChatbot()
    {
        while (true)
        {
            Console.WriteLine("Skriv något till boten\n");
            var input = Console.ReadLine();

            var answer = AnswerFromBot(input);
            Console.WriteLine(answer);
        }
    }

    private string AnswerFromBot(string input)
    {
        string[] answers = new[]
        {"Jag mår bra",
        "Lämna mig ifred",
        "Vad sa du?",
        "whatever",
        "Kanske det",
        "Ingen aning",
        "Ja vad bra"};

        Random randomAnswer = new Random();
        int index = randomAnswer.Next(answers.Length);

        return $"{answers[index]}";
    }

    public void Run()
    {
        RandomAIChatbot();
    }
}