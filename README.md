# Pratik-Polymorphism

Bu uygulama, Kare, Dikdörtgen ve Dik Üçgen gibi temel geometrik şekillerin alanlarını hesaplayan bir konsol uygulamasıdır. Uygulamada Polymorphism (Çok Biçimlilik) prensibinin kullanıldığı bir yapı oluşturulmuştur.

## Kullanım

Uygulamayı çalıştırdığınızda, her geometrik şeklin alanı konsol ekranına yazdırılır. Örneğin:

```
Kare Alanı: 100
Dikdörtgen Alanı: 200 
Dik Üçgen Alanı: 960
```

## Nasıl Çalışır?

Uygulamada, tüm geometrik şekillerin temel özelliklerini ve davranışlarını içeren `BaseGeometrikSekil` soyut sınıfı bulunmaktadır. Bu soyut sınıftan `Kare`, `Dikdörtgen` ve `DikUcgen` sınıfları türetilmiştir. Her türetilmiş sınıf, `AlanHesapla()` metodunu kendi hesaplama mantığına göre override etmektedir. Bu sayede, her geometrik şeklin alanı farklı hesaplanabilmektedir.

Örneğin, `Kare` sınıfının `AlanHesapla()` metodu şu şekildedir:

```csharp
public override void AlanHesapla()
{
    Console.WriteLine($"Kare Alanı: {Genislik * Yukseklik}");
}
```

Benzer şekilde, `Dikdörtgen` ve `DikUcgen` sınıflarının `AlanHesapla()` metotları da kendi hesaplama mantıklarını içermektedir.
