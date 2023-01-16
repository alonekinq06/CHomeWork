//Sort (sıra)
int[] sayiDizisi = {12,23,4,86,72,3,11,17};
Console.WriteLine("*-*-*Sirasiz Dizi");
foreach (var sayi in sayiDizisi)
{
    Console.WriteLine(sayi);  
}
Console.WriteLine("*-*-*Sirali Dizi-*-*");
Array.Sort(sayiDizisi);
foreach (var sayi in sayiDizisi)
{
    Console.WriteLine(sayi);
}
//Clear sifirlama(0lamaymış)
Console.WriteLine("*-*-*Array Clear-*-*-*");
// sayiDizisi elemarından 2.index tan itibaren 2 tane eleman0'lar
Array.Clear(sayiDizisi,2,2);//ile index sonra elaman sayısı yani 2. endeksten baslayıp 2 eleman sıfırlama
foreach (var sayi in sayiDizisi)
{
    Console.WriteLine(sayi);
}
// Reverse, 
Console.WriteLine("*-*-*Array Reverse-*-*-*");
Array.Reverse(sayiDizisi);
foreach (var sayi in sayiDizisi)
{
    Console.WriteLine(sayi);
}

//IndexOf    elemanın index'ini bulma
Console.WriteLine("*-*-*Array IndexOf -*-*-*");
Console.WriteLine(Array.IndexOf(sayiDizisi,23));


//Resize yeniden boyutlandırma
Console.WriteLine("*-*-*Array Resize -*-*-*");
Array.Resize<int>(ref sayiDizisi,9);
sayiDizisi [8] = 99 ;
foreach (var sayi in sayiDizisi)
{
Console.WriteLine(sayi);
}
