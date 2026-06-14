namespace RockVault.Models;

public static class CatalogoData
{
    public static List<Banda> ObtenerBandas()
    {
        return new List<Banda>
        {
            new Banda
            {
                Id = 1,
                Nombre = "Queen",
                Genero = "Rock / Glam Rock",
                Pais = "Reino Unido",
                AlbumDestacado = "A Night at the Opera",
                Anio = 1975,
                Descripcion = "Conocidos por mezclar el rock con elementos teatrales y operísticos, " +
                               "y por la potente presencia vocal de su frontman. Sus directos se " +
                               "convirtieron en referencia obligada para bandas posteriores.",
                Acento = "pink"
            },
            new Banda
            {
                Id = 2,
                Nombre = "Led Zeppelin",
                Genero = "Hard Rock",
                Pais = "Reino Unido",
                AlbumDestacado = "Led Zeppelin IV",
                Anio = 1971,
                Descripcion = "Pioneros en mezclar el blues con riffs pesados y arreglos épicos, " +
                               "su sonido sentó las bases de lo que más adelante se conocería " +
                               "como hard rock y heavy metal.",
                Acento = "green"
            },
            new Banda
            {
                Id = 3,
                Nombre = "AC/DC",
                Genero = "Hard Rock",
                Pais = "Australia",
                AlbumDestacado = "Back in Black",
                Anio = 1980,
                Descripcion = "Famosos por sus riffs de guitarra crudos y directos, y por shows " +
                               "en vivo cargados de energía. Su estilo se mantuvo prácticamente " +
                               "inalterado durante décadas, convirtiéndose en sinónimo de rock " +
                               "sin adornos.",
                Acento = "cyan"
            },
            new Banda
            {
                Id = 4,
                Nombre = "Metallica",
                Genero = "Thrash Metal",
                Pais = "Estados Unidos",
                AlbumDestacado = "Master of Puppets",
                Anio = 1986,
                Descripcion = "Una de las bandas que definió el thrash metal con riffs agresivos, " +
                               "cambios de tempo y letras oscuras, llevando el género a audiencias " +
                               "masivas alrededor del mundo.",
                Acento = "yellow"
            },
            new Banda
            {
                Id = 5,
                Nombre = "Guns N' Roses",
                Genero = "Hard Rock",
                Pais = "Estados Unidos",
                AlbumDestacado = "Appetite for Destruction",
                Anio = 1987,
                Descripcion = "Devolvieron el hard rock crudo a la escena mainstream a finales de " +
                               "los 80, combinando actitud punk con solos de guitarra virtuosos " +
                               "y un carisma escénico inconfundible.",
                Acento = "pink"
            },
            new Banda
            {
                Id = 6,
                Nombre = "Nirvana",
                Genero = "Grunge",
                Pais = "Estados Unidos",
                AlbumDestacado = "Nevermind",
                Anio = 1991,
                Descripcion = "Llevaron el grunge y el rock alternativo de Seattle a una audiencia " +
                               "global, marcando un cambio generacional en el sonido del rock de " +
                               "los años 90.",
                Acento = "green"
            },
            new Banda
            {
                Id = 7,
                Nombre = "Pink Floyd",
                Genero = "Rock Progresivo",
                Pais = "Reino Unido",
                AlbumDestacado = "The Dark Side of the Moon",
                Anio = 1973,
                Descripcion = "Reconocidos por sus álbumes conceptuales, letras introspectivas y " +
                               "espectáculos en vivo elaborados con efectos visuales y sonoros " +
                               "que redefinieron la experiencia de un concierto de rock.",
                Acento = "cyan"
            },
            new Banda
            {
                Id = 8,
                Nombre = "Iron Maiden",
                Genero = "Heavy Metal",
                Pais = "Reino Unido",
                AlbumDestacado = "The Number of the Beast",
                Anio = 1982,
                Descripcion = "Íconos del heavy metal británico, conocidos por sus líneas de bajo " +
                               "galopantes, armonías de guitarra a dos voces y una identidad " +
                               "visual muy reconocible en sus portadas y presentaciones.",
                Acento = "yellow"
            }
        };
    }

    public static Banda? ObtenerPorId(int id)
    {
        return ObtenerBandas().FirstOrDefault(b => b.Id == id);
    }
}
