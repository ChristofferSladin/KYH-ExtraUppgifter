using System.Linq;
using System.Text.RegularExpressions;

public class Applications
{
    public void ExtraAssignmentDigitsToText()
    {
        Console.WriteLine("Mata in en mening med tal i: ");
        string SentenceWithNumbers = Console.ReadLine();

        int result = SumAllDigitsInText(SentenceWithNumbers);

        Console.WriteLine(result);
    }

    public int SumAllDigitsInText(string stringWithNums)
    {
        ////                                                                            -----------------------------------------------------------------
        //stringWithNums = new string(stringWithNums.Where(Char.IsDigit).ToArray()); // FKN SMART LINQ!!!! Gör en array av char som är nummer med ToArray();
        ////                                                                            -----------------------------------------------------------------

        //------------------------------------------------------------------------------------------
        //If the character value is greater than or equal to ‘0’ and less than or equal to ‘9’
        //(i.e.ascii value between 48 to 57) then perform character – ‘0’
        //(this gives value of character) and add the value to the sum.
        //------------------------------------------------------------------------------------------

        int count, total = 0; // set both variabel values = 0;
        int n = stringWithNums.Length;
       
        for (count = 0; count < n; count++)
        {
            if ((stringWithNums[count] >= '0') && (stringWithNums[count] <= '9'))
            {
                total += stringWithNums[count] - '0';
            }
        }
        return total;
    }

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
    // ----------------------------------------------------------------------------------------------------
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
        else if (input == "bob".ToLower() || input == "bob".ToUpper())
        {
            return "Fine, be that way!";
        }
        else
            return "Whatever";
    }

    public void Run()
    {
        //RandomAIChatbot();
        //ChatBotBob();
        ExtraAssignmentDigitsToText();
    }
}