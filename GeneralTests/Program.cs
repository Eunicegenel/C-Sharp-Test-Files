class Program
{
    public static void Main(string[] args) {
      whatIsYourName();
    }

    public static void whatIsYourName() {
        Console.Write("Enter your Name : ");
        string name = Console.ReadLine();
        Console.Write("Enter your Age : ");
        string age = Console.ReadLine();
        Console.Beep();
        Console.WriteLine($"{name}... Your already {age} years old but your name sucks!");
        Console.ReadKey();
    }
}