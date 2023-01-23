using System;

public class Class7
{
	public Class7()
	{
        // 1'den başlayarak console'da girilen sayıya kadar ortalama hesaplama hesaplayan programı yazınız.
        Console.WriteLine("Please enter a number");
        int sayi = int.Parse(Console.ReadLine());
        int sayac =1;
        int toplam = 0;

        while (sayac <= sayi)
        {
            toplam += sayac;
            sayac++;
        }

        Console.WriteLine(toplam/sayi);

        char character = 'a';
        while (character < 'z')
        {
            Console.WriteLine(character);
            character++;
        }

        Console.WriteLine("***** Foreach *****");

        string[] arabalar = {"BMW","Ford","Toyota","Nissan"};

        foreach (var araba in arabalar)
        {
            Console.WriteLine(araba);
        }
	}
}
