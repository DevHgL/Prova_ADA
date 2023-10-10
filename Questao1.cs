/*
 * 
 * 1 - Escreva um programa que faça a leitura de 5 valores Inteiros do usuário. 
 * Em seguida, o programa deve exibir no console a informação de quantos dos valores digitados são pares, 
 * quantos dos valores digitados são ímpares, quantos deles são positivos e, por fim, quantos são negativos. 
 * Cada uma das informações deve ser escrita em uma linha diferente.
 * 
 */

using System;

class Program
{
    static void Main()
    {   
        // Declaração do vetor de 5 posições.

        int[] valores = new int[5];

        // Setando todas as variáveis para 0, para não ter conflito.

        int pares = 0;
        int impares = 0;
        int positivos = 0;
        int negativos = 0;

        // Entrada de dados digitados pelo o usuário.

        for (int i = 0; i < 5; i++)
        {
            Console.Write("Digite o {0}° valor : ", i + 1);
            try
            {
                if (int.TryParse(Console.ReadLine(), out valores[i]))
                {
                    if (valores[i] % 2 == 0) // Verifica se é par.
                    {
                        pares++;
                    }
                    else // Caso não for par, é ímpar.
                    {
                        impares++;
                    }

                    if (valores[i] > 0) // Verifica se é maior que 0.
                    {
                        positivos++;
                    }
                    else if (valores[i] < 0) // Verifica se é menor que 0.
                    {
                        negativos++;
                    }
                }
                else // Tratamento de erro em geral.
                {
                    Console.WriteLine("Valor inválido. Tente novamente.");
                    i--;
                }
            }
            catch (Exception e) // Mensagem de erro caso passe pelo if/else.
            {
                Console.WriteLine("Ocorreu um erro: " + e.Message);
                i--; // Tente novamente em caso de erro
            }
        }

        Console.WriteLine("Quantidade de valores pares: " + pares);
        Console.WriteLine("Quantidade de valores ímpares: " + impares);
        Console.WriteLine("Quantidade de valores positivos: " + positivos);
        Console.WriteLine("Quantidade de valores negativos: " + negativos);
    }
}
