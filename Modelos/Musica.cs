using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Screen_Sound_04.Modelos
{
    internal class Musica
    {

        [JsonPropertyName("artist")]
        public string? nomeDoArtista { get; set; }
        [JsonPropertyName("song")]
        public string? NomeDaMusica { get; set; }
        [JsonPropertyName("duration_ms")]
        public int TempoDeDuracao { get; set; }
        [JsonPropertyName("genre")]
        public string? GeneroMusical { get; set; }
        [JsonPropertyName("year")]
        public string? AnoString { get; set; }

        public int Ano
        {
            get
            {
                return int.Parse(AnoString!);
            }
        }



        public void ExibirDetalhesDasMusicas()
        {
            Console.WriteLine($"Artista: {nomeDoArtista}");
            Console.WriteLine($"Nome da Música: {NomeDaMusica}");
            Console.WriteLine($"Tempo de Duração: {TempoDeDuracao / 1000}");
            Console.WriteLine($"Gênero Musical: {GeneroMusical}");
        }


    }
}
