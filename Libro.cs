namespace PrestamosBiblioteca.Dominio;

/// <summary>
/// Libro del catalogo de la biblioteca, con la cantidad total de ejemplares
/// que posee (no solo los disponibles en este momento).
/// </summary>
public sealed class Libro
{
    /// <summary>Codigo del libro en el catalogo.</summary>
    public string Codigo { get; }

    /// <summary>Titulo del libro.</summary>
    public string Titulo { get; }

    /// <summary>Autor del libro.</summary>
    public string Autor { get; }

    /// <summary>Cantidad total de ejemplares que tiene la biblioteca.</summary>
    public int Ejemplares { get; }

    public Libro(string codigo, string titulo, string autor, int ejemplares)
    {
        Codigo = string.IsNullOrWhiteSpace(codigo)
            ? throw new ArgumentException("El codigo del libro es obligatorio.")
            : codigo.Trim();
        Titulo = string.IsNullOrWhiteSpace(titulo)
            ? throw new ArgumentException("El titulo es obligatorio.")
            : titulo.Trim();
        Autor = string.IsNullOrWhiteSpace(autor)
            ? throw new ArgumentException("El autor es obligatorio.")
            : autor.Trim();
        Ejemplares = ejemplares > 0
            ? ejemplares
            : throw new ArgumentException("La cantidad de ejemplares debe ser mayor que 0.");
    }
}
