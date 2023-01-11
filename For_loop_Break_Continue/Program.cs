internal class Program
{
    private static void Main(string[] args)
{  Console.WriteLine("Please Enter a Number");
    ///Ekrandan girilen sayı kadar olan tek sayılarını ekrana yazdır.
// int sayac = int.Parse(Console.ReadLine()); //i=i+1 >>>> i++ same 
// for (int i = 0; i <= sayac; i = i + 1)// 
// {
// if (i % 2 == 1)
// Console.WriteLine(i);
// }
// {
//     // 1 ile 1000 arasındaki tek ve çift sayıları yazdırma.
// int tekToplam = 0 ;
// int ciftToplam= 0 ;
// for (int i = 0 ; i<=1000  ; i++ )
// {
// if (i%2 == 1) 
// tekToplam = tekToplam + i ;  
//     // tekToplam += i i yi üsütne ekle devam etin kısa prafik hali 
//         else 
// ciftToplam = ciftToplam + i ; 
// } Console.WriteLine("TEK TOPLAM :    " + tekToplam);
// Console.WriteLine("CIFT TOPLAM     " + ciftToplam);
// break , continue 
for (int i = 1 ; i<10 ; i++){
    if (i==4)
    break ;
    Console.WriteLine(i);
}
for (int i = 1 ; i<10 ; i++){
    if (i==4)
    continue;
    Console.WriteLine(i);
}


    }
  }