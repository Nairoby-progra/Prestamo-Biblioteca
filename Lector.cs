namespace PrestamosBiblioteca.Dominio;

/// <summary>
/// Lector registrado en la biblioteca. Es una <see cref="Persona"/> que,
/// ademas de nombre, correo y telefono, tiene un codigo de carnet propio.
/// </summary>
public sealed class Lector : Persona
{
    /// <summary>Codigo de carnet del lector.</summary>
    public string Codigo { get; }

    public Lector(string codigo, string nombre, string correo, string telefono)
        : base(nombre, correo, telefono)
    {
        Codigo = string.IsNullOrWhiteSpace(codigo)
            ? throw new ArgumentException("El codigo del lector es obligatorio.")
            : codigo.Trim();
    }

    /// <summary>Descripcion del lector, usada para demostrar polimorfismo.</summary>
    public override string ObtenerInformacion() =>
        $"Lector [{Codigo}] {Nombre} - {Correo} - {Telefono}";
}
