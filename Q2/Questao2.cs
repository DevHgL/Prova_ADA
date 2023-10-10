using System;

class Program
{
    static void Main()
    {
        int N1, N2;

        Console.Write("Digite o primeiro número (N1): ");
        if (int.TryParse(Console.ReadLine(), out N1))
        {
            Console.Write("Digite o segundo número (N2): ");
            if (int.TryParse(Console.ReadLine(), out N2) && N2 != 0)
            {
                int multiplicacao = 0;
                int divisao = 0;

                int sinalN1 = Math.Sign(N1);
                int sinalN2 = Math.Sign(N2);

                if (sinalN1 == -1 && sinalN2 == 1 || sinalN1 == 1 && sinalN2 == -1)
                {
                    N1 = Math.Abs(N1);
                    N2 = Math.Abs(N2);
                }

                for (int i = 0; i < N2; i++)
                {
                    multiplicacao += N1;
                }

                while (N1 >= N2)
                {
                    N1 -= N2;
                    divisao++;
                }

                Console.WriteLine("Multiplicação: " + (multiplicacao * (sinalN1 * sinalN2)));
                Console.WriteLine("Divisão inteira: " + (divisao * (sinalN1 * sinalN2)));
            }
            else
            {
                Console.WriteLine("N2 deve ser um número inteiro não nulo.");
            }
        }
        else
        {
            Console.WriteLine("N1 deve ser um número inteiro.");
        }
    }
}
