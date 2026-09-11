//Console.WriteLine("Bienvenido Facundo");

class public Persona(int, int){
  
  Persona Facundo = new Persona();
Facundo.Nombre = "Facundo";
Facundo.Apellido = "Steckler";

Facundo.Presentarse();

};
class Persona
{
    private string nombre = "";
    private string apellido = "";

    public string Nombre { get => nombre; set => nombre = value; }
    public string Apellido { get => apellido; set => apellido = value; }

    public void Presentarse()
    {
        Console.WriteLine(this.Apellido + " " + this.Nombre);
    }
    
}  





