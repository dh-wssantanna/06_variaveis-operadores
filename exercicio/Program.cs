
const int ANO_ATUAL = 2022;

// 1. Declaração de variáveis.
int idadeDoUsuario;
string nomeDoUsuario;

int dataDeNascimentoDoUsuario;

// 2. Capturar o nome do usuário.
Console.WriteLine("Qual seu nome?");
nomeDoUsuario = Console.ReadLine();

// 3. Capturar a idade do usuário.
Console.WriteLine("Qual sua idade?");
// idadeDoUsuario = int.Parse(Console.ReadLine());
// idadeDoUsuario = Convert.ToInt16(Console.ReadLine());
int.TryParse(Console.ReadLine(), out idadeDoUsuario); // Matheus, Carla, José Iranildo.

// Calcular a data de nascimento do usuário.
dataDeNascimentoDoUsuario = ANO_ATUAL - idadeDoUsuario;


// Utilize a mensagem a seguir como base do retorno esperado:
// Olá João, você nasceu em XXXX.
Console.WriteLine($"Olá {nomeDoUsuario}, você nasceu em {dataDeNascimentoDoUsuario}.");
