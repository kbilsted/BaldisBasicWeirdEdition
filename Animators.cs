using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baldy
{
    static class Animator
    {
        static void TurnoffCursor(Action action)
        {
            var visible = Console.CursorVisible;
            if (visible)
                Console.CursorVisible = false;

            action();

            if (visible)
                Console.CursorVisible = true;
        }

        public static void AnimateSequence(string[] texts, TimeSpan delay)
        {
            TurnoffCursor(() =>
            {
                var coord = Console.GetCursorPosition();
                var height = texts[0].Count(c => c == '\n') + 1;
                if (coord.Top + height > Console.WindowHeight)
                {
                    // we first print the region to animate to ensure it is on the screen when we record the cursor position - otherwise the anim does not work
                    for (int i = 0; i < height; i++)
                        Console.WriteLine("");

                    coord.Top = Console.GetCursorPosition().Top - height;
                }

                foreach (var text in texts)
                {
                    Console.SetCursorPosition(coord.Left, coord.Top);
                    Console.WriteLine(text);

                    Thread.Sleep(delay);
                }
            });
        }

        public static void AnimateMoveFromLeft(string[] text, TimeSpan delay)
        {
            TurnoffCursor(() =>
            {
                var frames = text.Select(x => x.Split(new string[] { "\n", "\r\n" }, StringSplitOptions.None)).ToArray();
                var max = frames[0].Max(x => x.Length);

                foreach (var frame in frames)
                {
                    for (int i = 0; i < frame.Length; i++)
                    {
                        frame[i] = frame[i].PadRight(max, ' ');
                    }
                }

                var coord = Console.GetCursorPosition();
                for (var i = 0; i <= max; i++)
                {
                    Console.SetCursorPosition(coord.Left, coord.Top);
                    foreach (var paddedString in frames[i%frames.Length])
                    {
                        Console.WriteLine(paddedString[^i..]);
                    }
                    Thread.Sleep(delay);
                }
            });
        }

    }
}
