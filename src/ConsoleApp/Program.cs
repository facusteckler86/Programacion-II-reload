Persona facundo = new Persona
{
    Nombre = "Facundo",
    Apellido = "Steckler"
};

facundo.Presentarse();

Vehiculo vehiculo1 = new Vehiculo
{
    marca = "Audi",
    modelo = "A3"
};

Console.WriteLine($"Vehiculo: {vehiculo1.marca} {vehiculo1.modelo}");