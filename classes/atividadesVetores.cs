namespace Vetores;

public class Vetores
{
    public static void atividades_01()

{
    double[] notas = new double[5];
    double soma = 0;
    double media;

    for (int i = 0; i < notas.Length; i++)
    {
        Console.Write("Informe a nota: ");
        notas[i] = Convert.ToDouble(Console.ReadLine());
    }

    for (int i = 0; i < notas.Length; i++)
    {
        soma += notas[i];
    }

    media = soma / notas.Length;

    Console.WriteLine();
    Console.WriteLine($"Soma das notas: {soma}");
    Console.WriteLine($"Média final: {media}");
}


    public static void atividades_02()

{
    int[] idades = new int[8];
    int menores = 0;
    int maiores = 0;

    for (int i = 0; i < idades.Length; i++)
    {
        Console.Write("Informe a idade do estudante: ");
        idades[i] = Convert.ToInt32(Console.ReadLine());
    }

    for (int i = 0; i < idades.Length; i++)
    {
        if (idades[i] < 18)
        {
            menores++;
        }
        else
        {
            maiores++;
        }
    }

    Console.WriteLine();
    Console.WriteLine($"Quantidade de menores de idade: {menores}");
    Console.WriteLine($"Quantidade de maiores de idade: {maiores}");
}
    

    public static void atividades_03()

{
    double[] gastos = new double[7];
    double soma = 0;
    double media;
    double maior;
    double menor;

    for (int i = 0; i < gastos.Length; i++)
    {
        Console.Write("Informe o gasto do dia: ");
        gastos[i] = Convert.ToDouble(Console.ReadLine());
    }

    maior = gastos[0];
    menor = gastos[0];

    for (int i = 0; i < gastos.Length; i++)
    {
        soma += gastos[i];

        if (gastos[i] > maior)
        {
            maior = gastos[i];
        }

        if (gastos[i] < menor)
        {
            menor = gastos[i];
        }
    }

    media = soma / gastos.Length;

    Console.WriteLine();
    Console.WriteLine($"Total gasto na semana: R$ {soma}");
    Console.WriteLine($"Média diária de gastos: R$ {media}");
    Console.WriteLine($"Maior gasto: R$ {maior}");
    Console.WriteLine($"Menor gasto: R$ {menor}");
}
    

    public static void atividades_04()
    
{
    double[] horas = new double[7];
    double total = 0;
    int metaAtingida = 0;
    int metaNaoAtingida = 0;

    for (int i = 0; i < horas.Length; i++)
    {
        Console.Write("Informe as horas estudadas no dia: ");
        horas[i] = Convert.ToDouble(Console.ReadLine());
    }

    for (int i = 0; i < horas.Length; i++)
    {
        total += horas[i];

        if (horas[i] >= 2)
        {
            metaAtingida++;
        }
        else
        {
            metaNaoAtingida++;
        }
    }

    Console.WriteLine();
    Console.WriteLine($"Total de horas estudadas: {total}");
    Console.WriteLine($"Dias com meta atingida: {metaAtingida}");
    Console.WriteLine($"Dias com meta não atingida: {metaNaoAtingida}");
}
    

    public static void atividades_05()
    
{
    double[] temperaturas = new double[6];
    double soma = 0;
    double media;
    double maior;
    double menor;
    int acimaMedia = 0;

    for (int i = 0; i < temperaturas.Length; i++)
    {
        Console.Write("Informe a temperatura registrada: ");
        temperaturas[i] = Convert.ToDouble(Console.ReadLine());
    }

    maior = temperaturas[0];
    menor = temperaturas[0];

    for (int i = 0; i < temperaturas.Length; i++)
    {
        soma += temperaturas[i];

        if (temperaturas[i] > maior)
        {
            maior = temperaturas[i];
        }

        if (temperaturas[i] < menor)
        {
            menor = temperaturas[i];
        }
    }

    media = soma / temperaturas.Length;

    for (int i = 0; i < temperaturas.Length; i++)
    {
        if (temperaturas[i] > media)
        {
            acimaMedia++;
        }
    }

    Console.WriteLine();
    Console.WriteLine($"Média das temperaturas: {media}");
    Console.WriteLine($"Dias acima da média: {acimaMedia}");
    Console.WriteLine($"Maior temperatura: {maior}");
    Console.WriteLine($"Menor temperatura: {menor}");
}
    

    public static void atividades_06()
{
    int[] numeros = new int[10];

    int positivos = 0;
    int negativos = 0;
    int zeros = 0;
    int pares = 0;
    int impares = 0;

    for (int i = 0; i < numeros.Length; i++)
    {
        Console.Write("Informe um número inteiro: ");
        numeros[i] = Convert.ToInt32(Console.ReadLine());
    }

    for (int i = 0; i < numeros.Length; i++)
    {
        if (numeros[i] > 0)
        {
            positivos++;
        }
        else if (numeros[i] < 0)
        {
            negativos++;
        }
        else
        {
            zeros++;
        }

        if (numeros[i] % 2 == 0)
        {
            pares++;
        }
        else
        {
            impares++;
        }
    }

    Console.WriteLine();
    Console.WriteLine($"Quantidade de positivos: {positivos}");
    Console.WriteLine($"Quantidade de negativos: {negativos}");
    Console.WriteLine($"Quantidade de zeros: {zeros}");
    Console.WriteLine($"Quantidade de pares: {pares}");
    Console.WriteLine($"Quantidade de ímpares: {impares}");
}
    

