namespace MisClases;

public class Profe
{
    private string name;
    private string lastname;

    public Profe()
    {
        this.name ="Facundo";
        this.lastname = "Steckler";
    }
    public string GetName()
    {
        return name;
    }
    public void SetName(string name)
    {
        this.name = name;
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
        return$"{GetName()} {GetLastName()}";
    }
}
