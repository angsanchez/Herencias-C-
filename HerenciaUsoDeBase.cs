// See https://aka.ms/new-console-template for more information

using System;

class Persona
{
    public string Nombre { get; set; }
    public int Edad { get; set; }

    public Persona(string nombre, int edad)
    {
        Nombre = nombre;
        Edad = edad;
    }
}

class Estudiante : Persona
{
    public string Grado { get; set; }

    public Estudiante(string nombre, int edad, string grado) : base(nombre, edad)
    {
        Grado = grado;
    }
}

class Program
{
    static void Main()
    {
        Estudiante miEstudiante = new Estudiante("Ana", 20, "Universidad");
        Console.WriteLine(miEstudiante.Nombre); // Ana
        Console.WriteLine(miEstudiante.Grado); // Universidad
    }
}