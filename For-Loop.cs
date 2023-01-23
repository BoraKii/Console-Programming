using System;

public class Class6
{
    public Class6()
    {
        Console.WriteLine("Bir sayı giriniz:");
        int sayi = int.Parse(Console.ReadLine());

        for (int i = 0; i <= sayi; i++)
        {
            if (i % 2 == 1)
            {
                Console.WriteLine(i);
            }
        }

        int tekToplam = 0;
        int ciftToplam = 0;

        for (int i = 0; i <= 1000; i++)
        {
            if (i % 2 == 0)
            {
                ciftToplam += i;
            }
            else
            {
                tekToplam += i;
            }
        }
        Console.WriteLine("Çift sayı toplamı:" + ciftToplam);
        Console.WriteLine("Tek sayı toplamı:" + tekToplam);

        //break and continue
        for (int i = 0; i < 10; i++)
        {
            if (i == 4)
            {
                break; //end the loop
            }
            Console.WriteLine(i);
        }

        for (int i = 0; i < 10; i++)
        {
            if (i == 4)
            {
                continue; //pass the number (4)
            }
            Console.WriteLine(i);
        }

        for (; ; ) // Infinite loop.
        {
            Console.WriteLine("keep going forever :)");
        }
    }
}
