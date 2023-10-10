using System;

class Program
{
    static void Main()
    {
        int pares = 0;
        int impares = 0;
        int positivos = 0;
        int negativos = 0;

        for (int i = 1; i <= 5; i++)
        {
            Console.Write($"Digite o número {i}: ");
            if (int.TryParse(Console.ReadLine(), out int numero))
            {
                if (numero % 2 == 0) // 0 é par ok
                {
                    pares++;
                }
                else
                {
                    impares++;
                }

                if (numero > 0) // vish 0 é neutro
                {
                    positivos++;
                }
                else if (numero < 0)
                {
                    negativos++;
                }
            }
            else
            {
                Console.WriteLine("Valor inválido.");
                i--;
            }
        }

        Console.WriteLine($"Quantidade pares: {pares}");
        Console.WriteLine($"Quantidade ímpares: {impares}");
        Console.WriteLine($"Quantidade positivos: {positivos}");
        Console.WriteLine($"Quantidade negativos: {negativos}");
    }
}
