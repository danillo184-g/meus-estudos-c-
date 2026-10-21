

namespace C__normall_fixo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double salario, aluguel, energia, internet,result;

            Console.WriteLine("Digite seu salário");
            salario = double.Parse(Console.ReadLine());


            Console.WriteLine("digite o valor do aluguel");
            aluguel = double.Parse(Console.ReadLine());

            Console.WriteLine("digite o valor da energia");
            energia = double.Parse(Console.ReadLine());

            Console.WriteLine("digite o valor da internet");
            internet = double.Parse(Console.ReadLine());

            result = salario - aluguel - energia - internet;
            Console.WriteLine("sobrou: R$" + result);

        }
    }
}
