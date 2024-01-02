﻿
int problemNumber = 1;
int points = 0;
bool AllCorrectAnswers = true;
string[] correctTexts = new[] { "Correct! :)", "You are amazing", "Wow!", "What! How are you doing this", "You're a genius" };
Quiz();

void Quiz()
{
    Console.Clear();
    Console.WriteLine("            **********************************************************");
    Console.WriteLine("            ***       Welcome to Baldi's Basic weird edition       ***");
    Console.WriteLine("            ***       v1.04 by Zak McCracken & Zane McCracken      ***");
    Console.WriteLine("            ***       (c) Copyright 2024                           ***");
    Console.WriteLine("            **********************************************************");

    problemNumber = 1;
    points = 0;
    AllCorrectAnswers = true;

    PrintPoints(points);
    Console.WriteLine("What is 1+1 ?");
    var answer = ReadAnswer();
    if (answer == "window")
    {
        PrintCorrect();
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
        PrintCorrect();
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
        PrintCorrect();
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
        PrintCorrect();
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
        PrintCorrect();
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
        PrintCorrect();
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
        PrintCorrect();
        points = points + 3;
    }
    else
    {
        PrintAnswer("The answer is 'chain'");
    }



    PrintPoints(points);
    Console.WriteLine("What is 10+10 ?");
    answer = ReadAnswer();
    if (answer == "3====d")
    {
        PrintCorrect();
        points = points + 3;
    }
    else
    {
        PrintAnswer2("The answer is '3====D'", "You are an idiot! Baldi is insane >:(");
    }

    PrintTotalScore();

    if (WantToPlayAgain() == true)
        Quiz();
}

void AnimateFromLeft(string s)
{
    for (int i = 0; i <= s.Length; i++)
    {
        var s2 = s.Substring(s.Length - i);
        Console.Write(s2);
        Console.SetCursorPosition(0, Console.GetCursorPosition().Top);
        Thread.Sleep(30);
    }

    Console.WriteLine("");
}


string ReadAnswer()
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write($"PROBLEM {problemNumber}> ");
    Console.ForegroundColor = ConsoleColor.Gray;

    string answer = Console.ReadLine()!
        .ToLower()
        .Trim()
        .Replace("'", "");

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

    string answer = Console.ReadLine()!
        .ToLower()
        .Trim();

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
    PrintAnswer2(text,"WRONG!!! Baldi is angry");
}

void PrintAnswer2(string text, string curseText)
{
    Console.ForegroundColor = ConsoleColor.Red;
    AnimateFromLeft(curseText);
    Console.ForegroundColor = ConsoleColor.Gray;

    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine(text);
    Console.ForegroundColor = ConsoleColor.Gray;

    AllCorrectAnswers = false;
}


static void PrintPoints(int points)
{
    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"Points: {points}");
    Console.ForegroundColor = ConsoleColor.Gray;
}

void PrintCorrect()
{
    AnimateFromLeft(correctTexts[Random.Shared.Next(correctTexts.Length)]);
}

void PrintTotalScore()
{
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine($"Total score: {points}");
    if (AllCorrectAnswers)
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
