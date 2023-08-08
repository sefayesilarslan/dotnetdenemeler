using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      int x = 5;
      x++;
      Console.WriteLine(x);  
        int myInt = 10;
      double myDouble = 5.25;
      bool myBool = true;

      Console.WriteLine(Convert.ToString(myInt));    
      Console.WriteLine(Convert.ToDouble(myInt));   
      Console.WriteLine(Convert.ToInt32(myDouble));  
      Console.WriteLine(Convert.ToString(myBool));   

      int sayi1=10;
      int sayi2=20;
      int sonuc=sayi2/sayi1;
      Console.WriteLine(Convert.ToString(sonuc));   
       int sonuc2=sayi2*sayi1;
      Console.WriteLine(Convert.ToString(sonuc2));   
      Console.ReadLine();
     }
  }
}