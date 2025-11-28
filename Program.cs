using System.Globalization;

const int MaxRegistros = 200;
// Arrays internos para guardar os dados do usuario.
string[] tipos = new string[MaxRegistros];
DateTime[] datas = new DateTime[MaxRegistros];
double[] valores = new double[MaxRegistros];
int quantidade = 0;

CultureInfo cultura = new CultureInfo("pt-BR");

while (true)
{
    // Menu principal que orquestra as ações do usuario.
    MostrarMenu();
    string? opcao = Console.ReadLine();
    Console.WriteLine();

    switch (opcao)
    {
        case "1":
            // Entrada de um novo registro de saude.
            AdicionarRegistro();
            break;
        case "2":
            // Visualizacao dos registros acumulados.
            ListarRegistros();
            break;
        case "3":
            // Resumo rapido com total e media por atividade.
            ExibirEstatisticas();
            break;
        case "4":
            Console.WriteLine("Encerrando. Ate breve!");
            return;
        default:
            Console.WriteLine("Opcao invalida. Tente novamente.");
            break;
    }
}

void MostrarMenu()
{
    Console.WriteLine("=== Monitor de Saude Digital ===");
    Console.WriteLine("1 - Adicionar registro");
    Console.WriteLine("2 - Listar registros");
    Console.WriteLine("3 - Exibir estatisticas");
    Console.WriteLine("4 - Sair");
    Console.Write("Escolha uma opcao: ");
}

void AdicionarRegistro()
{
    if (quantidade >= MaxRegistros)
    {
        Console.WriteLine("Limite de registros atingido.");
        return;
    }

    string tipo = LerTexto("Tipo da atividade (Exercicio, Agua, Sono...): ");
    DateTime data = LerData("Data da atividade (dd/MM/yyyy): ");
    double valor = LerNumero("Valor (minutos, litros ou horas): ");

    tipos[quantidade] = tipo;
    datas[quantidade] = data;
    valores[quantidade] = valor;
    quantidade++;

    Console.WriteLine("Registro adicionado com sucesso!");
}

void ListarRegistros()
{
    if (quantidade == 0)
    {
        Console.WriteLine("Nenhum registro cadastrado.");
        return;
    }

    Console.WriteLine("Registros cadastrados:");
    for (int i = 0; i < quantidade; i++)
    {
        Console.WriteLine($"{i + 1:00} - {datas[i]:dd/MM/yyyy} - {tipos[i]}: {valores[i]:0.##}");
    }
}

void ExibirEstatisticas()
{
    if (quantidade == 0)
    {
        Console.WriteLine("Nenhum registro para calcular estatisticas.");
        return;
    }

    string[] tiposUnicos = new string[quantidade];
    double[] somaPorTipo = new double[quantidade];
    int[] totalPorTipo = new int[quantidade];
    int usados = 0;

    for (int i = 0; i < quantidade; i++)
    {
        int indice = EncontrarTipo(tiposUnicos, usados, tipos[i]);
        if (indice == -1)
        {
            indice = usados;
            tiposUnicos[usados] = tipos[i];
            usados++;
        }

        somaPorTipo[indice] += valores[i];
        totalPorTipo[indice]++;
    }

    Console.WriteLine("Estatisticas por atividade:");
    for (int i = 0; i < usados; i++)
    {
        double media = somaPorTipo[i] / totalPorTipo[i];
        Console.WriteLine($"{tiposUnicos[i]} -> Total: {somaPorTipo[i]:0.##} | Media: {media:0.##} | Registros: {totalPorTipo[i]}");
    }
}

int EncontrarTipo(string[] tiposRegistrados, int limite, string tipoProcurado)
{
    for (int i = 0; i < limite; i++)
    {
        if (string.Equals(tiposRegistrados[i], tipoProcurado, StringComparison.OrdinalIgnoreCase))
        {
            return i;
        }
    }
    return -1;
}

string LerTexto(string mensagem)
{
    while (true)
    {
        Console.Write(mensagem);
        string? texto = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(texto))
        {
            return texto.Trim();
        }
        Console.WriteLine("Digite um texto valido.");
    }
}

DateTime LerData(string mensagem)
{
    while (true)
    {
        Console.Write(mensagem);
        string? entrada = Console.ReadLine();
        if (DateTime.TryParseExact(entrada, "dd/MM/yyyy", cultura, DateTimeStyles.None, out DateTime data))
        {
            return data;
        }
        Console.WriteLine("Data invalida. Use o formato dd/MM/yyyy.");
    }
}

double LerNumero(string mensagem)
{
    while (true)
    {
        Console.Write(mensagem);
        string? entrada = Console.ReadLine();
        if (double.TryParse(entrada, NumberStyles.Number, cultura, out double valor) && valor >= 0)
        {
            return valor;
        }
        Console.WriteLine("Valor invalido. Informe um numero nao negativo.");
    }
}
