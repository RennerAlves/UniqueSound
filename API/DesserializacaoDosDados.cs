using Screen_Sound_04.Modelos;
using System.Text.Json;


namespace Screen_Sound_04.API;

internal class DesserializacaoDosDados
{
   public async static Task<List<Musica>> DesserializarDadosDaAPIJson(List<Musica> listaDeMusicasDaAPI)
    {
        using (HttpClient client = new HttpClient())
        {
            try
            {
                string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");

                var musica = JsonSerializer.Deserialize<List<Musica>>(resposta);
                listaDeMusicasDaAPI = musica!;
                return listaDeMusicasDaAPI;
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return listaDeMusicasDaAPI;
            }
        }
    }
}
