using System;

namespace If_Else_CSharp_07
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, resultado;
            string avaliacao = "";

            Console.WriteLine("Digite a nota 1 do aluno:");
            n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a nota 2 do aluno:");
            n2 = double.Parse(Console.ReadLine());

            resultado = (n1 + n2) / 2;

            if (resultado >= 6)
            {
                avaliacao = "Parabéns, você passou!";
            }
            else if (resultado >= 5)
            {
                avaliacao = "Vishh! Você está de recuperação.";
            }
            else
            {
                avaliacao = "Oxe, se lascou. Você foi reprovado";
            }
            Console.WriteLine("A média do aluno é: " + resultado + " " + avaliacao);
        }
    }
}
