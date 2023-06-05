try
{
    Console.Write("Informe um valor: ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.Write("Informe outro valor: ");
    int b = Convert.ToInt32(Console.ReadLine());
    int conta = a / b;
    Console.WriteLine($"Resultado é = {conta}");
}
catch (FormatException ex)
{
    Console.WriteLine($"Nao e permitida string para int não e permitida {ex.Message}");
}
catch (Exception ex)
{
    Console.WriteLine($"Indique um valor valido!!" + ex.Message);
}

Console.ReadKey();