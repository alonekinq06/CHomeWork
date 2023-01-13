// See https://aka.ms/new-console-template for more information
// Dizi Tanımlama
string [] renkler = new string[5];
string [] hayvanlar = {"Kedi","Kopek","Maymun","Kus",};
int [] dizi ; 
dizi = new int[5];

// Dizilere değer atama ve değişim

renkler[0]="Mavi";
dizi[3] = 10 ;


Console.WriteLine(hayvanlar[1]);// Kedi 0.eleman 1 Kopek
Console.WriteLine(dizi[3]);
Console.WriteLine(renkler[0]);

// Dongulerler diziler
// Klayveyeden girilen n sayının ortlamasını hesaplayan prohram
Console.Write("Lutfen Dizinin Elaman Sayisini Giriniz");
int diziuzunlugu = int.Parse(Console.ReadLine());
int [] sayiDizisi = new int[diziuzunlugu];
 for (int i = 0 ; i< diziuzunlugu ; i++)
 {
   Console.Write("{0}. sayıyı giriniz : " , i+1 );
   sayiDizisi[i] = int.Parse(Console.ReadLine());

 }
 int toplam = 0;
foreach (var sayi in sayiDizisi)
toplam += sayi ;
 
Console.WriteLine("Ortalama :" +toplam/diziuzunlugu);


{
    
}

