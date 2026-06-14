namespace RockVault.Models;

public class Banda
{
    public int Id { get; set; }
    public string Nombre { get; set; } = string.Empty;
    public string Genero { get; set; } = string.Empty;
    public string Pais { get; set; } = string.Empty;
    public string AlbumDestacado { get; set; } = string.Empty;
    public int Anio { get; set; }
    public string Descripcion { get; set; } = string.Empty;

    /// <summary>
    /// Color de acento para la tarjeta: pink, green, cyan o yellow.
    /// </summary>
    public string Acento { get; set; } = "pink";
}
