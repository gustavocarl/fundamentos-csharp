using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {
        Menu();
    }

    static void Menu()
    {
        Console.Clear();

        Console.WriteLine("Selecione uma opção para o contador: ");
        Console.WriteLine("1 - Adicionar Timer");
        Console.WriteLine("0 - Sair");

        int option = int.Parse(Console.ReadLine()!);

        if (option == 0)
            Environment.Exit(0);
        else
        {
            Console.WriteLine("Quanto tempo deseja Adicionar: ");
            Console.WriteLine("Tempo em Segundos => 10s");
            Console.WriteLine("Tempo em Minutos => 1m");

            string timer = Console.ReadLine()!.ToLower();

            char type = char.Parse(timer.Substring(timer.Length - 1, 1));
            int time = int.Parse(timer.Substring(0, timer.Length - 1));


            if (type == 'm')
            {
                time *= 60;

            }
            PreStart(time);
        }
    }

    static void PreStart(int time)
    {
        Console.Clear();

        Console.WriteLine("Ready...");
        Thread.Sleep(1000);

        Console.WriteLine("Steady...");
        Thread.Sleep(1000);

        Console.WriteLine("Go...");
        Thread.Sleep(2500);

        Start(time);
    }

    static void Start(int time)
    {
        Console.Clear();

        int startPoint = 0;

        while (startPoint != time)
        {
            Console.Clear();
            startPoint++;
            Console.WriteLine(startPoint);
            Thread.Sleep(1000);
        }

        Console.WriteLine("Contagem finalizada com sucesso!");
        Console.WriteLine("Pressione ENTER para continuar...");

        Console.ReadLine();

        Menu();
    }
}