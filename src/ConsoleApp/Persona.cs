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





