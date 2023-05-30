try
{
    Console.WriteLine("informe dois numeros: ");
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());
    double conta = a / b;
    Console.WriteLine(conta);
    

}
catch
{
    Console.WriteLine("Algo de errado não esta certo!\nDigite APENAS números\n");
}

Console.ReadKey();
