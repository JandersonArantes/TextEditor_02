```
Aplicativo: Editor De Texto

Menu();
static void Menu()
static void Abrir() 
static void Editar()
static void Salvar(string text)

Este aplicativo oferece as opções:
- Criar um arquivo com extensão .txt, digitar um texto e salvar.
- Abrir/ler um arquivo de texto existente.

*******************************************************************


*** Explicando o código

// Chama o método Menu()
Menu();

// Métod Menu()
static void Menu()
{
    // Limpa a tela
    Console.Clear();
    // Exibe mensagem
    Console.WriteLine("O que você deseja fazer?");
    // Exibe mensagem
    Console.WriteLine("1- Abrir arquivo");
    // Exibe mensagem
    Console.WriteLine("2- Criar novo arquivo");
    // Exibe mensagem
    Console.WriteLine("0- Sair");

    // A variável "option" recebe a leitura da opção do usúario que é convertida para o tipo short.
    // short é o tipo escolhido. Pois, as opções disponíveis são de números pequenos e o tipo
    // short é suficiente
    short option = short.Parse(Console.ReadLine());

    // Laço de repetição para processar a opção escolhida
    switch (option)
    {
        // Caso a opção seja 0, encerra a aplicação
        case 0: Environment.Exit(0); break;
        // Caso a opção seja 1, chama o método Abrir()
        case 1: Abrir(); break;
        // Caso a opção sea 2, chama o método Editar()
        case 2: Editar(); break;
        // Caso a opção seja um número diferente de 0, 1 ou 2, chama o método Menu() novamente
        default: Menu(); break;
    }
}

// Método Abrir()
static void Abrir() 
{
    // Limpa a tela
    Console.Clear();
    // Exibe mensagem
    Console.WriteLine("Qual caminho do arquivo?");
    // A vairável "path", do tipo string recebe a leitura do caminho e nome do arquivo com extensão .txt existente
    string path = Console.ReadLine();

    // "using" controla a abertura e fechamento de um arquivo
    // "file" é declarado como um fluxo de escrita para o caminho/arquivo informado
    using (var file = new StreamReader(path))
    {
        string text = file.ReadToEnd();
        Console.WriteLine(text);
    }

    Console.ReadLine();
    Menu();
}

static void Editar() 

```
