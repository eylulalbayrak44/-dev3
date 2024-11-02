//soru 1

////{ 
////int[] sayilar = { 1, 2, 5, 7, 17 };
////int toplam = 0;
////foreach (int sayi in sayilar)
////{
////        Console.WriteLine(sayi);
////    toplam = toplam + sayi;
////}

////Console.WriteLine("Dizideki sayıların toplamı = " + toplam);
////Console.ReadKey();
////}

//soru 2
//string cumle;
//Console.Write("Cumleyi Girin : ");
//cumle = Console.ReadLine();
//string[] kelimeler = cumle.Split(' ');
//Console.WriteLine(kelimeler.Length);
//Console.ReadKey();

//soru 3
//using System.Collections;

//ArrayList liste = new ArrayList();
//string isim;
//for (int i = 1; i <= 5; i++)
//{
//    Console.Write(i + ". ismi giriniz: ");
//    isim = Console.ReadLine();
//    liste.Add(isim);
//}
//Console.WriteLine("Sıralamadan önce liste:");
//foreach (object obj in liste)
//    Console.WriteLine(obj);
//liste.Sort();
//Console.WriteLine("Sıralandıktan sonra liste:");
//foreach (object obj2 in liste)
//    Console.WriteLine(obj2);
//Console.ReadKey();

//soru 4
//int birincisayi = 0, ikincisayi = 1, aktarim;
//Console.WriteLine("Bir sayı girin:");
//int sayi = Int32.Parse(Console.ReadLine());

//Console.Write("\nFibonacci Serisi:");

//for (int i = 0; i < sayi; i++)
//{
//    Console.Write(birincisayi);
//    aktarim = ikincisayi;
//    ikincisayi = birincisayi + ikincisayi;
//    birincisayi = aktarim;

//    if (i < sayi - 1)
//        Console.Write(",");
//}
//Console.ReadLine();


//soru 5
//namespace SayiTahmin
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int hak = 5;
//            Random rnd = new Random();
//            int tutulan = rnd.Next(1, 100);
//            int sayi = 0;
//            while (hak > 0)
//            {
//                Console.WriteLine("Bir sayı giriniz:");
//                sayi = Convert.ToInt32(Console.ReadLine());
//                hak--;
//                if (sayi == tutulan)
//                {
//                    Console.WriteLine("Doğru sayı");
//                    break;
//                }
//                else
//                {
//                    if (sayi > tutulan)
//                        Console.WriteLine("Aşağı");
//                    else
//                    {
//                        Console.WriteLine("Yukarı");
//                    }
//                    Console.WriteLine("Kalan tahmin sayınız:)" + hak);
//                }
//                if (hak == 0)
//                    Console.WriteLine("Hakkınız 0 oldu.Oyun bitti.");

//        }


//        }
//    }
//}

//soru 6
//namespace HesapMakinesi
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int sayi1, sayi2;
//            double sonuc;
//            string islem;
//            Console.WriteLine("Bir sayı giriniz:");
//            sayi1 = Convert.ToInt32(Console.ReadLine());

//            Console.WriteLine("İkinci sayıyı giriniz:");
//            sayi2 = Convert.ToInt32(Console.ReadLine());

//            Console.WriteLine("İşlem seçin(*,/,+,-)");
//            islem = Console.ReadLine();

//            if (islem == "*")
//            {
//                sonuc = sayi1 * sayi2;
//                Console.WriteLine("Sonuç:" + sonuc);
//            }
//            if (islem == "/")
//            {
//                sonuc = sayi1 / sayi2;
//                Console.WriteLine("Sonuç:" + sonuc);
//            }
//            if (islem == "+")
//            {
//                sonuc = (sayi1 + sayi2);
//                Console.WriteLine("Sonuç:" + sonuc);
//            }
//            if (islem == "-")
//            {
//                sonuc = sayi1 - sayi2;
//                Console.WriteLine("Sonuç:" + sonuc);
//            }
//        }
//    }
//}


//soru 7
//namespace SayıOyunu
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            double sayı = 0;
//            double toplam = 0;
//            int i;

//            do
//            {
//                Console.Write("Sayı giriniz:");
//                sayı = Convert.ToDouble(Console.ReadLine());
//                toplam += sayı;


//            } while (sayı != 0);


//            Console.Write("Sayıların toplamı: {0}", toplam);

//            {
//                Console.ReadLine();

//            }

//        }

//    }

//}

           



        

    
