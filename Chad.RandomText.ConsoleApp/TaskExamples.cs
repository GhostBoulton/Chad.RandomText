using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Chad.RandomText.ConsoleApp
{
    public static class TaskExamples
    {
        public static async void Run()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            Task t = new Task(() =>
            {
                //Thread.Sleep(2000);
                Console.WriteLine($"Chad's first thing.");
            });

            Console.WriteLine("Who is first?");

            t.Start();

            var listOfNumbers = Enumerable.Range(1, 64).ToList();

            int skip = 0;
            int take = Environment.ProcessorCount + 0;
            var r = new Random(DateTime.Now.Millisecond);

            while (true)
            {
                var tasks = listOfNumbers
                    .Skip(skip)
                    .Take(take)
                    .Select(e => Task.Run(() => { MyMethod(e,r); }))
                    .ToArray();

                if (tasks.Length == 0) { break; }

                skip += take;
                await Task.WhenAll(tasks);
                Console.WriteLine($"bump");
            }

            sw.Stop();

            Console.WriteLine($"{sw.Elapsed:g} elapsed.");


        }

        private static void MyMethod(int param, Random r)
        {
            var sleeptime = r.Next(2000);

            Thread.Sleep(sleeptime);
            Console.WriteLine($"Printing a {param} after {sleeptime} ms");
        }

        //int skip = 0;
        //    while (true)
        //{

        //    Debug.WriteLine($"Performings waves of size: {Environment.ProcessorCount} eek");
        //    // Do parallel processing in "waves".
        //    var tasks = filesToUpload
        //        .Take(Environment.ProcessorCount)
        //        .Select(e => Task.Run(() => ZipAndUpload(e.FileDateTime, e.Contents, key, secret))) // No await here - we just want the tasks.
        //        .Skip(skip)
        //        .ToArray();

        //    if (tasks.Length == 0) { break; }

        //    skip += Environment.ProcessorCount;
        //    await Task.WhenAll(tasks);
        //};
    }
}
