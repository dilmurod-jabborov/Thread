namespace ThreadHomeWork;

static class Vazifalar
{
    public static void Vazifa1()
    {
        Thread thread1 = new Thread(Vazifalar.Vazifa11);
        Thread thread2 = new Thread(Vazifalar.Vazifa12);

        thread1.Start();
        thread2.Start();
    }

    static void Vazifa11()
    {
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Hello");
            Thread.Sleep(1000);
        }
    }
    
    static void Vazifa12()
    {
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("World!");
            Thread.Sleep(1500);
        }
    }
    
}
