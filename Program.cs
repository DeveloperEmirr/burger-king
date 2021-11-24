using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Threading;

namespace BurgerKing
{
    class Program
    {
        
        static ArrayList siparisler = new ArrayList();
        static ConsoleKeyInfo tus;
        static void Main(string[] args)
        {

            do
            {
                tus=menu();

                if (tus.Key==ConsoleKey.D1)
                {
                    siparisVer();
                }

                else if (tus.Key == ConsoleKey.D2)
                {
                    verilen_Siparisler();
                }

            } while (tus.Key!=ConsoleKey.D3);
        }



        static ConsoleKeyInfo menu()
        {

            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            Console.SetCursorPosition(52, 5);
            Console.WriteLine("HOŞGELDİNİZ");
            for (int i = 0; i < 120; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine();
            Console.WriteLine("1-Sipariş Ver \n\n2-Siparişleri Listele\n\n3-Çıkış");
            tus = Console.ReadKey();
            return tus;

        }

        static void siparis_menu()
        {

            Console.Clear();
            int satir = 0, sutun = 0;
            Console.Write("Burgerlerimiz");

            Console.SetCursorPosition(sutun + 20, satir);
            { Console.Write("Patates Çeşitlerimiz"); }

            Console.SetCursorPosition(sutun + 48, satir);
            { Console.Write("İçececek Çeşitlerimiz"); }
            Console.SetCursorPosition(sutun + 75, satir);
            { Console.Write("Sipariş No"); }

            //çeşitleri yazdırma kısmı alt taraf
            //1. satır kısmı
            Console.SetCursorPosition(sutun, satir + 1);
            { Console.Write("Cheeseburger"); }

            Console.SetCursorPosition(sutun + 20, satir + 1);
            { Console.Write("Acı soslu patates"); }

            Console.SetCursorPosition(sutun + 48, satir + 1);
            { Console.Write("Coco Cola"); }

            Console.SetCursorPosition(sutun + 75, satir + 1);
            { Console.Write("01"); }
            //2.satır kısmı
            Console.SetCursorPosition(sutun, satir + 2);
            { Console.Write("Rokforlu Burger"); }

            Console.SetCursorPosition(sutun + 20, satir + 2);
            { Console.Write("Nar ekşili patates"); }

            Console.SetCursorPosition(sutun + 48, satir + 2);
            { Console.Write("Ayran"); }

            Console.SetCursorPosition(sutun + 75, satir +2);
            { Console.Write("02"); }

            //3.satır kısmı
            Console.SetCursorPosition(sutun, satir + 3);
            { Console.Write("Balık Burger"); }

            Console.SetCursorPosition(sutun + 20, satir + 3);
            { Console.Write("Zerdaçallı patates"); }

            Console.SetCursorPosition(sutun + 48, satir + 3);
            { Console.Write("Pepsi"); }

            Console.SetCursorPosition(sutun + 75, satir + 3);
            { Console.Write("03"); }

            Console.WriteLine(); Console.WriteLine();
        }
        static void siparisVer()
        {
            int siparis;
            string isim;
            siparis_menu();

            Console.Write("Sipariş Numarası Seçiniz :");
            siparis = int.Parse(Console.ReadLine());

            Console.Write("İsim Giriniz :");
            isim = Console.ReadLine();
            switch (siparis)
            {
                case 01:
                    siparisler.Add("Cheeseburger");
                    siparisler.Add("Acı soslu patates");
                    siparisler.Add("Coco Cola");
                    siparisler.Add("01");
                    siparisler.Add(isim);
                    Console.WriteLine();
                    Console.WriteLine("Siparişiniz Başarıyla Alındı...");
                    Thread.Sleep(4000);
                    break;

                case 02:
                    siparisler.Add("Rokforlu Burger");
                    siparisler.Add("Nar ekşili patates");
                    siparisler.Add("Ayran");
                    siparisler.Add("02");
                    siparisler.Add(isim);
                    Console.WriteLine();
                    Console.WriteLine("Siparişiniz Başarıyla Alındı...");
                    Thread.Sleep(4000);
                    break;

                case 03:
                    siparisler.Add("Balık Burger");
                    siparisler.Add("Zerdaçallı patates");
                    siparisler.Add("Pepsi");
                    siparisler.Add("03");
                    siparisler.Add(isim);
                    Console.WriteLine();
                    Console.WriteLine("Siparişiniz Başarıyla Alındı...");
                    Thread.Sleep(4000);
                    break;
            }

            Console.WriteLine();

        }

        static void verilen_Siparisler()
        {
            Console.Clear();
            int sutun=0, satir=0;
            Console.Write("Burger");

            Console.SetCursorPosition(sutun + 20, satir);
            { Console.Write("Patates Çeşiti"); }

            Console.SetCursorPosition(sutun + 48, satir);
            { Console.Write("İçececek Çeşiti"); }

            Console.SetCursorPosition(sutun + 75, satir);
            { Console.Write("Sipariş No"); }


            Console.SetCursorPosition(sutun + 90, satir);
            { Console.Write("İsim"); }

            Console.SetCursorPosition(sutun, ++satir);
            for (int i = 0; i < 120; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine();
            for (int i = 0; i < siparisler.Count; i += 5)
            {
                if (i % 5 == 0) satir++;

                Console.SetCursorPosition(sutun, satir);
                { Console.Write(siparisler[i]); }

                Console.SetCursorPosition(sutun + 20, satir);
                { Console.Write(siparisler[i+1]); }

                Console.SetCursorPosition(sutun + 48, satir);
                { Console.Write(siparisler[i+2]); }

                Console.SetCursorPosition(sutun + 75, satir);
                { Console.Write(siparisler[i+3]); }

                Console.SetCursorPosition(sutun + 90, satir);
                { Console.Write(siparisler[i + 4]); }

            }
            Console.ReadLine();

        }
        
    }
}
