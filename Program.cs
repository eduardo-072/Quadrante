double x, y;

Console.WriteLine("-----QUADRANTE-----");
Console.WriteLine("Digite um numero.....:");

Console.WriteLine("Ponto x:");
x = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Ponto y:");
y = Convert.ToDouble(Console.ReadLine());
 
if (x > 0 && y > 0)
{
    Console.WriteLine($" O ponto ({x}, {y}) esta no quadrante I.");
}
 
    else if (x < 0 && y > 0)
    {
        Console.WriteLine($" O ponto ({x}, {y}) esta no quadrante II.");
    }
 
    else if (x < 0 && y < 0)
    {
        Console.WriteLine($" O ponto ({x}, {y}) esta no quadrante III.");
    }
     
     else if (x > 0 && y < 0) 
    {
        Console.WriteLine($" O ponto ({x}, {y}) esta no quadrante IV.");
    }

    else if (x == 0 && y < 0 || x == 0 && y > 0 )
    {
        Console.WriteLine($" O ponto ({x}, {y}) esta sob o eixo y");
    }
    
    else if (y == 0 && x < 0 || y == 0 && x > 0 )
    {
        Console.WriteLine($" O ponto ({x}, {y}) esta sob o eixo x");
    }
else
{
    Console.Write("O ponto (0, 0) esta na origem.");
}
    