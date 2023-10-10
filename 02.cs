using System;

class Program
{
    static void Main()
    {
        int n1, n2;

        while (true)
        {
            Console.Write("Infore o primeiro número: ");
            if (int.TryParse(Console.ReadLine(), out n1))
            {
                break;
            }
            else
            {
                Console.WriteLine("Número inválido.");
            }
        }

        while (true)
        {
            Console.Write("Infore o segundo número: ");
            if (int.TryParse(Console.ReadLine(), out n2))
            {
                break;
            }
            else
            {
                Console.WriteLine("Número inválido.");
            }
        }

        int multiplicacao = 0;
        int divisaoInteira = 0;
        int contador = 0;

        int sinal = n1 < 0 && n2 < 0 || n1 > 0 && n2 > 0 ? 1 : -1; // para armazenar o valor da multiplicação e divisão com negativos

        // converte ambos os valores para positivos
        if (n1 < 0)
        {
            n1 *= -1;
        }
        if (n2 < 0)
        {
            n2 *= -1;
        }

        for (contador = 0; contador < n2; contador++)
        {
            multiplicacao += n1;
        }
        Console.WriteLine($"Multiplicação: {multiplicacao * sinal}");

        if (n2 != 0)
        {
            while (n1 >= n2)
            {
                n1 -= n2;
                divisaoInteira++;
            }
            Console.WriteLine($"Divisão Inteira: {divisaoInteira * sinal}");
            Console.WriteLine($"Resto da Divisão Inteira: {n1 * sinal}");
        }
        else
        {
            Console.WriteLine("Divisão por zero é indefinida.");
        }

    }
}
