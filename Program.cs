{
    Console.Write("Informe um valor: ");
    double valor = double.Parse(Console.ReadLine());
    
    while(valor < 100)
    {
        Console.WriteLine("O valor informado está incorreto! ");
        Console.Write("Informe um valor novamente: ");
        valor = double.Parse(Console.ReadLine());
    }

    Console.WriteLine("Sucesso!");
}