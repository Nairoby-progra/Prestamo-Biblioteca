namespace PrestamosBiblioteca.Dominio;

/// <summary>
/// Clase base de cualquier persona relacionada con la biblioteca. Declara
/// los datos comunes y un metodo polimorfico (<see cref="ObtenerInformacion"/>)
/// que cada subclase implementa a su manera.
/// </summary>
public abstract class Persona
{
    /// <summary>Nombre completo.</summary>
    public string Nombre { get; }

    /// <summary>Correo electronico.</summary>
    public string Correo { get; }

    /// <summary>Numero de telefono.</summary>
    public string Telefono { get; }

    protected Persona(string nombre, string correo, string telefono)
    {
        Nombre = string.IsNullOrWhiteSpace(nombre)
            ? throw new ArgumentException("El nombre es obligatorio.")
            : nombre.Trim();
        Correo = string.IsNullOrWhiteSpace(correo)
            ? throw new ArgumentException("El correo es obligatorio.")
            : correo.Trim();
        Telefono = string.IsNullOrWhiteSpace(telefono)
            ? throw new ArgumentException("El telefono es obligatorio.")
            : telefono.Trim();
    }

    /// <summary>
    /// Metodo polimorfico: cada subclase de Persona decide como describirse
    /// en una sola linea de texto.
    /// </summary>
    public abstract string ObtenerInformacion();
}
