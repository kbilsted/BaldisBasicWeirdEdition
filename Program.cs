
using Baldy;
using System.Media;

int problemNumber = 1;
int points = 0;
bool AllCorrectAnswers = false;
string[] correctTexts =
    [
    "Correct! :)",
        "You are amazing",
        "Wow!",
        "What! How are you doing this",
        "You're a genius"
   ];

//for (int i = 0;i<29;i++)
//    Console.WriteLine(i);
////AllCorrectAnswers = true;
//PrintTotalScore();
//Console.ReadKey();

Quiz();

void Quiz()
{
    problemNumber = 1;
    points = 0;
    AllCorrectAnswers = true;

    Console.Clear();
    Animator.AnimateMoveFromLeft(
        [
        @"
                                                                         ___        
        /-----------------------------------------------\               | B \___ / ~~\__   
        |   Welcome to Baldi's Basic weird edition      | ______________ \______ ======_)-+
        |   v1.05.6 by Zak McCracken & Zane McCracken   |                          |/      
        |   (c) Copyright 2024 - SkYBoUnD UPDATE!!!!!   |                          ()     
        \-----------------------------------------------/
",
        @"
                                                                         ___        
        /-----------------------------------------------\               | B \___ / ~~\__  |
        |   Welcome to Baldi's Basic weird edition      | ______________ \______ ======_)-+
        |   v1.05.6 by Zak McCracken & Zane McCracken   |                          |/     |
        |   (c) Copyright 2024 - SkYBoUnD UPDATE!!!!!   |                          ()     
        \-----------------------------------------------/
",
        ],
        TimeSpan.FromMilliseconds(20));

    //SoundPlayer d = new SoundPlayer();

    PrintPoints(points);
    AnimateTypeWriterLine("What is 1+1 ?");
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
    AnimateTypeWriterLine("What is 2+2 ?");
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
    AnimateTypeWriterLine("What is 3+3 ?");
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
    AnimateTypeWriterLine("What is 4+4 ?");
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
    AnimateTypeWriterLine("What is 5+5 ?");
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
    AnimateTypeWriterLine("What is 6+6 ?");
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
    AnimateTypeWriterLine("What is 8+8 ?");
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
    AnimateTypeWriterLine("What is 10+10 ?");
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
        Console.Write(s[^i..]);
        Console.SetCursorPosition(0, Console.GetCursorPosition().Top);
        Thread.Sleep(30);
    }

    Console.WriteLine("");
}

