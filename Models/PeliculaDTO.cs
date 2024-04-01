namespace apidotnet.Models;

public class PeliculaDTO
{
    public int? PeliculaId { get; set;}

    public required string Titulo { get; set;}

    public string Sinopsis { get; set;} = "Sins sinopsis";

    public int Anio { get; set;}

    public string Poster { get; set;} = "N/A";

    public int[]? Categotias { get; set;}
} 