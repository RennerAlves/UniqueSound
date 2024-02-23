using Screen_Sound_04.Modelos;
using System.Text.Json;


namespace Screen_Sound_04.API;

internal class DesserializacaoDosDadosDaAPI
{


    public async static Task<List<Musica>> DesserializarDadosDaAPI(List<Musica> ConjuntoDeMusicasDaAPI)
    {
        HttpClient client = CriarHttpClient();
        return await ExtrairDadosDaAPI(client, ConjuntoDeMusicasDaAPI);
    }


    private static HttpClient CriarHttpClient()
    {
       return new HttpClient();
    }



    private static async Task<List<Musica>> ExtrairDadosDaAPI(HttpClient client, List<Musica> ConjuntoDeMusicasDaAPI)
    {
        try
        {
            return await ObterDadosClassificados(client, ConjuntoDeMusicasDaAPI);
            
        }
        catch
        {
            return await FalhaNaConexaoComAPI(client, ConjuntoDeMusicasDaAPI);
        }
    }


    private async static Task<List<Musica>> ObterDadosClassificados(HttpClient client, List<Musica> ConjuntoDeMusicasDaAPI)
    {
            string dadosDaAPIJson = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
            ConjuntoDeMusicasDaAPI = JsonSerializer.Deserialize<List<Musica>>(dadosDaAPIJson)!;
            return ConjuntoDeMusicasDaAPI;
    }


    private async static Task<List<Musica>> FalhaNaConexaoComAPI(HttpClient client, List<Musica> ConjuntoDeMusicasDaAPI)
    {
        Console.WriteLine("Tentando fazer conexão com a API...");
        Thread.Sleep(1000);
        return await ObterDadosClassificados(client, ConjuntoDeMusicasDaAPI);
    }
}

