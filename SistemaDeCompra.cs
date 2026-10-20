namespace C__normall_fixo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double compra;
            string pagamento;

            Console.WriteLine("Qual o valor da compra? ");
            compra = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual será a forma de pagamento?");
            pagamento=Console.ReadLine();



            if (compra >=100 && pagamento == "A VISTA") 
            {
                Console.WriteLine("Desconto de 10%. Total a pagar será: " + compra*0.9);
            }

            else
            {
                Console.WriteLine("O valor da compra é " + compra );
            }
        }
    }
}
