//Console.WriteLine("Hello, World!");
using System.Runtime.ConstrainedExecution;
using Timer = System.Timers.Timer;

namespace TimerSpace
{
    class Program
    {
        static void Main(string[] args)
        {
            Timer myTimer = new Timer(2000);

            myTimer.Elapsed += MyTimer_Elapsed;
            myTimer.Elapsed += MyTimer_Elapsed1;

            myTimer.Start();

            Console.WriteLine("Press enter to remove the green event.");

            Console.ReadLine();

            myTimer.Elapsed -= MyTimer_Elapsed1;

            Console.ReadLine();
        }

        private static void MyTimer_Elapsed1(object? sender, System.Timers.ElapsedEventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Elapsed: {0:HH:mm:ss.fff}", e.SignalTime);
            //throw new NotImplementedException();
        }

        private static void MyTimer_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
        {
            Console.ForegroundColor= ConsoleColor.Blue;
            Console.WriteLine("Elapsed: {0:HH:mm:ss.fff}", e.SignalTime);
            //throw new NotImplementedException();
        }
    }
}