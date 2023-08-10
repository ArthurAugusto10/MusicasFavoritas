using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScreenSound_Quatro.Modelos;

namespace ScreenSound_Quatro.Filtros;

internal class LINQARTISTSORDER
{
    public static void ExibirListaDeArtistasOrdenados(List<Musica> musicas)
    {
        var ArtistasOrdenados = musicas.OrderBy(musicas => musicas.Artista).Select(artistas => artistas.Artista).Distinct().ToList();
        Console.WriteLine("Lista de artistas ordenados: ");
        foreach(var compositores in ArtistasOrdenados)
        {
            Console.WriteLine($"-> {compositores}");
        }
    }
}
