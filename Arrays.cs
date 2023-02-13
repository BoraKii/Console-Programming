using System;

public class Class7
{
    public Class7()
    {
        string[] renkler = new string[5];

        string[] hayvanlar = { "Kedi", "Köpek", "Aslan", "Kuş" };

        int[] dizi;
        dizi = new int[5];

        //Dizilere değer atama ve erişim
        renkler[1] = "Kırmızı";
        dizi[3] = 20;

        Console.WriteLine(hayvanlar[2]);
        Console.WriteLine(renkler[1]);
        Console.WriteLine(dizi[3]);

        /* Döngülerle dizi kullanımı
           Klavyeden girilen n tane sayının ortalamasını hesaplayan programı yazınız. */

        Console.WriteLine("Dizinin eleman sayısını giriniz: ");
        int diziUzunlugu = int.Parse(Console.ReadLine());
        int[] sayiDizisi = new int[diziUzunlugu];

        for (int i = 0; i < diziUzunlugu; i++)
        {
            Console.WriteLine("{0}. sayıyı giriniz: ", i + 1);
            sayiDizisi[i] = int.Parse(Console.ReadLine());
        }

        int toplam = 0;
        foreach (var sayi in sayiDizisi)
            toplam += sayi;

        Console.WriteLine("Ortalama :" + toplam / diziUzunlugu);




    }
}
