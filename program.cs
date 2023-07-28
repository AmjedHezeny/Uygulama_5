using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama_5
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            double sayi1, sayi2;
            string opr;

            Console.WriteLine("Hesap Makinesine Hoş Geldiniz! ^_^ ");
            Console.WriteLine("1.TOPLAM  (+):");
            Console.WriteLine("2.ÇIKARMA (-):");
            Console.WriteLine("3.ÇARPMA  (*):");
            Console.WriteLine("4.Bölme   (/):");
            Console.WriteLine("5.Pow kuvvet alma :");
            Console.WriteLine("6.Sqrt karekök alma :");
            Console.WriteLine("7.Abs mutlak değer alma :");
            Console.WriteLine("8.Floor en yakın küçük tam sayıya :");
            Console.WriteLine("9.Ceiling en yakın büyük tam sayıya :");
            Console.WriteLine("10.Max iki sayı arasından en büyüğü bulma :");
            Console.WriteLine("11.Min iki sayı arasından en küçüğü bulma :");
            Console.WriteLine("12.Sinüs değerini hesaplar :");
            Console.WriteLine("13.Sinüsün tersini hesaplar :");
            Console.WriteLine("14.Kosinüs değerini hesaplar :");
            Console.WriteLine("15.Kosinüsün tersini hesaplar :");
            Console.WriteLine("16.Tanjant değerini hesaplar. :");
            Console.WriteLine("17.Tanjantın tersini hesaplar :");
            Console.WriteLine("18.Pi (π) değerini temsil eder :");
            Console.WriteLine("19.Euler sayısı olarak bilinen e'nin değerini temsil eder :");
            Console.Write("İsleminizi seciniz: ");
            opr = Console.ReadLine();




            if (opr == "1" || opr == "2" || opr == "3" || opr == "4" || opr == "5" ||
                opr == "6" || opr == "7" || opr == "8" || opr == "9" || opr == "10" ||
                opr == "11" || opr == "12" || opr == "13" || opr == "14" || opr == "15" ||
                opr == "16" || opr == "17" || opr == "18" || opr == "19")

            {
                if (opr == "18")
                {
                    Console.WriteLine(Math.PI);
                }
                else if (opr == "19")
                {
                    Console.WriteLine(Math.E);
                }

                else 
                {      

                Console.Write("1.Sayiyi Giriniz: ");
                sayi1 = double.Parse(Console.ReadLine());

                if (opr == "1" || opr == "2" || opr == "3" || opr == "4" || opr == "5" || opr == "10" || opr == "11")
                {
                    Console.Write("2.Sayiyi Giriniz: ");
                    sayi2 = double.Parse(Console.ReadLine());
                }
                else
                {
                    sayi2 = 0;
                }




                if (opr == "1")
                {
                    Console.WriteLine("İslemin Sonucu = " + (sayi1 + sayi2));
                }
                else if (opr == "2")
                {
                    Console.WriteLine("İslemin Sonucu = " + (sayi1 - sayi2));
                }
                else if (opr == "3")
                {
                    Console.WriteLine("İslemin Sonucu = " + (sayi1 * sayi2));
                }
                else if (opr == "4")
                {
                    if (sayi2 == 0)
                    {
                        Console.WriteLine("Tanımsız sonuç");
                    }
                    else
                    {
                        Console.WriteLine("İslemin Sonucu = " + (sayi1 / sayi2));
                    }
                }
                else if (opr == "5")
                {
                    Console.WriteLine("İslemin Sonucu = " + Math.Pow(sayi1, sayi2));
                }
                else if (opr == "6")
                {
                    Console.WriteLine("İslemin Sonucu = " + Math.Sqrt(sayi1));
                }
                else if (opr == "7")
                {
                    Console.WriteLine("İslemin Sonucu = " + Math.Abs(sayi1));
                }
                else if (opr == "8")
                {
                    Console.WriteLine("İslemin Sonucu = " + Math.Floor(sayi1));
                }
                else if (opr == "9")
                {
                    Console.WriteLine("İslemin Sonucu = " + Math.Ceiling(sayi1));
                }
                else if (opr == "10")
                {
                    Console.WriteLine("İslemin Sonucu = " + Math.Max(sayi1, sayi2));
                }
                else if (opr == "11")
                {
                    Console.WriteLine("İslemin Sonucu = " + Math.Min(sayi1, sayi2));
                }
                else if (opr == "12")
                {
                    Console.WriteLine("İslemin Sonucu = " + Math.Sin(sayi1));
                }
                else if (opr == "13")
                {
                    Console.WriteLine("İslemin Sonucu = " + Math.Asin(sayi1));
                }
                else if (opr == "14")
                {
                    Console.WriteLine("İslemin Sonucu = " + Math.Cos(sayi1));
                }
                else if (opr == "15")
                {
                    Console.WriteLine("İslemin Sonucu = " + Math.Acos(sayi1));
                }
                else if (opr == "16")
                {
                    Console.WriteLine("İslemin Sonucu = " + Math.Tan(sayi1));
                }
                else if (opr == "17")
                {
                    Console.WriteLine("İslemin Sonucu = " + Math.Atan(sayi1));
                }
                else if (opr == "18")
                {
                    Console.WriteLine(Math.PI);

                }
                else if (opr == "19")
                {
                    Console.WriteLine(Math.E);
                }

                }
            }
            else 
            {
                Console.WriteLine("Yanlış Seçim Yaptınız.'_'!!");
            }
            Console.ReadLine();
        }
    }

}