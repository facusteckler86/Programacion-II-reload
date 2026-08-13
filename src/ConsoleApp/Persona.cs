Console.WriteLine("Bienvenido Facundo");

Persona Facundo = new Persona();
Facundo.nombre = "Facundo";
Facundo.apellido = "Steckler";

Facundo.Presentarse();

class Persona
{
    public string nombre = "";
    public string apellido = "";

    public void Presentarse()
    {
        Console.WriteLine(this.apellido + " " + this.nombre);
    }
    
}


