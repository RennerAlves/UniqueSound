using Screen_Sound_04.Modelos;
using System.Collections.Generic;
using System.Text.Json;


namespace Screen_Sound_04.API;

internal class DesserializacaoDosDados
{
   public async static Task<List<Musica>> DesserializarDadosDaAPIJson(List<Musica> ConjuntoDeMusicasDaAPI)
    {
        using (HttpClient client = new HttpClient())
        {
            try
            {
                string dadosDaAPIJson = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");

                ConjuntoDeMusicasDaAPI = JsonSerializer.Deserialize<List<Musica>>(dadosDaAPIJson)!;
                return ConjuntoDeMusicasDaAPI;
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Tentando fazer conexão com a API...");
                Console.WriteLine(ex.Message);
                Thread.Sleep(1000);
                return await DesserializacaoDosDados.DesserializarDadosDaAPIJson(ConjuntoDeMusicasDaAPI);
                
            }
        }
    }
}
