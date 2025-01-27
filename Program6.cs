using System;
class Program{
    static void Main(string[] args)
    {
      Console.WriteLine("the first 10 natural number are :");
      int sum = 0;
      for(int i = 1; i<=10; i++)
      {
          Console.Write(i+"");
          sum+=i;
      }
      Console.WriteLine();
        
        Console.WriteLine("The sum of the first ten natural numbers is: /" + sum);
    }

}
