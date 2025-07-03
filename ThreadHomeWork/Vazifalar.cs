namespace ThreadHomeWork;

static class Vazifalar
{
    public static void Vazifa3()
    {
        Thread thread1 = new Thread(Vazifalar.Vazifa31);
        Thread thread2 = new Thread(Vazifalar.Vazifa32);
        Thread thread3 = new Thread(Vazifalar.Vazifa33);

        thread1.Start();
        thread2.Start();
        thread3.Start();
    }
    static void Vazifa31()
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine("*");
            Thread.Sleep(100);
        }
    }

    static void Vazifa32()
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine("#");
            Thread.Sleep(200);
        }
    }
    
    static void Vazifa33()
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine("@");
            Thread.Sleep(300);
        }
    }

    public static void Vazifa2()
    {
        Thread thread1 = new Thread(Vazifalar.Vazifa21);
        Thread thread2 = new Thread(Vazifalar.Vazifa22);

        thread1.Start();
        thread2.Start();
    }

    static void Vazifa21()
    {
        for (int i = 1; i <=10; i++)
        {
            Console.WriteLine(i);
            Thread.Sleep(500);
        }
    }

    static void Vazifa22()
    {
        for (int i = 10; i >0; i--)
        {
            Console.WriteLine(i);
            Thread.Sleep(500);
        }
    }

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
            Thread.Sleep(500);
        }
    }
    
    static void Vazifa12()
    {
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("World!");
            Thread.Sleep(500);
        }
    }
    
}
