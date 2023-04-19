// Criar uma aplicação para uma agência de turismo, no qual deveremos registrar passagens aéreas com os seguintes dados: Nome do passageiro, Origem, Destino e Data do Voo de 5 passageiros.

// Antes de entrar no sistema faça um esquema do qual o usuário só possa acessar o menu se a senha for igual à 123456.
// O sistema deve exibir um menu com as seguintes opções:

// 1 - Cadastrar passagem
// 2 - Listar Passagens
// 0 - Sair


// Ao cadastrar uma passagem ao final o sistema deverá perguntar se gostaria de cadastrar uma nova passagem caso contrário voltar ao menu anterior(S/N).
Console.BackgroundColor = ConsoleColor.Green;
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine(@$"|====-------------------------====|");
Console.WriteLine(@$"|====BEM VINDO AO PASSAGEM.COM====|");
Console.WriteLine(@$"|====-------------------------====|");
Console.ResetColor();

Console.WriteLine(@$"
Informe a senha para acessar o menu do PASSAGEM.COM: ");
string senha = Console.ReadLine();

while (senha != "123")
{
    Console.WriteLine($"Informe uma senha válida: ");
    senha = Console.ReadLine();
}

Console.WriteLine(@$"
*|==============================|*
*|ACESSANDO O MENU PASSAGEM.COM!|*
*|==============================|*
");


    Console.WriteLine(@$"    1 - Cadastrar passagem

    2 - Listar passagem

    0 - Sair");
char opcao = char.Parse(Console.ReadLine());

while (opcao != '1' && opcao != '2' && opcao != '0')
{
    Console.WriteLine(@$"Selecione uma opcao válida!
 1 - Cadastrar passagem
 2 - Listar passagem
 0 - Sair");
    opcao = char.Parse(Console.ReadLine());
}



string[] nome = new string[5];

string[] origem = new string[5];

string[] destino = new string[5];

string[] data = new string[5];


if (opcao == '1')
{

    for (int i = 0; i <= 4; i++)
    {


        Console.WriteLine($" {i + 1}º Informe o nome do passageiro: ");
        nome[i] = Console.ReadLine();

        Console.WriteLine($"Origem do voo do {i + 1}º passageiro: ");
        origem[i] = Console.ReadLine();

        Console.WriteLine($"Destino do voo do {i + 1}º passageiro: ");
        destino[i] = Console.ReadLine();

        Console.WriteLine($"Informe a data do voo do {i + 1}º passageiro (dd/mm/aaaa): ");
        data[i] = Console.ReadLine();

    }

}


Console.WriteLine($"Obrigado por suas passagens cadastrar em nosso sistema!");

Console.WriteLine(@$"MENU PASSAGEM.COM
      2 - Listar passagens 
      0 - Sair");

opcao = char.Parse(Console.ReadLine());

if (opcao == '2')
{
    for (int i = 0; i <= 4; i++)
    {
        Console.WriteLine($"Nome {i + 1}º passageiro: {nome[i]}");

        Console.WriteLine($"Origem voo do {i + 1}º passageiro: {origem[i]}");

        Console.WriteLine($"Destino voo do {i + 1}º passageiro: {destino[i]}");

        Console.WriteLine($"Data voo {i + 1}º passageiro: {data[i]} ");
    }

    Console.WriteLine(@$"Obrigado por utilizar nosso sistema");
}

if (opcao == '0')
{
    Console.WriteLine($"Obrigado por utilizar nosso sistema! ");
}
