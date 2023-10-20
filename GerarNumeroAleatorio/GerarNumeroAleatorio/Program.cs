namespace GerarNumeroAleatorio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Titulo();
            Operacao();
        }

        static void Titulo()
        {
            Console.WriteLine(@"
            
█▀▀ █▀▀ █▀█ ▄▀█ █▀▄ █▀█ █▀█   █▀▄ █▀▀   █▄░█ █░█ █▀▄▀█ █▀▀ █▀█ █▀█ █▀   ▄▀█ █░░ █▀▀ ▄▀█ ▀█▀ █▀█ █▀█ █ █▀█ █▀
█▄█ ██▄ █▀▄ █▀█ █▄▀ █▄█ █▀▄   █▄▀ ██▄   █░▀█ █▄█ █░▀░█ ██▄ █▀▄ █▄█ ▄█   █▀█ █▄▄ ██▄ █▀█ ░█░ █▄█ █▀▄ █ █▄█ ▄█
");
        }
        
        static void Operacao()
        {
            int numeroSecreto, numeroUsuario;

            Random numeroAleatorio = new Random();

            numeroSecreto = numeroAleatorio.Next(1, 101);
            do
            {

                Console.Write("Digite um número: ");
                string numero = Console.ReadLine();
                numeroUsuario = int.Parse(numero);

                if (numeroUsuario == numeroSecreto)
                {
                    Console.WriteLine("Parabéns, você acertou o número");
                }
                else if (numeroUsuario < numeroSecreto)
                {
                    Console.WriteLine("O numero secreto é maior que " + numeroUsuario);
                }
                else if (numeroUsuario > numeroSecreto)
                {
                    Console.WriteLine("O numero secreto é menor que " + numeroUsuario);
                }
                else
                {
                    Console.WriteLine("Digite um número válido!!");
                }
            } while (numeroUsuario != numeroSecreto);
        }
    }
}