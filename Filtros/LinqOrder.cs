using Screen_Sound_04.Menus;
using Screen_Sound_04.Modelos;
namespace Screen_Sound_04.Filtros;

internal class LinqOrder
{
    public static void OrdenarArtistasPeloNome(List<Musica> ConjuntoDeMusicasDaAPI)
    {
        List<string?> artistasOrdenados = ObterNomesOrdenados(ConjuntoDeMusicasDaAPI);
        ExibirArtistasOrdenados(artistasOrdenados);
    }

    private static List<string?> ObterNomesOrdenados(List<Musica> ConjuntoDeMusicasDaAPI)
    {
        List<string?> artistasOrdenadosPeloNome = 
            ConjuntoDeMusicasDaAPI.OrderBy(musica => musica.nomeDoArtista)
            .Select(musica => musica.nomeDoArtista)
            .Distinct()
            .ToList();

        return artistasOrdenadosPeloNome;
    }

    private static void ExibirArtistasOrdenados(List<string?> artistasOrdenados)
    {
        for (int i = 0; i < artistasOrdenados.Count; i++)
        {
            Console.WriteLine($"- {artistasOrdenados[i]}");
        }
    }

}
