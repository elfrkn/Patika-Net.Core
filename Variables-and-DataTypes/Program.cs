namespace pratikler;

class Program
{
    static void Main(string[] args)
    {
        byte b =5;
        byte c=5;

        short s=5;
        ushort us=5;
        
        Int16 i16=2;
        int i=2;
        Int32 i32=2;
        Int64 i64=2;

        uint ui=2;
        long l=4;
        ulong ul=4;
        
//Real Sayilar
        float f=5;
        double d=5;
        decimal de=5;

        char ch='5';
        string sr="Nevzat";

        bool b1=true;
        bool b2=false;

        DateTime dt=DateTime.Now;
        Console.WriteLine(dt);

        //Degisken Donusumleri

        string str20="20";
        int int20=20;
        string yenideger=str20 + int20.ToString();
        Console.WriteLine(yenideger);

        int int21=int20+Convert.ToInt32(str20);
        Console.WriteLine(int21);

        //Datetime

        string datetime = DateTime.Now.ToString("dd.MM.yyyy");
        Console.WriteLine(datetime);

        string datetime2 = DateTime.Now.ToString("HH:mm");
        Console.WriteLine(datetime2);

    }
}