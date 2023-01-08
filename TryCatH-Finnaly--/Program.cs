try{
    int a = int.Parse("test");
    //2 int  b = int.Parse(null);

   // Console.WriteLine("Bir sayi giriniz ;  ");
//int a = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine(a);

} 
catch(ArgumentNullException ex)
{
    Console.WriteLine("bos değer giriniz");
    Console.WriteLine(ex);
     }

catch(FormatException ex)
{
    Console.WriteLine("veri tipi uygun değil");
    Console.WriteLine(ex);
}
//2 catch(ArgumentNullException ex)
//catch (Exception ex)

   //2  Console.WriteLine("bos deger girdiniz");
  //  Console.WriteLine("HATA!"+ ex.Message.ToString());

//finally

   // Console.WriteLine("işlemtamamlandı");




