// See https://aka.ms/new-console-template for more information

using System;

class Vehiculo
{
    public string Marca { get; set; }

    public Vehiculo(string marca)
    {
        Marca = marca;
    }
}

class Coche : Vehiculo
{
    public string Modelo { get; set; }

    public Coche(string marca, string modelo) : base(marca)
    {
        Modelo = modelo;
    }
}

class CocheDeportivo : Coche
{
    public int VelocidadMax { get; set; }

    public CocheDeportivo(string marca, string modelo, int velocidadMax) : base(marca, modelo)
    {
        VelocidadMax = velocidadMax;
    }
}

class Program
{
    static void Main()
    {
        CocheDeportivo miCoche = new CocheDeportivo("Ferrari", "488 GTB", 330);
        Console.WriteLine(miCoche.Marca); // Ferrari
        Console.WriteLine(miCoche.VelocidadMax); // 330
    }
}