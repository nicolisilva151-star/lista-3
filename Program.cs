 double[] notas = new double[5];
        double soma = 0;

        for (int i = 0; i < 5; i++)
        {
            Console.Write("Informe a nota: ");
            notas[i] = double.Parse(Console.ReadLine());

            soma += notas[i];
        }

        double media = soma / 5;

        Console.WriteLine("Soma das notas: " + soma);
        Console.WriteLine("Média final: " + media);