void AnimateTypeWriterLine(string s)
{
    s.ToList().ForEach(x => { Console.Write(x); Thread.Sleep(Random.Shared.Next(60)); });
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
    PrintAnswer2(text, "WRONG!!! Baldi is angry");
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

");


        var fireworks3 = new string[] {

        " \n" +
        " \n" +
        " \n" +
        "                       .|\n" +
        "                       | |\n" +
        "                       |'|            ._____\n" +
        "               ___    |  |            |.   |' .---\"|\n" +
        "       _    .-'   '-. |  |     .--'|  ||   | _|    |\n" +
        "    .-'|  _.|  |    ||   '-__  |   |  |    ||      |\n" +
        "    |' | |.    |    ||       | |   |  |    ||      |\n" +
        " ___|  '-'     '    \"\"       '-'   '-.'    '`      |____\n" +
        "~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n",

" \n" +
" \n" +
" \n" +
"                       .|\n" +
"                       | |\n" +
"                       |'|  '         ._____\n" +
"               ___    |  | .          |.   |' .---\"|\n" +
"       _    .-'   '-. |  | .   .--'|  ||   | _|    |\n" +
"    .-'|  _.|  |    ||   '-__  |   |  |    ||      |\n" +
"    |' | |.    |    ||       | |   |  |    ||      |\n" +
" ___|  '-'     '    \"\"       '-'   '-.'    '`      |____\n" +
"~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n",

" \n" +
" \n" +
" \n" +
"                       .|   _\\/_\n" +
"                       | |   /\\ \n" +
"                       |'|  '         ._____\n" +
"               ___    |  | .          |.   |' .---\"|\n" +
"       _    .-'   '-. |  | .   .--'|  ||   | _|    |\n" +
"    .-'|  _.|  |    ||   '-__  |   |  |    ||      |\n" +
"    |' | |.    |    ||       | |   |  |    ||      |\n" +
" ___|  '-'     '    \"\"       '-'   '-.'    '`      |____\n" +
"~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n",

" \n" +
" \n" +
"                            *  *\n" +
"                       .|  *_\\/_*\n" +
"                       | | * /\\ *\n" +
"                       |'|  *  *      ._____\n" +
"               ___    |  |            |.   |' .---\"|\n" +
"       _    .-'   '-. |  |     .--'|  ||   | _|    |\n" +
"    .-'|  _.|  |    ||   '-__  |   |  |    ||      |\n" +
"    |' | |.    |    ||       | |   |  |    ||      |\n" +
" ___|  '-'     '    \"\"       '-'   '-.'    '`      |____\n" +
"~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n",

" \n" +
" \n" +
"                            *  *\n" +
"                       .|  *    * \n" +
"                       | | *    * _\\/_\n" +
"          _\\/_         |'|  *  *   /\\ ._____\n" +
"           /\\  ___    |  |            |.   |' .---\"|\n" +
"       _    .-'   '-. |  |     .--'|  ||   | _|    |\n" +
"    .-'|  _.|  |    ||   '-__  |   |  |    ||      |\n" +
"    |' | |.    |    ||       | |   |  |    ||      |\n" +
" ___|  '-'     '    \"\"       '-'   '-.'    '`      |____\n" +
"~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n",

" \n" +
" \n" +
"                            *  *\n" +
"               _\\/_    .|  *    * .::.\n" +
"          .''.  /\\     | | *     :_\\/_:\n" +
"         :_\\/_:        |'|  *  * : /\\ :_____\n" +
"         : /\\ :___    |  |   o    '::'|.   |' .---\"|\n" +
"       _  '..-'   '-. |  |     .--'|  ||   | _|    |\n" +
"    .-'|  _.|  |    ||   '-__  |   |  |    ||      |\n" +
"    |' | |.    |    ||       | |   |  |    ||      |\n" +
" ___|  '-'     '    \"\"       '-'   '-.'    '`      |____\n" +
"~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n",

" \n" +
" \n" +
"               .''.          *  \n" +
"              :_\\/_:   .|         .::.\n" +
"          .''.: /\\ :   | |       :    :\n" +
"         :    :'..'    |'|  \\'/  :    :_____\n" +
"         :    :___    |  | = o =  '::'|.   |' .---\"|\n" +
"       _  '..-'   '-. |  |  /.\\.--'|  ||   | _|    |\n" +
"    .-'|  _.|  |    ||   '-__  |   |  |    ||      |\n" +
"    |' | |.    |    ||       | |   |  |    ||      |\n" +
" ___|  '-'     '    \"\"       '-'   '-.'    '`      |____\n" +
"~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n",

" \n" +
"                           _\\)/_\n" +
"               .''.         /(\\  \n" +
"              :    :   .|         _\\/_\n" +
"          .''.:    :   | |   :     /\\  \n" +
"         :    :'..'    |'|'.\\'/.'     ._____\n" +
"         :    :___    |  |-= o =-     |.   |' .---\"|\n" +
"       _  '..-'   '-. |  |.'/.\\:--'|  ||   | _|    |\n" +
"    .-'|  _.|  |    ||   '-__: |   |  |    ||      |\n" +
"    |' | |.    |    ||       | |   |  |    ||      |\n" +
" ___|  '-'     '    \"\"       '-'   '-.'    '`      |____\n" +
"~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n",

"                             .\n" +
"                           _\\)/_\n" +
"               .''.         /(\\   .''.\n" +
"              :    :   .|    '   :_\\/_:\n" +
"              :    :   | |   :   : /\\ :\n" +
"               '..'    |'|'. ' .' '..'._____\n" +
"               ___    |  |-=   =-     |.   |' .---\"|\n" +
"       _    .-'   '-. |  |.' . :--'|  ||   | _|    |\n" +
"    .-'|  _.|  |    ||   '-__: |   |  |    ||      |\n" +
"    |' | |.    |    ||       | |   |  |    ||      |\n" +
" ___|  '-'     '    \"\"       '-'   '-.'    '`      |____\n" +
"~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n",

"  \n" +
" \n" +
"                _\\/_              .''.\n" +
"                 /\\    .|        :    :\n" +
"                       | |       :    :\n" +
"                       |'|        '..'._____\n" +
"               ___    |  |            |.   |' .---\"|\n" +
"       _    .-'   '-. |  |     :--'|  ||   | _|    |\n" +
"    .-'|  _.|  |    ||   '-__: |   |  |    ||      |\n" +
"    |' | |.    |    ||       | |   |  |    ||      |\n" +
" ___|  '-'     '    \"\"       '-'   '-.'    '`      |____\n" +
"~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n",

"                              \\'/\n" +
"                *  *         = o =\n" +
"               *_\\/_*         /.\\ .''.\n" +
"               * /\\ *  .|        :    :\n" +
"                *  *   | |       :    :\n" +
"                       |'|        '..'._____\n" +
"               ___    |  |            |.   |' .---\"|\n" +
"       _    .-'   '-. |  |     :--'|  ||   | _|    |\n" +
"    .-'|  _.|  |    ||   '-__: |   |  |    ||      |\n" +
"    |' | |.    |    ||       | |   |  |    ||      |\n" +
" ___|  '-'     '    \"\"       '-'   '-.'    '`      |____\n" +
"~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n",

"                            '.\\'/.'\n" +
"                *  *        -= o =-\n" +
"               *    *       .'/.\\'.\n" +
"               *    *  .|      :\n" +
"                *  *   | | \n" +
"                       |'|            ._____\n" +
"               ___    |  |            |.   |' .---\"|\n" +
"       _    .-'   '-. |  |     :--'|  ||   | _|    |\n" +
"    .-'|  _.|  |    ||   '-__: |   |  |    ||      |\n" +
"    |' | |.    |    ||       | |   |  |    ||      |\n" +
" ___|  '-'     '    \"\"       '-'   '-.'    '`      |____\n" +
"~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n",

"                            '.\\'/.'\n" +
"                            -=   =-\n" +
"                   o        .'/.\\'.\n" +
"            o          .|      :\n" +
"                       | |        .:.\n" +
"                       |'|        ':' ._____\n" +
"               ___    |  |            |.   |' .---\"|\n" +
"       _    .-'   '-. |  |     :--'|  ||   | _|    |\n" +
"    .-'|  _.|  |    ||   '-__: |   |  |    ||      |\n" +
"    |' | |.    |    ||       | |   |  |    ||      |\n" +
" ___|  '-'     '    \"\"       '-'   '-.'    '`      |____\n" +
"~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n",

"                            '. ' .'\n" +
"                  \\'/       -     -\n" +
"           \\'/   = o =      .' . '.\n" +
"          = o =   /.\\  .|      :  .:::.\n" +
"           /.\\         | |       :::::::\n" +
"                       |'|        ':::'_____\n" +
"               ___    |  |            |.   |' .---\"|\n" +
"       _    .-'   '-. |  |     :--'|  ||   | _|    |\n" +
"    .-'|  _.|  |    ||   '-__: |   |  |    ||      |\n" +
"    |' | |.    |    ||       | |   |  |    ||      |\n" +
" ___|  '-'     '    \"\"       '-'   '-.'    '`      |____\n" +
"~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n",

"                   :\n" +
"            :   '.\\'/.'\n" +
"         '.\\'/.'-= o =-           .:::.\n" +
"         -= o =-.'/.\\'..|        :::::::\n" +
"         .'/.\\'.   :   | |       :::::::\n" +
"            :          |'|        ':::'_____\n" +
"               ___    |  |            |.   |' .---\"|\n" +
"       _    .-'   '-. |  |     :--'|  ||   | _|    |\n" +
"    .-'|  _.|  |    ||   '-__: |   |  |    ||      |\n" +
"    |' | |.    |    ||       | |   |  |    ||      |\n" +
" ___|  '-'     '    \"\"       '-'   '-.'    '`      |____\n" +
"~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n",

"                   :\n" +
"            :   '.\\'/.'\n" +
"         '.\\'/.'-=   =-       *   .:::.\n" +
"         -=   =-.'/.\\'..|        ::' '::\n" +
"         .'/.\\'.   :   | |       ::. .::\n" +
"            :          |'|        ':::'_____\n" +
"               ___    |  |            |.   |' .---\"|\n" +
"       _    .-'   '-. |  |     :--'|  ||   | _|    |\n" +
"    .-'|  _.|  |    ||   '-__: |   |  |    ||      |\n" +
"    |' | |.    |    ||       | |   |  |    ||      |\n" +
" ___|  '-'     '    \"\"       '-'   '-.'    '`      |____\n" +
"~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n",

"                   :          .\n" +
"            :   '. ' .'     _\\)/_\n" +
"         '. ' .'-     -      /(\\  .'''.\n" +
"         -     -.' . '..|     '  :     :\n" +
"         .' . '.   :   | |       :     :\n" +
"            :          |'|        '...'_____\n" +
"               ___    |  |            |.   |' .---\"|\n" +
"       _    .-'   '-. |  |     :--'|  ||   | _|    |\n" +
"    .-'|  _.|  |    ||   '-__: |   |  |    ||      |\n" +
"    |' | |.    |    ||       | |   |  |    ||      |\n" +
" ___|  '-'     '    \"\"       '-'   '-.'    '`      |____\n" +
"~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n",

"                              .\n" +
"                            _\\)/_        _\\/_\n" +
"                             /(\\   _\\/_   /\\\n" +
"                       .|     '     /\\\n" +
"                       | | \n" +
"                       |'|            ._____\n" +
"               ___    |  |            |.   |' .---\"|\n" +
"       _    .-'   '-. |  |     :--'|  ||   | _|    |\n" +
"    .-'|  _.|  |    ||   '-__: |   |  |    ||      |\n" +
"    |' | |.    |    ||       | |   |  |    ||      |\n" +
" ___|  '-'     '    \"\"       '-'   '-.'    '`      |____\n" +
"~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n",


"                              .          .''.\n" +
"                            _\\)/_  .''. :_\\/_:\n" +
"                             /(\\  :_\\/_:: /\\ :\n" +
"                       .|     '   : /\\ : '..'\n" +
"               o       | |         '..'\n" +
"                       |'|            ._____\n" +
"               ___    |  |            |.   |' .---\"|\n" +
"       _    .-'   '-. |  |     :--'|  ||   | _|    |\n" +
"    .-'|  _.|  |    ||   '-__: |   |  |    ||      |\n" +
"    |' | |.    |    ||       | |   |  |    ||      |\n" +
" ___|  '-'     '    \"\"       '-'   '-.'    '`      |____\n" +
"~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n",

"                                         .''.\n" +
"                                   .''. :    :\n" +
"                           _\\/_   :    ::    :\n" +
"              \\'/      .|   /\\    :    : '..'\n" +
"             = o =     | |    _\\/_ '..'\n" +
"              /.\\      |'|     /\\     ._____\n" +
"               ___    |  |            |.   |' .---\"|\n" +
"       _    .-'   '-. |  |     :--'|  ||   | _|    |\n" +
"    .-'|  _.|  |    ||   '-__: |   |  |    ||      |\n" +
"    |' | |.    |    ||       | |   |  |    ||      |\n" +
" ___|  '-'     '    \"\"       '-'   '-.'    '`      |____\n" +
"~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n",

" \n" +
"                           .''. \n" +
"               :          :_\\/_:\n" +
"            '.\\'/.'    .| : /\\.:'.\n" +
"            -= o =-    | | '.:_\\/_:\n" +
"            .'/.\\'.    |'|   : /\\ :   ._____\n" +
"               :__    |  |    '..'    |.   |' .---\"|\n" +
"       _    .-'   '-. |  |     :--'|  ||   | _|    |\n" +
"    .-'|  _.|  |    ||   '-__: |   |  |    ||      |\n" +
"    |' | |.    |    ||       | |   |  |    ||      |\n" +
" ___|  '-'     '    \"\"       '-'   '-.'    '`      |____\n" +
"~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n",

" \n" +
"                           .''. \n" +
"               :          :    :\n" +
"            '.\\'/.'    .| :   .:'.\n" +
"            -=   =-    | | '.:    :\n" +
"            .'/.\\'.    |'|   :    :   ._____\n" +
"               :__    |  |    '..'    |.   |' .---\"|\n" +
"       _    .-'   '-. |  |     :--'|  ||   | _|    |\n" +
"    .-'|  _.|  |    ||   '-__: |   |  |    ||      |\n" +
"    |' | |.    |    ||       | |   |  |    ||      |\n" +
" ___|  '-'     '    \"\"       '-'   '-.'    '`      |____\n" +
"~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n",

" \n" +
"                           .''. \n" +
"               :          :    :\n" +
"            '. ' .'    .| :   .:'.\n" +
"            -     -    | | '.:    :\n" +
"            .' . '.    |'|   :    :   ._____\n" +
"               :__    |  |    '..'    |.   |' .---\"|\n" +
"       _    .-'   '-. |  |     :--'|  ||   | _|    |\n" +
"    .-'|  _.|  |    ||   '-__: |   |  |    ||      |\n" +
"    |' | |.    |    ||       | |   |  |    ||      |\n" +
" ___|  '-'     '    \"\"       '-'   '-.'    '`      |____\n" +
"~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n" };


        Animator.AnimateSequence(fireworks3, TimeSpan.FromMilliseconds(130));

        Console.ForegroundColor = ConsoleColor.Gray;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(@"

You lost the game!

HAHA AHAHAH AHAHAHAHHA AHHAHAH 
");
        Animator.AnimateSequence(new[] {
@"





                              /""\
                          /'\|   |/'\
                      /'\|   |   |   |
                     |   |   |   |   |\
                     |   |   |   |   |  \
                     | *   *   *   * |>  >       
                     |                  /
                      |               /
                       |            /
                        \          |
                         |         |",

@"




                              /""\
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
                         |         |",

@"


                              /""\
                             |\./|
                             |   |
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
                         |         |",

@"

                              /""\
                             |\./|
                             |   |
                             |   |
                             |>*<|
                          /'\|   |/'\
                      /'\|   |   |   |
                     |   |   |   |   |\
                     |   |   |   |   |  \
                     | *   *   *   * |>  >       
                     |                  /
                      |               /
                       |            /
                        \          |
                         |         |",

@"
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
                         |         |",

        }, TimeSpan.FromMilliseconds(250));
        Console.ForegroundColor = ConsoleColor.Gray;
    }
}



