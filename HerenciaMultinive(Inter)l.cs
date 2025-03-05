// See https://aka.ms/new-console-template for more information

using System;

interface ITelefono
{
    void Llamar();
}

interface ICamara
{
    void TomarFoto();
}

class Smartphone : ITelefono, ICamara
{
    public void Llamar()
    {
        Console.WriteLine("Llamando...");
    }

    public void TomarFoto()
    {
        Console.WriteLine("Foto tomada");
    }
}

class Program
{
    static void Main()
    {
        Smartphone miSmartphone = new Smartphone();
        miSmartphone.Llamar(); // Llamando...
        miSmartphone.TomarFoto(); // Foto tomada
    }
}