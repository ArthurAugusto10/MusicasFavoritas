using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace ScreenSound_Quatro.Modelos
{
    internal class MusicasFavoritas
    {
        public string? Nome { get; set; }
        public List<Musica> ListaDeMusicasFavoritas { get; }

        public MusicasFavoritas(string nome) 
        {
            Nome = nome;
            ListaDeMusicasFavoritas = new List<Musica>();
        }

        public void AdicionarMusicasFavoritas(Musica musica)
        {
            ListaDeMusicasFavoritas.Add(musica);
        }

        public void ExibirMusicasFavoritas()
        {
            Console.WriteLine($"Essas são as músicas favoritas de {Nome}: ");
            foreach (var Musicas in ListaDeMusicasFavoritas)
            {
                Console.WriteLine($"-> {Musicas.Nome} do artista {Musicas.Artista}");
            }
        }

        public void GerarArquivoJson()
        {
            string Json = JsonSerializer.Serialize( new
            {
                nome = Nome,
                musicas = ListaDeMusicasFavoritas
            });
            string NomeDoArquivo = $"Musicas-favoritas-{Nome}.json";
            File.WriteAllText(NomeDoArquivo,Json);
            Console.WriteLine();
            Console.WriteLine($"O arquivo Json criado com sucesso :) {Path.GetFullPath(NomeDoArquivo)}");
        }
    }
}
