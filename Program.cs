using System;

// 1. Doira yuzi va aylana uzunligini hisoblash
Console.Write("Aylana radiusini kiriting=> ");
double r, L, S;
r=Convert.ToDouble(Console.ReadLine());
L=Math.PI*Math.Pow(r,2);
Console.WriteLine($"Doira yuzi=> {L} ");
S=2*r*Math.PI;
Console.WriteLine($"Aynala uzunligi=> {S} ");

// 2. Valyuta konvertri
double Sum, Kurs=12400 , Natija;
Console.Write("Sumni kiriting=> ");
Sum=Convert.ToDouble(Console.ReadLine());
Natija=Sum*Kurs;
Console.WriteLine($"Siz kiritgan miqdorning so'mgagi miqdori=> {Natija}");

// 3. Yoshni hisoblash
int tugYil, joriyYil=2023, Kunlar;
Console.Write("Tug'ilgan yilingizni kiriting=> ");
tugYil=Convert.ToInt32(Console.ReadLine());
Kunlar= (joriyYil-tugYil)*365;
Console.WriteLine($"Siz {Kunlar} kunlik hisoblanasiz...");