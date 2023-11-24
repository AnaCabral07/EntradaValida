// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

Console.WriteLine("         Entrada Válida\n");

int numeroDigitado = -1;

while (numeroDigitado < 0 || numeroDigitado > 9)
{
    Console.Write("Digite um número entre 1 e 9 (ou 0 para sair): ");
    numeroDigitado = Convert.ToInt32(Console.ReadLine());
}

// Quebra de linha.
Console.WriteLine();

if (numeroDigitado == 0)
{
    Console.WriteLine("Operação cancelada.\n");
}

else {
    Console.WriteLine($"Número selecionado = {numeroDigitado}.");
}

Console.WriteLine("Volte sempre!\n");