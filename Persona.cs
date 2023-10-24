class Persona
{
    public string nombre { get; }
    public string apellido { get; set; }
    public int edad { get; set; }

    // Constructor

    public Persona(string nombre, string apellido, int edad)
    {
        this.nombre = nombre;
        this.apellido = apellido;
        this.edad = edad;
    }

}