void MenuInicial()
{
    Console.WriteLine("******************************");
    Console.WriteLine("Exercicíos e Desafios da Alura");
    Console.WriteLine("******************************");
    Console.WriteLine("\n1- Variavel Curso e mostrar seu conteudo");
    Console.WriteLine("2- Mostrar o nome dos instrutores do curso");
    Console.WriteLine("3- Nota Média");
    Console.WriteLine("4- Lista de Linguagens de Programação");
    Console.WriteLine("5- Primeiro jogo com C#");
    Console.WriteLine("6- Operações Basicas");
    Console.WriteLine("7- Adicionar banda");
    Console.WriteLine("8- Mostrar bandas");
    Console.WriteLine("9- Soma elementos da lista");
    Console.WriteLine("10- Lista de números pares");
    Console.WriteLine("11- Notas do aluno: dicionário");
    Console.WriteLine("12- Estoque de loja");
    Console.WriteLine("13- Quiz");
    Console.WriteLine("14- Login");
    Console.WriteLine("14- venda de carros");
    Console.WriteLine("0- Sair");

    Console.WriteLine("\nDigite sua opção");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcao = int.Parse(opcaoEscolhida);

    switch (opcao)
    {
        case 1: VariavelCurso();
            break;
        case 2: NomeDosInstrutores();
            break;
        case 3: NotaMedia();
            break;
        case 4: ListaDeLinguagens();
            break;
        case 5: PrimeiroJogo();
            break;
        case 6:OperacoesBasicas();
            break;
        case 7:AdicionarBanda();
            break;
        case 8:Console.WriteLine("Você escolheu a opção " + opcao);
            break;
        case 9:Console.WriteLine("Você escolheu a opção " + opcao);
            break;
        case 10:Console.WriteLine("Você escolheu a opção " + opcao);
            break;
        case 11:Console.WriteLine("Você escolheu a opção " + opcao);
            break;
        case 12:Console.WriteLine("Você escolheu a opção " + opcao);
            break;
        case 13:Console.WriteLine("Você escolheu a opção " + opcao);
            break;
        case 14:Console.WriteLine("Você escolheu a opção " + opcao);
            break;
        case 0:Console.WriteLine("Até a próxima");
            Thread.Sleep(2000);
            break;
    }
}

void VariavelCurso()
{
    Console.Clear();
    string curso = "C#: criando sua primeira aplicação";
    Console.WriteLine(curso);
    Thread.Sleep(3000);
    Console.Clear();
    MenuInicial();
}

void NomeDosInstrutores()
{
    Console.Clear();
    Console.WriteLine("Instrutores Daniel Portugal e Gui Lima");
    Thread.Sleep(3000);
    Console.Clear();
    MenuInicial();
}

void NotaMedia()
{
    Console.Clear();
    string nota = Console.ReadLine()!;
    Console.WriteLine("Digite a sua nota: ");
    int notaMedia = int.Parse(nota);
    if (notaMedia >= 5)
    {
        Console.WriteLine("Nota suficiente para aprovação");
    }
    else{
        Console.WriteLine("Nota insuficiente para aprovação");
    }
    Thread.Sleep(3000);
    Console.Clear();
    MenuInicial();
}

void ListaDeLinguagens()
{
    Console.Clear();
    List<string> linguagens = new List<string> { "C#", "Java", "JavaScript" };
    Console.WriteLine(linguagens[0]);
    Thread.Sleep(3000);
    Console.Clear();
    MenuInicial();
}

void PrimeiroJogo()
{
    Console.Clear();
    Random aleatorio = new Random();
    int numeroSecreto = aleatorio.Next(1, 101);
    do
    {
        Console.WriteLine("Digite um número de 1 a 100");
        int chute = int.Parse(Console.ReadLine()!);

        if (chute == numeroSecreto)
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Parabéns! Você acertou o número!");
            Thread.Sleep(3000);
            break;
        }else if (chute < numeroSecreto)
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("O número é maior");
        } else
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("O número é menor");
        }
    }while (true);
    Console.Clear();
    MenuInicial();
}

void OperacoesBasicas()
{
    Console.Clear();
    Console.WriteLine("O primeiro valor é 4");
    Console.WriteLine("O segundo valor é 8");

    float soma = 4 + 8;
    float subtração = 4 - 8;
    float multiplicacao = 4 * 8;
    float divisao = 4 / 8;

    Console.WriteLine($"Soma: {soma}");
    Console.WriteLine($"Subtração: {subtração}");
    Console.WriteLine($"Multiplicação: {multiplicacao}");
    Console.WriteLine($"Divisão: {divisao}");
    Console.Clear();
    Thread.Sleep(5000);
    MenuInicial();
}

void AdicionarBanda()
{
    Console.Clear();
    List<string> bandas = new List<string>();
    Console.WriteLine("Digite sua banda favorita: ");
    string banda1 = Console.ReadLine()!;
    bandas.Add(banda1);
    Thread.Sleep(1500);
    Console.WriteLine("Digite outra banda que você gosta: ");
    string banda2 = Console.ReadLine()!;
    bandas.Add(banda2);
    Console.WriteLine($"As bandas {bandas[0]} e {bandas[1]} foram adicionadas a lista!");
    Thread.Sleep(2000);
    Console.Clear();
    MenuInicial();

}

MenuInicial();