using NumerosRacionales.Model;

Console.WriteLine("Demostración de operaciones con números racionales.\n");

Racional r1 = new Racional(3, 5);
Racional r2 = new Racional(4, 3);

Console.WriteLine($"{r1.ComoTexto()} es  fracción equivalente a {r1.Fraccion():F6}");
Console.WriteLine($"{r2.ComoTexto()} es  fracción equivalente a {r2.Fraccion():F6}");
ImprimeSiEsFraccionPropia(r1);
ImprimeSiEsFraccionPropia(r2);

Racional r3 = r1.Sumar(r2);
Console.WriteLine($"{r1.ComoTexto()} + {r2.ComoTexto()} = {r3.ComoTexto()}");

Console.WriteLine($"{r3.ComoTexto()} - {r1.ComoTexto()} = {r3.Restar(r1).ComoTexto()}");

Console.WriteLine($"{r1.ComoTexto()} * {r2.ComoTexto()} = {r1.Multiplicar(r2).ComoTexto()}");

Console.WriteLine($"{r1.ComoTexto()} / {r2.ComoTexto()} = {r1.Dividir(r2).ComoTexto()}");

void ImprimeSiEsFraccionPropia(Racional r)
{
    if (r.EsFraccionPropia())
    {
       Console.WriteLine($"{r.ComoTexto()} si es  fracción propia");
    }
    else
    {
        Console.WriteLine($"{r.ComoTexto()} no es  fracción propia");
    }
}
