namespace Operators;

class Program
{
    static void Main(string[] args)
    
    {
      int x=3;
      int y=3;
      y=y+2;
      Console.WriteLine(y);
      y +=2;
      Console.WriteLine(y);
       y /=1;
       Console.WriteLine(y);
       x *=2;
       Console.WriteLine(x);

       //Mantiksal Operatorler

       bool isSucces = true;
       bool isComplated = false;

       if(isSucces && isComplated)
       Console.WriteLine("perfect!");

       if(isSucces || isComplated)
        Console.WriteLine("Great!");

         if(isSucces && isComplated)
        Console.WriteLine("Fine!");

    }
}
