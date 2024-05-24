using System;

class Program {
  public static void Main (string[] args) {
   Console.WriteLine("Please enter wind speed:");
  var mph = Convert.ToDouble(Console.ReadLine());
if (mph < 74){
  Console.WriteLine("Not a Hurricane");
}
else if (mph >= 74 && mph <96) {
  Console.WriteLine("Category One Hurricane");     
}
    else if (mph >= 96 && mph <111) {
    Console.WriteLine("Category Two Hurricane");    
}
    else if (mph >= 111 && mph <130) {
    Console.WriteLine("Category Three Hurricane");
}
else if (mph >= 130) {
    Console.WriteLine("Category Four Hurricane");
      }
    }
  }
