using System.Linq;
using ScreenSound_Quatro.Modelos;

namespace ScreenSound_Quatro.Filtros
{
    internal class LINQFILTER
    {
        public static void FiltrarTodosOsGenerosMusicais(List<Musica> musicas)
        {
            var TodosOsGenerosMusicais = musicas.Select(generos => generos.Genero).Distinct().ToList();
            foreach (var GenerosMusicais in TodosOsGenerosMusicais)
            {
                Console.WriteLine($"-> {GenerosMusicais}");
            }
        }

        public static void FiltrarArtistasPorGeneroMusical(List<Musica> musicas, string genero)
        {
            var ArtistasPorGeneroMusical = musicas.Where(musica => musica.Genero!.Contains(genero)).
                Select(musica => musica.Artista).Distinct().ToList();
            Console.WriteLine("Exibindo os artistas por genero musical: ");
            foreach(var artista in ArtistasPorGeneroMusical)
            {
                Console.WriteLine($"-> {artista}");
            }
        }

        public static void FiltrarMusicasDeUmArtista(List<Musica> musicas, string nomeDoArtista )
        {
            var MusicasDoArtista = musicas.Where(musica => musica.Artista!.Equals(nomeDoArtista)).ToList();
            Console.WriteLine($"Artista: {nomeDoArtista}");
            foreach(var musicasFiltradasDoArtista in MusicasDoArtista)
            {
                Console.WriteLine($"-> {musicasFiltradasDoArtista.Nome}");
            }
        }

        public static void ExibirMusicasCOmATonalidadeDesejada(List<Musica> musicas, string key)
        {
            var MusicaComTonalidade = musicas.Where(musica => musica.Tonalidade!.Equals(key)).Select(musica => musica.Nome)
            .ToList();
            Console.WriteLine($"Tonalidade {key}");
            var QuantidadeDeMusicasComATonalidadeDesejada = 0;
            foreach (var MusicasTonais in MusicaComTonalidade)
            {
                Console.WriteLine($"-> {MusicasTonais}");
                QuantidadeDeMusicasComATonalidadeDesejada += 1;
            }
            Console.WriteLine($"Ao final foram encontradas {QuantidadeDeMusicasComATonalidadeDesejada} músicas com a tonalidade {key}.");
        }
    }
}
