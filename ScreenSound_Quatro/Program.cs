using System;
using System.Collections.Generic;
using System.Text.Json;
using ScreenSound_Quatro.Modelos;
using ScreenSound_Quatro.Filtros;

using (HttpClient Cliente = new HttpClient())
{
    try
    {
        string Resposta = await Cliente.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var Musicas = JsonSerializer.Deserialize<List<Musica>>(Resposta)!;
        //LINQFILTER.FiltrarTodosOsGenerosMusicais(Musicas);
        //LINQARTISTSORDER.ExibirListaDeArtistasOrdenados(Musicas);
        //LINQFILTER.FiltrarArtistasPorGeneroMusical(Musicas,"rock");
        //LINQFILTER.FiltrarMusicasDeUmArtista(Musicas, "U2");
        var MusicasFavoritasDoArthur = new MusicasFavoritas("Arthur");
        MusicasFavoritasDoArthur.AdicionarMusicasFavoritas(Musicas[2]);
        MusicasFavoritasDoArthur.AdicionarMusicasFavoritas(Musicas[4]);
        MusicasFavoritasDoArthur.AdicionarMusicasFavoritas(Musicas[8]);
        MusicasFavoritasDoArthur.AdicionarMusicasFavoritas(Musicas[16]);
        MusicasFavoritasDoArthur.AdicionarMusicasFavoritas(Musicas[32]);
        MusicasFavoritasDoArthur.AdicionarMusicasFavoritas(Musicas[64]);
        MusicasFavoritasDoArthur.AdicionarMusicasFavoritas(Musicas[128]);

        //MusicasFavoritasDoArthur.ExibirMusicasFavoritas();
        //Musicas[2].ExibirDetalhesDaMusica();

        LINQFILTER.ExibirMusicasCOmATonalidadeDesejada(Musicas,"C#");
    }
    catch(Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
   
}