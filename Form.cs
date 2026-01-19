class Form
{
   public static void GetForm()
    {
        
        
            
        System.Console.Write("Введите имя");
        string name = Console.ReadLine()!;
        System.Console.WriteLine("Введите фамилию");
        string surname = Console.ReadLine()!;
        System.Console.WriteLine($"Ваше имя {name} ваша фамилия {surname} ");
        Console.ReadLine();
        
        
    }
}