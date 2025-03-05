// See https://aka.ms/new-console-template for more information

using System;

class Animal
{
    public string Nombre { get; set; }

    public Animal(string nombre)
    {
        Nombre = nombre;
    }

    public virtual void HacerSonido()
    {
        Console.WriteLine("Sonido genérico de animal");
    }
}

class Perro : Animal
{
    public Perro(string nombre) : base(nombre) { }

    public override void HacerSonido()
    {
        Console.WriteLine("Guau!");
    }
}

class Program
{
    static void Main()
    {
        Perro miPerro = new Perro("Rex");
        Console.WriteLine(miPerro.Nombre); // Rex
        miPerro.HacerSonido(); // Guau!
    }
}