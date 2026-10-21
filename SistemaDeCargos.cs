using System.Linq.Expressions;

namespace C__normall_fixo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string nome;
            int cargo;

            Console.WriteLine("digite o seu nome: ");
            nome = Console.ReadLine();


            Console.WriteLine("digite [1] Desenvolvedor Jr");
            Console.WriteLine("digite [2] Analista de RH");
            Console.WriteLine("digite [3] Técnico de Suporte");
            cargo = int.Parse(Console.ReadLine());

            switch (cargo)
            {
                case 1:
                    Console.WriteLine("Olá " + nome);
                    Console.WriteLine(" O seu cargo é: Desenvolvedor Jr eo salario e (xxxx)");
            break;


                case 2:
                    Console.WriteLine("Olá " + nome);
                    Console.WriteLine("O seu cargo é: Analista de RH e o salario e (xxxx)");
                    break;

                case 3:
                    Console.WriteLine("Olá " + nome);
                    Console.WriteLine("O seu cargo é: Técnico de Suporte e o salario e (xxxx)");
                    break;

            }

            
        }
    }
}
