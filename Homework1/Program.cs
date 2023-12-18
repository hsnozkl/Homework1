namespace Homework1;

class Program
{
    static void Main(string[] args)
    {
        //1. Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n).
        //Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. 
        //Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.
        
        Console.WriteLine("Kac adet sayi girmek istersiniz:");
        int sayi = int.Parse(Console.ReadLine());
        Console.WriteLine("Lutfen sayilarinizi girin:");
        int[] sayilar = new int[sayi];

        for (int i = 0; i < sayi; i++)
        {
            Console.Write("{0}. sayiyi girin: ", i + 1);
            sayilar[i] = Convert.ToInt32(Console.ReadLine());
        }
        for(int j = 0; j < sayi; j++)
        {
            if(sayilar[j] % 2 == 0)
                Console.WriteLine(sayilar[j]);
        }

        //2. Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). 
        //Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. 
        //Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.

        Console.WriteLine("Hangi sayinin bölmesini istersiniz:");
        int bolum = int.Parse(Console.ReadLine());

        Console.WriteLine("Kac adet sayi gireceksiniz:");
        int sayi1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Lutfen sayilarinizi giriniz:");
        int[] sayilar1 = new int[sayi1];
        for (int i = 0; i < sayi1; i++)
        {
            Console.Write("{0}. sayiyi girin: ", i + 1);
            sayilar1[i] = Convert.ToInt32(Console.ReadLine());
        }
        for (int j = 0; j < sayi1; j++)
        {
            if(sayilar1[j] == bolum || sayilar1[j] % bolum == 0)
                Console.WriteLine(sayilar1[j]);
        }

        //3. Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). 
        //Sonrasında kullanıcıdan n adet kelime girmesi isteyin. 
        //Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.
        Console.WriteLine("Kac adet kelime girmek istersiniz:");
        int sayi2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Lutfen " + sayi2 + " tane kelime giriniz:");
        string[] kelimeler = new string[sayi2];
        for (int i = 0; i < sayi2; i++)
        {
            Console.WriteLine("{0}. kelimeyi girin: ", i + 1);
            kelimeler[i] = Convert.ToString(Console.ReadLine());
        }
        for (int j = sayi2 - 1; j >= 0; j--)
        {
            Console.WriteLine(kelimeler[j]);
        }
        //4. Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. 
        //Cümledeki toplam kelime ve harf sayısını console'a yazdırın.
        Console.WriteLine("Lutfen bir cumle giriniz:");
        string cumle = Console.ReadLine();
        
        int harf = cumle.Length;
        string[] b = cumle.Split(' ');
        int bosluksuzHarf = harf - (b.Length - 1);
        Console.WriteLine("Toplam kelime sayisi: " + b.Length + "\nToplam harf sayisi: " + bosluksuzHarf);

    }
}