    public static void atividades_07()
{
    string[] produtos = new string[5];
    double[] precos = new double[5];

    double soma = 0;

    Console.WriteLine("Cadastro de Produtos");
    Console.WriteLine();

    for (int i = 0; i < produtos.Length; i++)
    {
        Console.Write("Informe o nome do produto: ");
        produtos[i] = Console.ReadLine();

        Console.Write("Informe o preço do produto: ");
        precos[i] = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine();
    }

    double maior = precos[0];
    double menor = precos[0];

    string produtoMaior = produtos[0];
    string produtoMenor = produtos[0];

    for (int i = 0; i < precos.Length; i++)
    {
        soma += precos[i];

        if (precos[i] > maior)
        {
            maior = precos[i];
            produtoMaior = produtos[i];
        }

        if (precos[i] < menor)
        {
            menor = precos[i];
            produtoMenor = produtos[i];
        }
    }

    Console.WriteLine();
    Console.WriteLine($"Produto mais caro: {produtoMaior}");
    Console.WriteLine($"Preço do produto mais caro: R$ {maior}");
    Console.WriteLine();

    Console.WriteLine($"Produto mais barato: {produtoMenor}");
    Console.WriteLine($"Preço do produto mais barato: R$ {menor}");
    Console.WriteLine();

    Console.WriteLine($"Total dos preços: R$ {soma}");
}
    
    public static void atividades_08()

{
    int[] votos = new int[12];

    int pizza = 0;
    int hamburguer = 0;
    int pastel = 0;

    for (int i = 0; i < votos.Length; i++)
    {
        Console.WriteLine("1 - Pizza");
        Console.WriteLine("2 - Hambúrguer");
        Console.WriteLine("3 - Pastel");
        Console.Write("Informe o voto do estudante: ");
        votos[i] = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine();
    }

    for (int i = 0; i < votos.Length; i++)
    {
        if (votos[i] == 1)
        {
            pizza++;
        }
        else if (votos[i] == 2)
        {
            hamburguer++;
        }
        else if (votos[i] == 3)
        {
            pastel++;
        }
    }

    Console.WriteLine();
    Console.WriteLine($"Votos para Pizza: {pizza}");
    Console.WriteLine($"Votos para Hambúrguer: {hamburguer}");
    Console.WriteLine($"Votos para Pastel: {pastel}");
}
    

    public static void atividades_09()
    {

    string[] tarefas = new string[5];
    int[] prioridades = new int[5];

    int baixa = 0;
    int media = 0;
    int alta = 0;

    for (int i = 0; i < tarefas.Length; i++)
    {
        Console.Write("Informe o nome da tarefa: ");
        tarefas[i] = Console.ReadLine();

        Console.WriteLine("1 - Baixa");
        Console.WriteLine("2 - Média");
        Console.WriteLine("3 - Alta");
        Console.Write("Informe a prioridade da tarefa: ");
        prioridades[i] = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine();
    }

    for (int i = 0; i < prioridades.Length; i++)
    {
        if (prioridades[i] == 1)
        {
            baixa++;
        }
        else if (prioridades[i] == 2)
        {
            media++;
        }
        else if (prioridades[i] == 3)
        {
            alta++;
        }
    }

    Console.WriteLine();
    Console.WriteLine($"Tarefas de baixa prioridade: {baixa}");
    Console.WriteLine($"Tarefas de média prioridade: {media}");
    Console.WriteLine($"Tarefas de alta prioridade: {alta}");

    Console.WriteLine();
    Console.WriteLine("Tarefas de alta prioridade:");

    for (int i = 0; i < tarefas.Length; i++)
    {
        if (prioridades[i] == 3)
        {
            Console.WriteLine($"- {tarefas[i]}");
        }
    }
}

    public static void atividades_10()
    
{
    string[] candidatos = { "Ana", "Bruno", "Carlos" };
    int[] votos = new int[3];

    for (int i = 0; i < 10; i++)
    {
        Console.WriteLine("Candidatos:");
        Console.WriteLine("1 - Ana");
        Console.WriteLine("2 - Bruno");
        Console.WriteLine("3 - Carlos");

        Console.Write("Digite o número do candidato: ");
        int opcao = Convert.ToInt32(Console.ReadLine());

        if (opcao >= 1 && opcao <= 3)
        {
            votos[opcao - 1]++;
        }
        else
        {
            Console.WriteLine("Voto inválido!");
            i--;
        }

        Console.WriteLine();
    }

    Console.WriteLine("Resultado da votação:");

    for (int i = 0; i < candidatos.Length; i++)
    {
        Console.WriteLine($"{candidatos[i]}: {votos[i]} voto(s)");
    }

    int maior = votos[0];
    string vencedor = candidatos[0];

    for (int i = 1; i < votos.Length; i++)
    {
        if (votos[i] > maior)
        {
            maior = votos[i];
            vencedor = candidatos[i];
        }
    }

    Console.WriteLine();
    Console.WriteLine($"Vencedor: {vencedor} com {maior} voto(s).");
}
    }