using System.ComponentModel;
using System.Security.AccessControl;

namespace Aprendendo
{
    internal class Program
    {
        //static List<string> listaBandas = new List<string> { "GUNS N ROSES", "THE BEATLES"};
        static Dictionary<string, List<int>> dicionarioBandas = new Dictionary<string, List<int>>();

        static void Main(string[] args)
        {
                BoasVindas();
                MenuOpcoes();
        }

        static void BoasVindas()
        {
            Console.WriteLine(@"
            
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");

            Console.WriteLine("Boas vindas ao sistema");
        }

        static void MenuOpcoes()
        {
            Console.WriteLine("\nDigite 1 para registrar uma banda");
            Console.WriteLine("Digite 2 para mostrar todas as bandas");
            Console.WriteLine("Digite 3 para avaliar uma banda");
            Console.WriteLine("Digite 4 para exibir a média de uma banda");
            Console.WriteLine("Digite 0 para sair");

            Console.Write("\nDigite uma opção: ");
            string respostaOpcao = Console.ReadLine()!; // O símbolo ! Indica que não quer trabalhar com valor nulo
            int opcao = int.Parse(respostaOpcao); // Convertendo de string para inteiro com .Parse

            switch (opcao)
            {
                case 1:
                    RegistrarBandas();
                    break;
                case 2:
                    VisualizarBandas();
                    break;
                case 3:
                    AvaliarBanda();
                    break;
                case 4:
                    ExibirMedias();
                    break;
                case 0:
                    Console.WriteLine("\nTchau Tchau :)");
                    break;
                default:
                    Console.WriteLine("\nDigite uma opção válida");
                    break;            
            }      
        }

        static void RegistrarBandas()
        {
            Console.Clear();
            ExibirTitulo("Registrar bandas");
            Console.Write("Digite o nome da banda que deseja registrar: ");
            string nomeBanda = Console.ReadLine()!;
            dicionarioBandas.Add(nomeBanda, new List<int>());
            Console.WriteLine($"A banda {nomeBanda} foi registada com sucesso!");
            Thread.Sleep(1000); // Espera 2000ms
            Console.Clear(); // Limpa o console
            BoasVindas();
            MenuOpcoes();
        }

        static void Bandas()
        {
            //for(int i = 0; i < listaBandas.Count; i++)
            //{
            //    Console.WriteLine($"Banda: {listaBandas[i]}"); 
            //}
            foreach (string banda in dicionarioBandas.Keys)
            {
                Console.WriteLine(banda);
            }

        }

        static void VisualizarBandas()
        {
            Console.Clear();
            ExibirTitulo("Visualizar Bandas");
            Bandas();
            Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
            BoasVindas();
            MenuOpcoes();
        }

        static void ExibirTitulo(string titulo)
        {
            int quantidadeDeLetras = titulo.Length;
            string asteristicos = string.Empty.PadLeft(quantidadeDeLetras, '*'); // começa com uma string vazia e adiciona a esquerda com PadLeft no tamanho "quantidadeDeLetras" os asteristicos passado como segundo parâmentro
            Console.WriteLine(asteristicos);
            Console.WriteLine(titulo);
            Console.WriteLine(asteristicos + "\n");
        }

        static void AvaliarBanda()
        {
            Console.Clear();
            ExibirTitulo("Avaliar Banda");
            Console.WriteLine("Bandas cadastradas: \n");
            Bandas();
            Console.Write("\nDigite o nome da banda que deseja avaliar: ");
            string nomeDaBanda = Console.ReadLine();

            if (dicionarioBandas.ContainsKey(nomeDaBanda))
            {
                Console.Write("Digite a nota que a banda merece: ");
                int nota = int.Parse(Console.ReadLine()!);
                dicionarioBandas[nomeDaBanda].Add(nota);
                Console.WriteLine($"\n A {nota} foi registrada com sucesso");
                Thread.Sleep(1000);
                Console.Clear();
                BoasVindas();
                MenuOpcoes();
            }
            else
            {
                Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada");
                Console.WriteLine("Digite uma tecla para volar ao menu principal");
                Console.ReadKey();
                MenuOpcoes();
            }
        }

        static void ExibirMedias()
        {
            Console.Clear();
            ExibirTitulo("Media das bandas");
            Console.WriteLine("Bandas cadastradas: \n");
            Bandas();
            Console.Write("\nDigite o nome da banda que você deseja visualizar a média: ");
            string nomeDaBanda = Console.ReadLine();
            if (dicionarioBandas.ContainsKey(nomeDaBanda))
            {
                double mediaBandas = dicionarioBandas[nomeDaBanda].Average();
                Console.WriteLine($"A media da banda {nomeDaBanda} é {mediaBandas}");
                Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
                Console.ReadKey();
                Console.Clear();
                MenuOpcoes();
            }
        }
    }
}