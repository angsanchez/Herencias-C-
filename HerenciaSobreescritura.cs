// See https://aka.ms/new-console-template for more information

using System;

class Ave
{
    public virtual void Volar()
    {
        Console.WriteLine("Esta ave puede volar");
    }
}

class Pinguino : Ave
{
    public override void Volar()
    {
        Console.WriteLine("Los pingüinos no pueden volar");
    }
}

class Program
{
    static void Main()
    {
        Pinguino miPinguino = new Pinguino();
        miPinguino.Volar(); // Los pingüinos no pueden volar
    }
}