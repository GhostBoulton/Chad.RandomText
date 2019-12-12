using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Chad.RandomText.Lib;

namespace Chad.RandomText.ConsoleApp
{
    class Program
    {
        private const int STD_OUTPUT_HANDLE = -11;
        private const uint ENABLE_VIRTUAL_TERMINAL_PROCESSING = 0x0004;
        private const uint DISABLE_NEWLINE_AUTO_RETURN = 0x0008;

        [DllImport("kernel32.dll")]
        private static extern bool GetConsoleMode(IntPtr hConsoleHandle, out uint lpMode);

        [DllImport("kernel32.dll")]
        private static extern bool SetConsoleMode(IntPtr hConsoleHandle, uint dwMode);

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern IntPtr GetStdHandle(int nStdHandle);

        [DllImport("kernel32.dll")]
        public static extern uint GetLastError();

        static void Main(string[] args)
        {
            var iStdOut = GetStdHandle(STD_OUTPUT_HANDLE);
            if (!GetConsoleMode(iStdOut, out uint outConsoleMode))
            {
                Console.WriteLine("failed to get output console mode");
                Console.ReadKey();
                return;
            }

            outConsoleMode |= ENABLE_VIRTUAL_TERMINAL_PROCESSING | DISABLE_NEWLINE_AUTO_RETURN;
            if (!SetConsoleMode(iStdOut, outConsoleMode))
            {
                Console.WriteLine($"failed to set output console mode, error code: {GetLastError()}");
                Console.ReadKey();
                return;
            }

            // RunRandomTextGenerator();
            //Task.Run(() => TaskExamples.Run());
            TaskExamples.Run();

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();

            return;

        }

        private static void RunRandomTextGenerator()
        {
            Console.WriteLine($"{Ansi.MAGENTA}RANDOM TEXT GENERATOR!{Ansi.GRAY_0}");
            Console.WriteLine($"{Ansi.MAGENTA}----------------------{Ansi.GRAY_0}");
            Console.WriteLine($"{Ansi.MAGENTA}-------type G to gen--{Ansi.GRAY_0}");
            Console.WriteLine($"{Ansi.MAGENTA}-------type C to con--{Ansi.GRAY_0}");

            var exitKey = Console.ReadLine();
            while (exitKey == "G")
            {
                GenerateText();
                exitKey = Console.ReadLine();
            }

            if (exitKey == "C")
            {
                if (AskForPath("source", out var path) && AskForPath("output", out var outputPath))
                {
                    // GenerateText()
                    try
                    {
                        var generator = new RandomTextGenerator { SourcePath = path, OutputPath = outputPath };
                        generator.Parse(30000);

                        Console.WriteLine($"{Ansi.MAGENTA}{generator.OutputMessage}{Ansi.GRAY_0}");
                        // Console.WriteLine($"{Ansi.GREEN_BACK}{generator.View()}{Ansi.GRAY_0}");
                        Console.WriteLine($"{Ansi.GREEN_BACK}{generator.Print(500)}{Ansi.GRAY_0}");
                        Console.WriteLine($"{Ansi.RED_1}Press any key to exit.{Ansi.GRAY_0}");

                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                        Console.WriteLine("Error, Press key to exit.");
                    }
                    var exitKeys = Console.ReadLine();
                }
            }
        }

        private static void GenerateText()
        {
            try
            {
                // var generator = new RandomTextGenerator {SourcePath = path, OutputPath = outputPath };
                var generator = new RandomTextGenerator { SourcePath = "c:/logs/radiohead_lyrics_07-20-19.txt", OutputPath = $"c:/logs/output_{DateTime.Now.Minute}.txt" };
                generator.Parse(int.MaxValue);

                Console.WriteLine($"{Ansi.MAGENTA}{generator.OutputMessage}{Ansi.GRAY_0}");
                // Console.WriteLine($"{Ansi.BRIGHT_GREEN}{generator.ViewChar()}{Ansi.GRAY_0}");
                Console.WriteLine($"{Ansi.GREEN_BACK}{generator.Print(900)}{Ansi.GRAY_0}");
                Console.WriteLine($"{Ansi.RED_1}Press any key to exit.{Ansi.GRAY_0}");

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.WriteLine("Error, Press key to exit.");
            }
        }

        private static bool AskForPath(string pathType, out string path)
        {
            Console.WriteLine($"{Ansi.GRAY_0} Please enter path for {Ansi.MAGENTA}{pathType}{Ansi.GRAY_0} text.{Ansi.GREEN_BACK} e.g: C:/files/bom.txt{Ansi.BLACK_BACK}{Ansi.GRAY_0}");

            path = Console.ReadLine();
            Console.WriteLine($"{Ansi.GRAY_0} Your {Ansi.MAGENTA}{pathType}{Ansi.GRAY_0} path is: {path}. {Ansi.GREEN_BACK}Is this correct?  Y or N?{Ansi.BLACK_BACK}{Ansi.GRAY_0}");

            var answer = Console.ReadLine();
            return answer.ToLowerInvariant() == "y";

        }
    }
}
