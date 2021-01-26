using System;
using System.Globalization;

namespace ExercicioDeFixacaoV39
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Pessoas p1, p2;

             p1 = new Pessoas();
             p2 = new Pessoas();

             Console.WriteLine("Dados da primeira pessoa:");
             Console.Write("Nome: ");
             p1.nome = Console.ReadLine();
             Console.Write("Idade: ");
             p1.idade = int.Parse(Console.ReadLine());
             Console.WriteLine("Dados da segunda pessoa:");
             Console.Write("Nome: ");
             p2.nome = Console.ReadLine();
             Console.Write("Idade: ");
             p2.idade = int.Parse(Console.ReadLine());

             if (p1.idade > p2.idade) Console.WriteLine($"Pessoa mais velha: {p1.nome}");
             else if (p2.idade > p1.idade) Console.WriteLine($"Pessoa mais velha: {p2.nome}");
             else Console.WriteLine("As duas pessoas têm a mesma idade.");*/

            double media = 0;

            Funcionarios f1, f2;

            f1 = new Funcionarios();
            f2 = new Funcionarios();

            Console.WriteLine("Dados do primeiro funcionário:");
            Console.Write("Nome: ");
            f1.nome = Console.ReadLine();
            Console.Write("Salário: ");
            f1.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Dados do segundo funcionário:");
            Console.Write("Nome: ");
            f2.nome = Console.ReadLine();
            Console.Write("Salário: ");
            f2.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            media = (f1.salario + f2.salario) / 2;

            Console.WriteLine($"Salário médio = {media.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
