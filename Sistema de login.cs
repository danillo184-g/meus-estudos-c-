namespace C__normall_fixo
{
    internal class Program
    {
        static void Main(string[] args) 
        {
         
         String nome,email,senha,confirma_senha;
         int idade;

                Console.WriteLine("Digite seu nome completo: ");
                nome=Console.ReadLine();

            
                Console.WriteLine("Digite sua idade: ");
                idade = int.Parse(Console.ReadLine());


                Console.WriteLine("dDigite um e-mail válido");
                email=Console.ReadLine();


                Console.WriteLine("Digite uma senha para cadastro ");
                senha=Console.ReadLine();

                Console.WriteLine("confirme a senha ");
                confirma_senha=Console.ReadLine();

            
            while (senha != confirma_senha) 
            { 
             Console.WriteLine("As senhas não coincidem. Tente novamente.");
             confirma_senha = Console.ReadLine();
            }
            
         
            Console.WriteLine("Cadastro concluído!");
         
            Console.WriteLine("Nome: " + nome);
           
            Console.WriteLine(idade+ " anos");
        }
    }
}
