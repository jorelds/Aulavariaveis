
Console.WriteLine("Digite seu nome: ");
string nome = Console.ReadLine();

string frase1 = $"Olá {nome}, hoje é {DateTime.Now}";
Console.WriteLine(frase1);

Console.WriteLine("===========================");

Console.WriteLine("Quanto custa um dólar em reais?");
decimal ValorDolarReais = decimal.Parse(Console.ReadLine());
string frase2 = string.Format("Hoje é {0:dd/MM/yyyy}, o dólar está custando {1:c2}", DateTime.Now, ValorDolarReais);
Console.WriteLine(frase2);

Console.WriteLine("===========================");

string cabecalho = string.Format("{0:dddd}, {0:dd} de {0:MMMM} de {0:yy} - {0:HH:mm:ss}", DateTime.Now);
Console.WriteLine(cabecalho);
