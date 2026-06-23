namespace Vetores;

public class Menu
{
    public static void Exibir()
    {
        while (true)
        {
            Console.Clear();

            Console.WriteLine("==================================");
            Console.WriteLine(" ATIVIDADES - VETORES");
            Console.WriteLine("==================================");
            Console.WriteLine("1 - Média de notas");
            Console.WriteLine("2 - Controle de idade");
            Console.WriteLine("3 - Gastos da semana");
            Console.WriteLine("4 - Horas de estudo");
            Console.WriteLine("5 - Temperaturas");
            Console.WriteLine("6 - Análise de números");
            Console.WriteLine("7 - Produtos e preços");
            Console.WriteLine("8 - Pesquisa de preferência");
            Console.WriteLine("9 - Lista de tarefas");
            Console.WriteLine("10 - Busca de estudante");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("==================================");

            int opcao = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            switch (opcao)
            {
                case 1:
                    Vetores.atividades_01();
                    break;

                case 2:
                    Vetores.atividades_02();
                    break;

                case 3:
                    Vetores.atividades_03();
                    break;

                case 4:
                    Vetores.atividades_04();
                    break;

                case 5:
                    Vetores.atividades_05();
                    break;

                case 6:
                    Vetores.atividades_06();
                    break;

                case 7:
                    Vetores.atividades_07();
                    break;

                case 8:
                   Vetores.atividades_08();
                    break;

                case 9:
                    Vetores.atividades_09();
                    break;

                case 10:
                    Vetores.atividades_10();
                    break;

                case 0:
                    return;

                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }

            Console.WriteLine();
            Console.WriteLine("Pressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
        }
    }
}