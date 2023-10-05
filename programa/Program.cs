using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("DIGITE UM NÚMERO:");
        double numero = Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine("DIGITE OUTRO NÚMERO:");
        double numero2 = Convert.ToDouble(Console.ReadLine());

        if (numero2 > numero)
        {
            Console.WriteLine($"O numero {numero2} é maior");
        }
        else
        {
            Console.WriteLine($"O numero {numero} é maior");
        }

        Console.WriteLine($"A soma dos dois números é: {numero + numero2}");

        Console.ReadKey();
    }
}