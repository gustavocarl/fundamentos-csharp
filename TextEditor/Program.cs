Menu();

static void Menu()
{
    Console.Clear();

    Console.WriteLine("Selecione uma opção do Editor de Textos: ");
    Console.WriteLine("1 - Criar novo Texto: ");
    Console.WriteLine("2 - Abrir Texto:");
    Console.WriteLine("0 - Sair");

    short option = short.Parse(Console.ReadLine()!);

    switch (option)
    {
        case 0:
            Environment.Exit(0);
            break;
        case 1:
            CreateText();
            break;
        case 2:
            OpenText();
            break;
        default:
            Menu();
            break;
    }
}

static void CreateText()
{
    Console.Clear();

    Console.WriteLine("Editor de Texto Aberto");
    Console.WriteLine("Digite seu Texto Abaixo ou (ESC para sair)");
    Console.WriteLine("======================");

    string text = "";

    do
    {
        text += Console.ReadLine();
        text += Environment.NewLine;
    } while (Console.ReadKey().Key != ConsoleKey.Escape);

    SaveText(text);
}

static void OpenText()
{
    Console.WriteLine("Qual aerquivo deseja abrir:");
    string path = Console.ReadLine()!;

    using (var reader = new StreamReader(path))
    {
        string line;

        while ((line = reader.ReadLine()!) != null)
        {
            Console.WriteLine(line);
        }
    }

    Console.WriteLine("Arquivo lido com sucesso!");
    Console.ReadLine();

    Menu();
}

static void SaveText(string text)
{
    Console.WriteLine("Qual caminho deseja salvar o arquivo:");
    string path = Console.ReadLine()!;

    using (var sw = new StreamWriter(path))
    {
        sw.Write(text);
    }

    Console.WriteLine($"Arquivo Salvo com Sucesso no Caminho {path}");
    Console.ReadLine();

    Menu();
}
