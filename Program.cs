
int problemNumber = 1;
int points = 0;
bool harSvaretRigtigtPåAlt = true;

Quiz();

void Quiz()
{
    Console.Clear();
    Console.WriteLine("            *********************************************************");
    Console.WriteLine("            ***      Welcome to Baldi's Basic weird edition       ***");
    Console.WriteLine("            ***       v1.0 (c) Copyright 2024, Zak McCracken      ***");
    Console.WriteLine("            *********************************************************");

    problemNumber = 1;
    points = 0;
    harSvaretRigtigtPåAlt = true;

    PrintPoints(points);
    Console.WriteLine("What is 1+1 ?");
    var answer = ReadAnswer();
    if (answer == "window")
    {
        Console.WriteLine("Correct! :)");
        points = points + 3;
    }
    else
    {
        PrintAnswer("The answer is 'window'");
    }


    PrintPoints(points);
    Console.WriteLine("What is 2+2 ?");
    answer = ReadAnswer();
    if (answer == "fish")
    {
        Console.WriteLine("Correct! :)");
        points = points + 3;
    }
    else
    {
        PrintAnswer("The answer is 'fish'");
    }

    PrintPoints(points);
    Console.WriteLine("What is 3+3 ?");
    answer = ReadAnswer();
    if (answer == "8")
    {
        Console.WriteLine("Correct! :)");
        points = points + 3;
    }
    else
    {
        PrintAnswer("The answer is '8'");
    }


    PrintPoints(points);
    Console.WriteLine("What is 4+4 ?");
    answer = ReadAnswer();
    if (answer == "arrow")
    {
        Console.WriteLine("Correct! :)");
        points = points + 3;
    }
    else
    {
        PrintAnswer("The answer is 'arrow'");
    }




    PrintPoints(points);
    Console.WriteLine("What is 5+5 ?");
    answer = ReadAnswer();
    if (answer == "apple")
    {
        Console.WriteLine("Correct! :)");
        points = points + 3;
    }
    else
    {
        PrintAnswer("The answer is 'apple'");
    }



    PrintPoints(points);
    Console.WriteLine("What is 6+6 ?");
    answer = ReadAnswer();
    if (answer == "yin and yang")
    {
        Console.WriteLine("Correct! :)");
        points = points + 3;
    }
    else
    {
        PrintAnswer("The answer is 'yin and yang'");
    }



    PrintPoints(points);
    Console.WriteLine("What is 8+8 ?");
    answer = ReadAnswer();
    if (answer == "chain")
    {
        Console.WriteLine("Correct! :)");
        points = points + 3;
    }
    else
    {
        PrintAnswer("The answer is 'chain'");
    }

    PrintTotalScore();

    if (WantToPlayAgain() == true)
        Quiz();
}




string ReadAnswer()
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write($"PROBLEM {problemNumber}> ");
    Console.ForegroundColor = ConsoleColor.Gray;

    string answer = Console.ReadLine()
        .ToLower()
        .Trim()
        .Replace("'","");

    if (string.IsNullOrEmpty(answer))
    {
        Console.WriteLine("What is your answer??? :(");
        return ReadAnswer();
    }

    problemNumber = problemNumber + 1;

    return answer;
}

string ReadAnswerWithoutProblem()
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write($"> ");
    Console.ForegroundColor = ConsoleColor.Gray;

    string answer = Console.ReadLine().ToLower().Trim();

    if (string.IsNullOrEmpty(answer))
    {
        Console.WriteLine("What is your answer??? :(");
        return ReadAnswerWithoutProblem();
    }

    return answer;
}


bool WantToPlayAgain()
{
    Console.WriteLine("");
    Console.WriteLine("Do you want to play again? Y/N");

    var answer = ReadAnswerWithoutProblem();
    if (answer == "n")
        return false;   
    if (answer == "y")
        return true;
    return WantToPlayAgain();
}

void PrintAnswer(string text)
{
    Console.WriteLine("WRONG!!! Baldi is angry");

    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine(text);
    Console.ForegroundColor = ConsoleColor.Gray;

    harSvaretRigtigtPåAlt = false;
}


static void PrintPoints(int points)
{
    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"Points: {points}");
    Console.ForegroundColor = ConsoleColor.Gray;
}


void PrintTotalScore()
{
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine($"Total score: {points}");
    if (harSvaretRigtigtPåAlt)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;

        Console.WriteLine(@"
hurraaayyy you beat the game! 

       .''.      .        *''*    :_\/_:     . 
      :_\/_:   _\(/_  .:.*_\/_*   : /\ :  .'.:.'.
  .''.: /\ :   ./)\   ':'* /\ * :  '..'.  -=:o:=-
 :_\/_:'.:::.    ' *''*    * '.\'/.' _\(/_'.':'.'
 : /\ : :::::     *_\/_*     -= o =-  /)\    '  *
  '..'  ':::'     * /\ *     .'/.\'.   '
      *            *..*         :
        *
        *
");
        Console.ForegroundColor = ConsoleColor.Gray;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(@"

You lost the game!

HAHA AHAHAH AHAHAHAHHA AHHAHAH 

                              /""\
                             |\./|
                             |   |
                             |   |
                             |>*<|
                             |   |
                          /'\|   |/'\
                      /'\|   |   |   |
                     |   |   |   |   |\
                     |   |   |   |   |  \
                     | *   *   *   * |>  >       
                     |                  /
                      |               /
                       |            /
                        \          |
                         |         |
                     
");
        Console.ForegroundColor = ConsoleColor.Gray;
    }
}
