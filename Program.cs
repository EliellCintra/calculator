
Menu();

static void Menu()
{
    Console.Clear();

    Console.WriteLine("\n\tCALCULADORA\n");
    Console.WriteLine("Qual operação deseja fazer?");
    Console.WriteLine("1 - Soma");
    Console.WriteLine("2 - Subtração");
    Console.WriteLine("3 - Divisão");
    Console.WriteLine("4 - Multiplicação");
    Console.WriteLine("5 - Sair");
    Console.WriteLine("----------------------------");

    Console.WriteLine("Selecione uma opção:");
    short resposta = short.Parse(Console.ReadLine());

    switch (resposta)
    {
        case 1: Soma(); break;
        case 2: Subtracao(); break;
        case 3: Divisao(); break;
        case 4: Multiplicacao(); break;
        case 5:
            {
                Console.Clear();
                Environment.Exit(0);
                break;
            }
        default: Menu(); break;
    }
}

static void Soma()
{
    Console.Clear();

    Console.WriteLine("\n\tSOMA\n");
    Console.WriteLine("Digite o primeiro valor:");
    float valor1 = float.Parse(Console.ReadLine());

    Console.WriteLine("Digite o segundo valor:");
    float valor2 = float.Parse(Console.ReadLine());

    float resultado = valor1 + valor2;

    Console.WriteLine("\n----------------------------");
    Console.WriteLine($"\nO resultado da soma é {resultado}\n");
    Console.WriteLine("----------------------------");
    Console.WriteLine("\nPressione qualquer tecla para continuar...");
    Console.ReadKey();
    Menu();
}

static void Subtracao()
{
    Console.Clear();

    Console.WriteLine("\n\tSUBTRAÇÃO\n");
    Console.WriteLine("Digite o primeiro valor:");
    float valor1 = float.Parse(Console.ReadLine());

    Console.WriteLine("Digite o segundo valor:");
    float valor2 = float.Parse(Console.ReadLine());

    float resultado = valor1 - valor2;

    Console.WriteLine("\n----------------------------");
    Console.WriteLine($"\nO resultado da subtração é {resultado}\n");
    Console.WriteLine("----------------------------");
    Console.WriteLine("\nPressione qualquer tecla para continuar...");
    Console.ReadKey();
    Menu();
}

static void Divisao()
{
    Console.Clear();

    Console.WriteLine("\n\tDIVISÃO\n");
    Console.WriteLine("Digite o primeiro valor:");
    float valor1 = float.Parse(Console.ReadLine());

    Console.WriteLine("Digite o segundo valor:");
    float valor2 = float.Parse(Console.ReadLine());

    float resultado = valor1 / valor2;

    Console.WriteLine("\n----------------------------");
    Console.WriteLine($"\nO resultado da divisão é {resultado}\n");
    Console.WriteLine("----------------------------");
    Console.WriteLine("\nPressione qualquer tecla para continuar...");
    Console.ReadKey();
    Menu();
}

static void Multiplicacao()
{
    Console.Clear();

    Console.WriteLine("\n\tMULTIPLICAÇÃO\n");
    Console.WriteLine("Digite o primeiro valor:");
    float valor1 = float.Parse(Console.ReadLine());

    Console.WriteLine("Digite o segundo valor:");
    float valor2 = float.Parse(Console.ReadLine());

    float resultado = valor1 * valor2;

    Console.WriteLine("\n----------------------------");
    Console.WriteLine($"\nO resultado da multiplicação é {resultado}\n");
    Console.WriteLine("----------------------------");
    Console.WriteLine("\nPressione qualquer tecla para continuar...");
    Console.ReadKey();
    Menu();
}

