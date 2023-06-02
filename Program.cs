

var fileForTesting = File.ReadAllLines(Directory.GetCurrentDirectory()+ "\\atelie-catalogo-produtos.csv");

int maxValue = fileForTesting.Count();

for (int i = 0; i <= maxValue; i++)
{
    ProgressBar(i, maxValue);
    Thread.Sleep(100);
}


 void ProgressBar(int count, int totalLines, int percentageIncrement = 2, ConsoleColor colorBar = ConsoleColor.Green, char caractere = '■')
{
    string animation = @"|/-\";

    var porcentagem = Math.Floor((double)count / totalLines * 100);

    string linha = new string(caractere, (int)Math.Floor(porcentagem / percentageIncrement));


    Console.SetCursorPosition(0, Console.CursorTop);

    Console.Write($"Contador: {count} de {totalLines}  {porcentagem} % {animation[count % animation.Length]} ");
    Console.Write("[");

    Console.ForegroundColor = colorBar;
    Console.Write(linha.PadRight((100 / percentageIncrement), ' '));
    Console.ResetColor();

    Console.Write("]");
}
