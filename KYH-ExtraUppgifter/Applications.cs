using System.Linq;

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
        //RandomAIChatbot();
        ChatBotBob();
    }

    private void ChatBotBob()
    {
        bool run = true;
        while (run)
        {
            Console.WriteLine("Wanna continue?");
            string input = Console.ReadLine();

            if (input == "NO" || input == "N")
            {
                run = false;
            }
            else if (input != "NO" || input != "N")
            {
                string response = generateResponse(input);

                Console.WriteLine(response);
            }
        }
    }

    private string generateResponse(string input)
    {

        if (input.Contains(input.ToUpper()) && input.Contains('?'))
        {
            return "Calm down, I know what im doing";
        }
        else if (input.Contains(input.ToUpper()))
        {
            return "Whoa, chill out";
        }
        else if (input.Contains('?'))
        {
            return "Sure";
        }
        else if (input == "bob".ToLower()|| input == "bob".ToUpper())
        {
            return "Fine, be that way!";
        }
        else
            return "Whatever";
    }
}