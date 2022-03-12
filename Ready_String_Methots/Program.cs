using System;

namespace Ready_String_Methots
{
    class Program
    {
        static void Main(string[] args)
        {
            string variant = "dersimiz CSharp, Hoşgeldiniz";
            string variant2 = "dersimiz CSharp";

            //lenght
            Console.WriteLine(variant.Length);

            //toUpper
            Console.WriteLine(variant.ToUpper());

            //toLower
            Console.WriteLine(variant.ToLower());

            //Concat
            Console.WriteLine(string.Concat(variant, " Merhaba !"));

            //Compare, CompareTo
            Console.WriteLine(variant.CompareTo(variant2));

            //  1.variant 2.ye eşitse     : 0 
            //  1.variant 2.den büyükse   : 1 
            //  1.variant 2.den küçükse   : 2   değerlerini döndürür.

            //Compare

            Console.WriteLine(string.Compare(variant, variant2, true)); // true olursa büyük küçük harf duyarlı (eşitse 0 döner)
            Console.WriteLine(string.Compare(variant, variant2, false));// false olursa büyük küçük harf duyarlı değil


            //Contains
            Console.WriteLine(variant.Contains(variant2));    // variant içinde variant2 varsa true döner;


            Console.WriteLine(variant.EndsWith("Hoşgeldiniz"));   // SONU O ŞEKİLDE BİTİYOSA TRUE DÖNER
            Console.WriteLine(variant.EndsWith("MERHABA"));   // BAŞI O ŞEKİLDE BAŞLIYOSA TRUE DÖNER


            Console.WriteLine(variant.IndexOf("CSharp"));  // bulduğu ilk yerde C nin indeksini verir bulamazsa (-1) verir
            Console.WriteLine(variant.IndexOf("heyy"));

            //LastIndex
            Console.WriteLine(variant.LastIndexOf("i"));   // stringin geçtiği son index numarsını getirir


            //Insert
            Console.WriteLine(variant.Insert(0, "Merhaba!"));  // seçilen index e stringi ekler 

            //PadLeft,PadRight

            Console.WriteLine(variant + variant2.PadLeft(30));   // variant2 nin sonuna toplam karakter sayısı 30 olacak şekilde boşluk ekler
            Console.WriteLine(variant + variant2.PadLeft(30,'*'));
            Console.WriteLine(variant + variant2.PadRight(30));
            Console.WriteLine(variant + variant2.PadRight(30,'*'));

            //Remove
            Console.WriteLine(variant.Remove(10));   //10. indisten itibaren sonrasını siler
            Console.WriteLine(variant.Remove(0,5));  // baştan 5 tane 
            Console.WriteLine(variant.Remove(1,1));  // 1.indisten 1 karakter siler

            // Replace

            Console.WriteLine(variant.Replace("CSharp", "C#"));  //stringi istediğimiz stringe çevirir

            //Split
            Console.WriteLine(variant.Split(' ')[1]);     // stringi boşluklara göre böl vaşka bi diziye ata ve 1. indexi getir


            //Substring
            Console.WriteLine(variant.Substring(4));     //4.indexten başlayarak sonuna kadar getir
            Console.WriteLine(variant.Substring(4,6));    //4.indexten başlayarak 6 karakter getir

            Console.Read();                                   
        }
    }
}
