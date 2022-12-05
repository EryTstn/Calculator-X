using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hesap_Mak_v3._0
{
    internal class Program
    {

        static void asalmı(int x)
        {
            Console.Write("Bölenler: ");
            int l = 0;
            for (int i = 1; i <= x; i++)
            {
                if (x % i == 0)
                {
                    Console.Write(+ i + " ");
                    l++;
                }
            }
            Console.WriteLine();
            if (l == 2)
            { Console.WriteLine("Girdiğiniz Sayı Asal Sayıdır"); }
            else
            { Console.WriteLine("Girdiğiniz Sayı Asal Sayı Değildir"); }
        }
        static double üs(double x, double y)
        {
            double a = x;
            for (int i = 1; i < y; i++)
            {
                x = x * a;
            }
            return x;
        }
        static void ikili(int x)
        {
            int b = 0;
            int y = x;
            while (x > 0)
            {
                x = x / 2;
                b++;
            }
            int[] dizi = new int[b];
            for (int i = 0; i < b; i++)
            {
                dizi[i] = y % 2;
                y = (y - (y % 2)) / 2;
            }
            for (int i = b - 1; i >= 0; i--)
            {
                Console.Write(dizi[i] + " ");
            }
            Console.WriteLine(" ");
        }
        static int fakt(int x)
        {
            int h = x;
            for (int i = 1; i < h; i++)
            {
                x = i * x;
            }
            return x;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hesap Makinesi v2.0");
            int k = 1;
            while (k == 1)
            {

                Console.WriteLine();
                Console.Write("Lütfen İşlem Seçiniz(+,-,*,/,üs,k(karekök), f(faktöriyel), h(2 Dik Kenarın Hipotenüsü), c(Çember İşlemleri), i(İkili Sayı Sistesimine Çevirme), r(Sayının Rakamları Toplamı) veya a(Asal Kontrolu): ");
                string a = Console.ReadLine();
                double s = 0;
                Console.WriteLine();

                if ( a == "-" || a == "/")
                {
                    Console.Write("Lütfen Birinci Sayıyı Giriniz.. :");
                    double x = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine();
                    Console.Write("Lütfen İkinci Sayıyı Giriniz..: ");
                    double y = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine();

                    
                    if (a == "-")
                    {
                        s = x - y;
                    }
                    
                    else if (a == "/")
                    {
                        s = x / y;
                    }
                    Console.WriteLine("İşleminizin Sonucu: " + s);
                }
                else if (a == "+" || a == "*")
                {
                    if (a == "+")
                    {
                        Console.Write("Kaç Adet Sayı Toplamak İstersiniz: ");
                        int u = Convert.ToInt32(Console.ReadLine());
                        int[] dizi = new int[u];
                        Console.WriteLine();
                        for (int i = 0; i < u; i++)
                        {
                            Console.Write("Toplamak İsteiğiniz Sayıyı Girin: ");
                            dizi[i] = Convert.ToInt32(Console.ReadLine());
                            s = s + dizi[i];
                        }
                        Console.WriteLine("Girdiğiniz Sayıların Toplamı: " + s);
                    }
                    else if (a == "*")
                    {
                        Console.Write("Kaç Adet Sayı Çarpmak İstersiniz: ");
                        int u = Convert.ToInt32(Console.ReadLine());
                        double[] dizi = new double[u];
                        Console.WriteLine();
                        double s1 = 1;
                        for (int i = 0; i < u; i++)
                        {
                            Console.Write("Çarpmak İstediğiniz Sayıyı Girin: ");
                            dizi[i] = Convert.ToInt32(Console.ReadLine());
                            s1 = s1 * dizi[i];
                        }
                        Console.WriteLine("Girdiğiniz Sayıların Çarpımı: " + s1);
                    }
                }
                else if (a == "f" || a == "üs" || a == "a" || a == "k")
                {
                    Console.Write("Sayı Giriniz..: ");
                    int x = Convert.ToInt32(Console.ReadLine());

                    if (a == "f")
                    {
                        s = fakt(x);
                        Console.WriteLine();
                        Console.WriteLine("İşleminizin Sonucu..:" + s);
                    }
                    else if (a == "üs")
                    {
                        Console.Write("Kaçıncı Derece Üs Almak İstersiniz..: ");
                        int d = Convert.ToInt32(Console.ReadLine());
                        s = üs(x, d);
                        Console.WriteLine();
                        Console.WriteLine("İşleminizin Sonucu..:" + s);
                    }
                    else if (a == "a")
                    {
                        asalmı(x);
                    }
                    else if (a == "k")
                    {
                        s = Math.Sqrt(x);
                        Console.WriteLine("İşleminizin Sonucu..:" + s);
                    }
                }

                else if (a == "h")
                {
                    Console.Write("Birinci Kenarı Giriniz: ");
                    int x = Convert.ToInt32(Console.ReadLine());
                    Console.Write("İkinci Kenarı Giriniz:  ");
                    int y = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Hipotenüs Değeri: " + (Math.Sqrt(x * x + y * y)));
                }
                else if (a == "c")
                {
                    Console.Write("Lütfen Yarıçap Giriniz:  r= ");
                    double r = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine();
                    Console.Write("pi Sayısını Kaç Almak İstersiniz(3/3,14): ");
                    double pi = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine();
                    double alan, cevre;
                    if (pi == 3 || pi == 3.14)
                    {
                        alan = (r * r * pi);
                        cevre = (2 * r * pi);
                        Console.WriteLine("Değerini Girdiğiniz Çemberin:");
                        Console.WriteLine("Alanı: " + alan + "   Çevresi: " + cevre);
                    }
                    else
                    {
                        Console.WriteLine("Lütfen Geçerli Bir pi Değeri Giriniz!! ");
                    }

                }
                else if (a == "i")
                {
                    Console.Write("Tam Sayı Giriniz: ");
                    int x = Convert.ToInt32(Console.ReadLine());
                    ikili(x);
                }
                else if (a == "r")
                {
                    Console.Write("Tam Sayı Giriniz: ");
                    int x = Convert.ToInt32(Console.ReadLine());
                    int b = 0;
                    int y = x;
                    int o = 0;
                    while (x > 0)
                    {
                        x = x / 10;
                        b++;
                    }
                    int[] dizi = new int[b];
                    for (int i = 0; i < b; i++)
                    {
                        dizi[i] = y % 10;
                        y = (y - (y % 10)) / 10;
                    }
                    for (int i = b - 1; i >= 0; i--)
                    {
                        o = o + dizi[i];
                    }
                    Console.WriteLine("İşleminizin Sonucu: "+o);
                }
                else
                {
                    Console.WriteLine("Lütfen Verilen İşlemlerden Birini Seçiniz!!!");
                }



                Console.WriteLine();
                Console.Write("Çıkmak İçin 0'a Devam Etmek İçin Başka Bir Sayıya Basınız..: ");
                int q = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                if (q == 0)
                {

                    k = 0;
                    break;

                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("                 -Yeni İşlem-");
                }

            }
            Console.WriteLine("İyi Günler..");
            Console.ReadKey();
        }
    }
}
