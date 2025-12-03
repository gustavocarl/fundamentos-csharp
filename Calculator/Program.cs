Menu();

void Menu()
{
    Console.Clear();

    Console.WriteLine("Selecione uma opção:");
    Console.WriteLine("1 - Soma ");
    Console.WriteLine("2 - Subtração ");
    Console.WriteLine("3 - Divisão ");
    Console.WriteLine("4 - Multiplicação ");
    Console.WriteLine("=====================");
    Console.WriteLine("0 - Sair");
    Console.WriteLine("=====================");

    short option = short.Parse(Console.ReadLine()!);

    switch (option)
    {
        case 0:
            Environment.Exit(0);
            break;
        case 1:
            Sum();
            break;
        case 2:
            Subtract();
            break;
        case 3:
            Divide();
            break;
        case 4:
            Multiply();
            break;
        default:
            Menu();
            break;
    }
}

void Sum()
{
    Console.Clear();

    Console.WriteLine("Realizando Soma");

    Console.WriteLine("Insira o primeiro valor: ");
    float firstValue = float.Parse(Console.ReadLine()!);

    Console.WriteLine("Insira o segundo valor: ");
    float secondValue = float.Parse(Console.ReadLine()!);

    float sumValue = firstValue + secondValue;

    Console.WriteLine($"O Resultado da Soma é: {sumValue}");

    Console.WriteLine("Pressione ENTER para continuar...");
    Console.ReadLine();
    Menu();
}

void Subtract()
{
    Console.Clear();

    Console.WriteLine("Realizando Subtração");

    Console.WriteLine("Insira o primeiro valor: ");
    float firstValue = float.Parse(Console.ReadLine()!);

    Console.WriteLine("Insira o segundo valor: ");
    float secondValue = float.Parse(Console.ReadLine()!);

    float subtractValue = firstValue - secondValue;

    Console.WriteLine($"O Resultado da Subtração é: {subtractValue}");

    Console.WriteLine("Pressione ENTER para continuar...");
    Console.ReadLine();

    Menu();
}

void Divide()
{
    Console.Clear();

    Console.WriteLine("Realizando Divisão");

    Console.WriteLine("Insira o primeiro valor: ");
    float firstValue = float.Parse(Console.ReadLine()!);

    Console.WriteLine("Insira o segundo valor: ");
    float secondValue = float.Parse(Console.ReadLine()!);

    if (secondValue != 0)
    {
        float divideValue = firstValue / secondValue;
        Console.WriteLine($"O Resultado da Divisão é: {divideValue}");
    }
    else
    {
        Console.WriteLine("Não é possível dividir por 0");
    }

    Console.WriteLine("Pressione ENTER para continuar...");
    Console.ReadLine();

    Menu();
}

void Multiply()
{
    Console.Clear();

    Console.WriteLine("Realizando a Multiplicação");

    Console.WriteLine("Insira o primeiro valor: ");
    float firstValue = float.Parse(Console.ReadLine()!);

    Console.WriteLine("Insira o segundoa valor: ");
    float secondValue = float.Parse(Console.ReadLine()!);

    float multiplyResult = firstValue * secondValue;
    Console.WriteLine($"O Resultado Multiplicação é: {multiplyResult} ");

    Console.WriteLine("Pressione ENTER para continuar...");
    Console.ReadLine();

    Menu();
}
