```
Aplicativo: Editor De Texto

Menu();
static void Menu()
static void Abrir() 
static void Editar()
static void Salvar(string text)

Este aplicativo oferece as opções:
- EDITAR ==> Criar um arquivo com extensão .txt, digitar um texto e salvar.
- ABRIR ==> Abrir/ler um arquivo de texto existente e exibir na tela.
- SAIR ==> Finaliza a aplicação.
***************************************************************************************


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
        // A variável "text" recebe a leitura do início ao fim do texto contido no arquivo
        string text = file.ReadToEnd();
        // Exibe o texto do arquivo
        Console.WriteLine(text);
    }

    // Pausa a tela até o usuário pressionar <enter>
    Console.ReadLine();
    // Chama o método Menu()
    Menu();
}

// Método Editar()
static void Editar()
{
    // Exibe mensagem
    Console.WriteLine("Digite seu texto (ESC para sair)");
    Console.WriteLine("--------------------------------");

    // Atribui vazio a variável "text"
    string text = "";

    // Este laço de repetição é verdadeiro enquanto o usuário não pressionar "Esc" para
    // encerrar a digitação do texto.
    do
    {
        // Concatena o conteúdo da variável "text" com o texto digitado até pressionar <enter>
        text += Console.ReadLine();
        // Inseri nova linha no texto.
        text += Environment.NewLine;
    } while (Console.ReadKey().Key != ConsoleKey.Escape);

    // Chama o método "Salvar" passando a variável "text" com o texto digitado.
    Salvar(text);
}

// Método "Salvar" recebe o texto digitado para salvar.
static void Salvar(string text)
{
    // Limpa a tela
    Console.Clear();
    // Solicita o caminho e nome do arquivo com extensão .txt
    Console.WriteLine(" Qual caminho para salvar o arquivo?");
    // A variável "path" recebe o caminho do arquivo para salvar o texto.
    var path = Console.ReadLine();

    // StreamWriter => Fluxo de escrita.
    // A variável aponta para o arquivo informado pelo argumento "path"
    using (var file = new StreamWriter(path))
    {
        // Escreve/Grava o conteúdo de "text" no arquivo apontado por "file"
        file.Write(text);
    }

    // Exibe mensagem informando que o arquivo foi salvo com sucesso.
    // Na mensagem, {path} é substituído por seu conteúdo que é o caminho e nome do arquivo com extensão .txt
    Console.WriteLine($"Arquivo {path} salvo com sucesso!");
    // Aguar o usuário pressionar <enter>
    Console.ReadLine();
    // Chama o método Menu()
    Menu();
}

```
