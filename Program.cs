internal class Program
{
    private static void Main(string[] args)
    {
       // Sort Metodu(sıralama)
       int [] sayiDizisi = {23,12,4,86,72,3,11,17};
       Console.WriteLine("***** Sırasız Dizi *****");
       foreach (var sayi in sayiDizisi)
          Console.WriteLine(sayi);
        
        Console.WriteLine("***** Sıralı Dizi *****");
        Array.Sort(sayiDizisi);

        foreach (var sayi in sayiDizisi)
          Console.WriteLine(sayi);
       
    }
}