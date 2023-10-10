using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.Write("Digite a frase: ");
        string frase = Console.ReadLine();

        // utiliza regex para remover pontuação, mantendo somente letras e espaços (que vão ser utilizados para separar as palavras)
        frase = Regex.Replace(frase, @"[^a-zA-Z\s]", "");

        string[] palavras = frase.Split(' ');

        int totalPalavras = 0;
        int maiusculas = 0;
        int minusculas = 0;
        int iniciamMaiuscula = 0;
        int iniciamMinuscula = 0;

        foreach (string palavra in palavras)
        {
            if (palavra.Length == 0) // pula palavras vazias, fruto de espaços duplicados, no inicio, ou no final
            {
                continue;
            }

            if (palavra == palavra.ToUpper())
            {
                maiusculas++;
            }
            else if (palavra == palavra.ToLower())
            {
                minusculas++;
            }
            else if (palavra[0].ToString() == palavra[0].ToString().ToUpper()) // nesse caso a palavra não é inteiramente maiscula, mas começa com maiscula
            {
                iniciamMaiuscula++;
            }
            else if (palavra[0].ToString() == palavra[0].ToString().ToLower()) // nesse caso a palavra não é inteiramente minuscula, mas começa com minuscula
            {
                iniciamMinuscula++;
            }
            totalPalavras++;
        }

        Console.WriteLine($"Palavras maiúsculas: {maiusculas}");
        Console.WriteLine($"Palavras minúsculas: {minusculas}");
        Console.WriteLine($"Palavras que iniciam com maiúscula: {iniciamMaiuscula}");
        Console.WriteLine($"Palavras que iniciam com minúscula: {iniciamMinuscula}");
        Console.WriteLine($"Total de palavras: {totalPalavras}");
    }
}
