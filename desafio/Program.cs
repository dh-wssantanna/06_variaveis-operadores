
// Declarei as variáveis.
const double UM_QUILOMETRO_EM_MILHAS = 0.6;

double quilometrosPercorridosPeloVeiculo;

// Capturei os quilometros rodados do veículo.
quilometrosPercorridosPeloVeiculo = Convert.ToDouble(Console.Read());

// Calculei a conversão de quilometros para milhas.
double milhasPercorridosPeloVeiculo = quilometrosPercorridosPeloVeiculo * UM_QUILOMETRO_EM_MILHAS;

// Utilize a mensagem a seguir como base do retorno esperado:
// Seu veículo percorreu um total de XXXXXX milhas.
Console.WriteLine($"Seu veículo percorreu um total de {milhasPercorridosPeloVeiculo} milhas.");