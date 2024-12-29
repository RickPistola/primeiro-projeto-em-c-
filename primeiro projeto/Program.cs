// Screen Sound
string mensagemDeBoasVindas ="Sejam bem-Vindos";
List<string> ListaDasBandas = new List<string>();

void ExibirLogo()
{
    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
    Console.WriteLine(mensagemDeBoasVindas);
}

void ExibirOpcoesDoMenu()
{
    ExibirLogo();   
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite 0 para sair");

    Console.Write("\n\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica)
    {
        case 1: registrarBanda();
            break;
        case 2: MostrarBandas();
            break;
        case 3: Console.WriteLine("você escolheu a opção " + opcaoEscolhidaNumerica);
            break;
        case 4: Console.WriteLine("você escolheu a opção " + opcaoEscolhidaNumerica);   
            break;
        case 0: Console.WriteLine("até mais :)");
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }
    
}

void registrarBanda()
{
    Console.Clear();
    ExibirTituloDasOpcoes("Registrar Banda");
    Console.Write("Digite o nome da banda: ");
    string nomeDaBanda = Console.ReadLine()!;
    ListaDasBandas.Add(nomeDaBanda);
    Console.WriteLine($"Banda {nomeDaBanda} registrada com sucesso!");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void MostrarBandas()
{ 
    Console.Clear();
    ExibirTituloDasOpcoes("Exibir bandas registradas");
    //for (int i = 0; i < ListaDasBandas.Count; i++)
    //{
    //    Console.WriteLine($"Banda {i + 1}: {ListaDasBandas[i]}");
    //}

    foreach (string banda in ListaDasBandas)
    {
        Console.WriteLine($"Banda: {banda}");
    }

    Console.WriteLine("\nPressione qualquer tecla para voltar ao menu");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void ExibirTituloDasOpcoes(string titulo)
{
    int quatidadeDeLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quatidadeDeLetras, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");
}

ExibirOpcoesDoMenu();