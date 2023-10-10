using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite uma frase: ");
        string entrada = Console.ReadLine();

        if (!string.IsNullOrWhiteSpace(entrada))
        {
            string[] palavras = entrada.Split(' ');

            int palavrasMaiusculas = 0;
            int palavrasMinusculas = 0;
            int palavrasIniciaMaiuscula = 0;
            int palavrasIniciaMinuscula = 0;

            foreach (string palavra in palavras)
            {
                if (int.TryParse(palavra, out _))
                {
                    // Se a palavra for um número, não a contamos
                }
                else if (palavra == palavra.ToUpper() && palavra.Length > 1)
                {
                    palavrasMaiusculas++;
                }
                else if (palavra == palavra.ToLower() && palavra.Length > 1)
                {
                    palavrasMinusculas++;
                }
                else if (!string.IsNullOrEmpty(palavra))
                {
                    if (char.IsUpper(palavra[0]))
                    {
                        palavrasIniciaMaiuscula++;
                    }
                    else
                    {
                        palavrasIniciaMinuscula++;
                    }
                }
            }

            Console.WriteLine("Palavras em maiúsculas: " + palavrasMaiusculas);
            Console.WriteLine("Palavras em minúsculas: " + palavrasMinusculas);
            Console.WriteLine("Palavras iniciadas com letra maiúscula: " + palavrasIniciaMaiuscula);
            Console.WriteLine("Palavras iniciadas com letra minúscula: " + palavrasIniciaMinuscula);
            Console.WriteLine("Quantidade total de palavras: " + (palavrasMaiusculas + palavrasMinusculas + palavrasIniciaMaiuscula + palavrasIniciaMinuscula));
        }
        else
        {
            Console.WriteLine("Entrada inválida. Deve ser uma frase de texto.");
        }
    }
}
