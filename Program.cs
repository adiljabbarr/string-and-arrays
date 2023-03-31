using System;
using System.ComponentModel;
using System.Numerics;
using System.Threading.Channels;
using System.Xml.Linq;

internal class Program
{
    //1ci misal: İstifadəçidən string qəbul edən və sonra string’i sözlər array’inə ayıran
    //proqram yaradın. Sonra array’dəki sözlərin sayını çıxarın.
    //public static void Main(string[] args)
    //{   
    //    Console.WriteLine("zehmet olmasa cumlenizi yazin");
    //    string word = Console.ReadLine();
    //    string[] stringArr = word.Split(' ');
    //    Console.WriteLine("cumle daxilindeki sozler:");
    //    for (int i = 0; i < stringArr.Length; i++)
    //    {
    //        Console.WriteLine(stringArr[i]);
    //    }
    //}


    //2ci misal:Tam ədədlər array’i yaradan və sonra elementlərin cəmini hesablayan
    //proqram yazın.
    //public static void Main(string[] args)
    //{
    //    int[] nums = { 1, 2, 3, 4, 5, 6 };
    //    int sum = nums[0];
    //    for (int i = 1; i < nums.Length; i++)
    //    {
    //        sum += nums[i];

    //    }
    //    Console.WriteLine(sum);
    //}



    //3cu misal:İstifadəçidən cümlə qəbul edən və sonra hər sözün ilk hərfini böyük hərflə
    //yazan proqram yaradın.Sonra dəyişdirilmiş cümləni ekrana çıxarın.
    //public static void Main(string[] args)
    //{
    //    Console.WriteLine("cumlenizi yazin zehmet olmasa:");
    //    string sentence = Console.ReadLine();
    //    string[] sentence_words = sentence.Split(' ');

    //    for (int i = 0; i < sentence_words.Length; i++)
    //    {
    //        Console.WriteLine(sentence_words[i]);

    //        //sadece oldugu kimi cap eledim boyuk herfle yazdira bilmedim
    //    }
    //}


    //4cu misal:İstifadəçidən string ədəd qəbul edən və dəyərindən asılı olaraq sətri
    //integer və ya double tipinə çevirən proqram yazin.
    //public static void Main(string[] args)
    //{
    //    Console.WriteLine("ededinizi daxil edin zehmet olmasa:");
    //    string num = Console.ReadLine();
    //    int num1 = int.Parse(num);
    //    double num2 = double.Parse(num);

    //    Console.WriteLine("integer tipinde daxil olunan eded:" + num1);
    //    Console.WriteLine("double tipinde daxil etdiyiniz eded:" + num2);
    //}


    //5ci misal:İstifadəçidən vergüllə ayrılmış ədəd siyahısını qəbul edən proqram
    //yaradın.Daha sonra daxil edilən ədədləri string array’inə və hər bir
    //elementi tam ədədə çevirmək üçün Split() metodundan istifadə edin.
    //Nəhayət, tam ədədlərin ədədi ortasını hesablayın və nəticəni çıxarın.





    //6ci misal:String arrayi yaradın və tərkibində “e” hərfi olan sözlərin sayını
    //hesablamaq üçün “for loop”undan istifadə edən proqram yazın.

    //SEHVDIR ALINMADI !!!
    //public static void Main(string[] args)
    //{
    //    string[] stringArr = new string[5];
    //    for (int i = 0; i < stringArr.Length; i++)
    //    {
    //        stringArr[i] = Console.ReadLine();
    //    }

    //    foreach (char c in stringArr)
    //    {

    //        Console.WriteLine(c.ToString());
    //    }
    //}

    //7ci misal:İstifadəçidən ədəd qəbul edən proqram yaradın və sonra “ternary
    //operator” istifadə edərək ədədin cüt və ya tək olduğunu yoxlayın.Sonra,
    //nəticəni ekrana çıxarın.
    //men iki yolla yazdim cunki internetde axtaranda ternary operator iki yol cixmisdi

    //  1ci bu yolla yazdim bu kodu internetden oyrendim 
    //public static void Main(string[] args)
    //{
    //    int num = int.Parse(Console.ReadLine());
    //    var result = num % 2 == 0 ? "cut ededdir" : "tek ededdir";
    //    Console.WriteLine(result);
    //}

    //  2ci olaraqda if else ile yazdim
    //public static void Main(string[] args)
    //{
    //    Console.WriteLine("ededinizi yazin:");
    //    int num = int.Parse(Console.ReadLine());
    //    if (num == 0)
    //    {
    //        Console.WriteLine("eded sifirdir");
    //    }
    //    else if (num % 2 == 1)
    //    {
    //        Console.WriteLine("tek ededdir");
    //    }
    //}


    //8ci misal:İstifadəçidən cümlə qəbul edən və sonra cümlədəki saitlərin sayını
    //hesablayan proqram yazın.Sonra saitlərin sayını ekrana çıxarın.
    public static void Main(string[] args)
    {

        var str = "Apple";
        var c = 'p';
        var i = str.IndexOf(c);
        // i will be the index of the first occurrence of 'p' in str, or -1 if not found.

        if (i == -1)
        {
            // not found
        }
        else
        {
            do
            {
                // do something with index i, which is != -1
                i = str.IndexOf(c, i + 1);
            } while (i != -1);
        }

    }
}
