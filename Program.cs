Menu();

static void Menu()
{
    Console.Clear();
    Console.WriteLine("O que você deseja fazer?");
    Console.WriteLine("1- Abrir arquivo");
    Console.WriteLine("2- Criar novo arquivo");
    Console.WriteLine("0- Sair");

    short option = short.Parse(Console.ReadLine());

    switch (option)
    {
        case 0: Environment.Exit(0); break;
        case 1: Abrir(); break;
        case 2: Editar(); break;
        default: Menu(); break;
    }
}

static void Abrir() 
{
    Console.Clear();
    Console.WriteLine("Qual caminho do arquivo?");
    string path = Console.ReadLine();

    using (var file = new StreamReader(path))
    {
        string text = file.ReadToEnd();
        Console.WriteLine(text);
    }

    Console.ReadLine();
    Menu();
}

static void Editar() 
{
    Console.WriteLine("Digite seu texto (ESC para sair)");
    Console.WriteLine("--------------------------------");

    string text = "";
    do
    {
        text += Console.ReadLine();
        text += Environment.NewLine;
    } while (Console.ReadKey().Key != ConsoleKey.Escape);

/*
    ConsoleKeyInfo tecla;

    do 
    {
        // Captura somente a tecla
        tecla = Console.ReadKey();

        // Verifica se é a tecla enter. Se for, pula para outr linha.
        // Isso tem que ser feito. Senão a linha atual é sobrescrita
        if (tecla.Key == ConsoleKey.Enter) Console.WriteLine("");

        text += tecla.KeyChar;
    } while (tecla.Key != ConsoleKey.Escape);

    // Remove "Esc" que é um caracter invisível 
    text = text.Substring(0, text.Length -1);
*/
    Salvar(text);
}

static void Salvar(string text)
{
    Console.Clear();
    Console.WriteLine(" Qual caminho para salvar o arquivo?");
    var path = Console.ReadLine();

    // StreamWriter => Fluxo de escrita.
    using (var file = new StreamWriter(path))
    {
        file.Write(text);
    }

    Console.WriteLine($"Arquivo {path} salvo com sucesso!");
    Console.ReadLine();
    Menu();
}

