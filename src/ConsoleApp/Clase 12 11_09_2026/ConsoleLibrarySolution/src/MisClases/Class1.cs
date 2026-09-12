using System;

namespace MisClases;

public class Profe
{
    //los atributos por convencion siempre van en private
    private string lastname;
    private string name;

// se acceden siempre con Setters y Getters
    public string GetName()
    {
        return name;
    }

    public string GetLastName()
    {
        return lastname;
    }

    public void SetLastName(string lastname)
    {
        this.lastname = lastname;
    }

    public void SayHi()
    {
        Console.WriteLine($"Hola, mi nombre es {GetFullName()}");
    }

    private string GetFullName()
    {
        return $"{GetName()} {GetLastName()}";
    }

    public static void Main()
    {
        Profe myVariable = new Profe();
        myVariable.SayHi();
    }
}
