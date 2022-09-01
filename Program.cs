internal class Program
{
    private static void Main(string[] args)
    {
       // Sort Metodu(sıralama)
       Console.WriteLine("***** Array Sort *****");
       int [] sayiDizisi = {23,12,4,86,72,3,11,17};

       Console.WriteLine("***** Sırasız Dizi *****");
       foreach (var sayi in sayiDizisi)
          Console.WriteLine(sayi);
        
        Console.WriteLine("***** Sıralı Dizi *****");
        Array.Sort(sayiDizisi);

        foreach (var sayi in sayiDizisi)
          Console.WriteLine(sayi);

        //Clear Metodu (Verdiğimiz Dizi İçerisinde Verdiğimiz İndexten Başlıyarak Verdiğimiz Eleman Sayısı Kadar Değeri Sıfırlıyor Gidip O Elemanlara Sıfırı Atıyor.)
        Console.WriteLine("***** Array Clear *****");
        // sayiDizisi elemanlarını kullanarak 2.index ten itiibaren 2 tane eleman '0'lar.
        Array.Clear(sayiDizisi,2,2);  //Burada sayiDizisi dizinin 2ci index ten başlıyarak 2 elemanını sil dedik.

        foreach (var sayi in sayiDizisi)
          Console.WriteLine(sayi);

        // Reverse Metodu (Verdiğimiz diziyi ortadan aynalıyomuş gbi yer değiştiriyor) 
        Console.WriteLine("***** Array Reverse *****");
        Array.Reverse(sayiDizisi);
        
        foreach (var sayi in sayiDizisi)
          Console.WriteLine(sayi);


       
    }
}