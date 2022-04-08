using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace canAtilla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ödev1
            //int saat,ucret=0;
            //Console.Write("Park saati giriniz: ");
            //saat= Convert.ToInt32(Console.ReadLine());

            //if (saat - 3 >= 0 || saat - 3 <= 3) ucret = 7;
            //for (int i = 1; i <= saat-3; i++)
            //{

            //        ucret += 2;

            //}
            //Console.WriteLine(ucret);
            //Console.ReadKey();





            //ödev2

            //    int taban = 0, us = 0, sonuc = 0;
            //    Console.Write("Taban değerini giriniz: ");
            //    taban = Convert.ToInt32(Console.ReadLine());
            //    Console.Write("Üs değerini giriniz: ");
            //    us = Convert.ToInt32(Console.ReadLine());
            //    Program pr = new Program();
            //    if (taban != 0 && us != 0){ sonuc = pr.ExponantialNumber(taban, us); Console.WriteLine(sonuc); }
            //    else
            //    {
            //        Console.WriteLine("Belirsiz!!!");
            //    }

            //    Console.ReadLine();

            //}

            //public int ExponantialNumber (int taban, int us)
            //{

            //    if (taban == 0 || taban == 1) return taban;
            //    else if (us == 0) return 1;

            //    else
            //    {
            //        return taban * ExponantialNumber(taban, us - 1);
            //    }
            //


            //ödev-3

            //    int n, r;
            //    Console.Write("Taban değerini giriniz: ");
            //       n = Convert.ToInt32(Console.ReadLine());
            //     Console.Write("Üs değerini giriniz: ");
            //        r = Convert.ToInt32(Console.ReadLine());
            //    Program pr = new Program();
            //    int comb=  pr.Factorial(n) / (pr.Factorial(r)*pr.Factorial(n - r));
            //    Console.WriteLine(comb);
            //    Console.ReadKey();


            //}

            //public int Factorial(int facto)
            //{
            //    if (facto == 0||facto==1) return 1;
            //    else return facto * Factorial(facto - 1);


            //}





            //4 - 100 soruluk 4 yanlışın 1 doğruyu getirdiği sınavda öğrencinin girilen doğru ve yanlış sayısına göre aldığı puanı hesaplayan program yazınız.

            //•	NetSayisi(...)   ve Hesapla(...) diye iki fonksiyon olacak.   
            //•	NetSayisi(...) fonksiyonu, doğru ve yanlış soru sayısını parametre olarak alıp, öğrencinin kaç neti olduğunu bulur. 
            //•	Hesapla(...)fonksiyonu da hesaplanmış net sayısını parametre olarak alıp öğrencinin puanını hesaplar.Her net 10 puandır.


            //    int dogru, yanlis, puan = 0;
            //    Console.Write("Doğru soru sayısını giriniz :");
            //    dogru = Convert.ToInt32(Console.ReadLine());
            //    Console.Write("Yanlış soru sayısını giriniz: ");
            //    yanlis = Convert.ToInt32(Console.ReadLine());
            //    Program pr = new Program();
            //    Console.WriteLine(pr.Hesapla(pr.NetSayisi(dogru, yanlis)));
            //    Console.ReadLine();

            //}

            //public double NetSayisi(double dogru, double yanlis)
            //{

            //    double net = dogru - (yanlis * 0.25);
            //    return net;
            //}

            //public double Hesapla(double net)
            //{
            //    Program pr = new Program();
            //    double puan = net * 10;
            //    return puan;
            //}

            //ödev-5 5-	Stack yapısı oluşturun. Kullanıcı 3 farklı komut girecek:
            //  a.  “Push” komutunu girildiğinde kullanıcıdan bir sayı girilmesi istenecek ve o sayı stack’a eklenecek.
            //b.  “Pop” komutu girilirse o zaman stack’den çıkarılması gereken sayı çıkarılacak.
            // Not: Eğer stack boş ise o zaman uyarı verecek.

            //c. “Clear” komutu ile stack’deki tüm elemanlar çıkarılacak.

            //d. “List” komutu ile stack’deki elemanlar uygun sırada yazdırılacak(araya – işareti koyularak)


            //e. “Exit” komutu girildiğinde program sonlandırılacak. 
            

            int[] stack = new int[10];
            int front = -1, back = -1;



        }

        public void Push()
        {

        }
        public void Pop()
        {

        }
        public void Clear()
        {

        }
        public void List()
        {

        }
        public void Exit()
        {

        }

    }
}
