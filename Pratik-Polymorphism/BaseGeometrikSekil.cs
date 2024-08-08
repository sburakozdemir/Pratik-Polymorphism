using System;

namespace Pratik_Polymorphism
{
    // Bu sınıf, tüm geometrik şekiller için temel özellikleri ve davranışları içerir.
    public abstract class BaseGeometrikSekil
    {
        public double Genislik { get; set; }
        public double Yukseklik { get; set; }

        // Bu metod, tüm geometrik şekiller için alan hesaplamasını yapar.
        // Ancak, her şeklin kendi hesaplama mantığı olduğundan, bu metod soyut (abstract) olarak tanımlanır.
        public abstract void AlanHesapla();
    }

    // Kare sınıfı, BaseGeometrikSekil sınıfından türetilir.
    public class Kare : BaseGeometrikSekil
    {
        public Kare(double genislik, double yukseklik)
        {
            Genislik = genislik;
            Yukseklik = yukseklik;
        }

        // Kare sınıfının kendi alan hesaplama mantığını override eder.
        public override void AlanHesapla()
        {
            Console.WriteLine($"Kare Alanı: {Genislik * Yukseklik}");
        }
    }

    // Dikdörtgen sınıfı, BaseGeometrikSekil sınıfından türetilir.
    public class Dikdortgen : BaseGeometrikSekil
    {
        public Dikdortgen(double genislik, double yukseklik)
        {
            Genislik = genislik;
            Yukseklik = yukseklik;
        }

        // Dikdörtgen sınıfının kendi alan hesaplama mantığını override eder.
        public override void AlanHesapla()
        {
            Console.WriteLine($"Dikdörtgen Alanı: {Genislik * Yukseklik}");
        }
    }

    // Dik Üçgen sınıfı, BaseGeometrikSekil sınıfından türetilir.
    public class DikUcgen : BaseGeometrikSekil
    {
        public DikUcgen(double genislik, double yukseklik)
        {
            Genislik = genislik;
            Yukseklik = yukseklik;
        }

        // Dik Üçgen sınıfının kendi alan hesaplama mantığını override eder.
        public override void AlanHesapla()
        {
            Console.WriteLine($"Dik Üçgen Alanı: {(Genislik * Yukseklik) / 2}");
        }
    }
}