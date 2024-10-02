using System.ComponentModel.Design;

Console.Write("Bir Sayi Giriniz: ");
int sayi = Convert.ToInt16(Console.ReadLine());

if (sayi > 10 && sayi %2 == 0) //Eğer sayı 10'dan büyük ve 2'ye kalansız bölünüyorsa.(Çift kontrolü)
{
    Console.WriteLine("Girilen Sayi 10'dan büyüktür.");
    Console.WriteLine("Girilen Sayi çifttir.");
}

else if (sayi > 10) //Sayı 10'dan büyükse ve 2'ye kalansız bölünmüyorsa.(Tek kontrolü)

{
    Console.WriteLine("Girilen Sayi 10'dan büyüktür.");
    Console.WriteLine("Sayı tektir.");
}

if (sayi == 10 && sayi % 2 == 0) //Bu kısımda else yazılmasına gerek kalmadı, çünkü 10'a eşitse tek olma olasılığı yok.
{
    Console.WriteLine("Girilen Sayi 10'a eşittir.");
    Console.WriteLine("Girilen Sayi çifttir.");
}
if (sayi < 10 && sayi % 2 == 0)
{
    Console.WriteLine("Girilen Sayi 10'dan küçüktür.");
    Console.WriteLine("Girilen Sayi çifttir.");
}

else if (sayi < 10)

{
    Console.WriteLine("Girilen Sayi 10'dan küçüktür.");
    Console.WriteLine("Sayı tektir.");
}
