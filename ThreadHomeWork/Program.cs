namespace ThreadHomeWork
{
    internal class Program
    {
        static object lockObj = new object();
        static int maxLength = 25;
        static void Main(string[] args)
        {
            //Console.Clear(); 

            Thread t1 = new Thread(() => ShowProgress(1, ConsoleColor.Red));
            Thread t2 = new Thread(() => ShowProgress(2, ConsoleColor.Yellow));
            Thread t3 = new Thread(() => ShowProgress(3, ConsoleColor.Green));
            Thread t4 = new Thread(() => ShowProgress(4, ConsoleColor.Red));
            Thread t5 = new Thread(() => ShowProgress(5, ConsoleColor.Yellow));
            Thread t6 = new Thread(() => ShowProgress(6, ConsoleColor.Green));

            t1.Start();
            t2.Start();
            t3.Start();
            t4.Start();
            t5.Start();
            t6.Start();

            t1.Join();
            t2.Join();
            t3.Join();
            t4.Join();
            t5.Join();
            t6.Join();


            Console.SetCursorPosition(0, 8);
            Console.WriteLine("Ish tugadi.");


            //Vazifalar.Vazifa3();

            // Vazifalar.Vazifa2();

            // Vazifalar.Vazifa1();


        }


        static void ShowProgress(int lineNumber, ConsoleColor color)
        {
            string progress = "";
            for (int i = 0; i < maxLength; i++)
            {
                progress += "=";

                lock (lockObj)
                {
                    Console.ForegroundColor = color;
                    Console.SetCursorPosition(0, lineNumber - 1);
                    Console.Write($"Thread {lineNumber}: {progress}>");
                    Console.ResetColor();
                }

                Thread.Sleep(1000); 
            }
        }
    }
}
