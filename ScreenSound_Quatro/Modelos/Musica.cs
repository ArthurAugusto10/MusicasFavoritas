using System.Text.Json.Serialization;

namespace ScreenSound_Quatro.Modelos;

internal class Musica
{
    public string[] Tonalidades = {"C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "H", "AB", "A", "B"}; 

    [JsonPropertyName("song")]
    public string? Nome { get; set; }

    [JsonPropertyName("artist")]
    public string? Artista { get; set; }

    [JsonPropertyName("duration_ns")]
    public int? Duracao { get; set; }

    [JsonPropertyName("genre")]
    public string? Genero { get; set; }

    [JsonPropertyName("key")]
    public int Chave { get; set; }

    public string Tonalidade
    { get 
         {
            return Tonalidades[Chave];
         }
    }
    public void ExibirDetalhesDaMusica()
    {
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Música: {Nome}");
        Console.WriteLine($"Duração: {Duracao/100}");
        Console.WriteLine($"Genero musical: {Genero}");
        Console.WriteLine($"Tonalidade: {Tonalidade}");

    }
    

}
