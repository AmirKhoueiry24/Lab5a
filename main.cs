using System;

class Program {
  public static void Main (string[] args) {

int counter = 0;

while(counter < 7){
 Console.WriteLine("Enter distance covered by Car:");
    double Miles = Convert.ToDouble(Console.ReadLine());
    
   Console.WriteLine("Enter the time taken by Car:");  
    double Hours = Convert.ToDouble(Console.ReadLine());

    double Car1 = Miles / Hours; 

    Console.WriteLine("The speed of Car is  " + Car1);
counter++;


}








  }
}