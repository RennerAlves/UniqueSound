using Screen_Sound_04.Menus;
using Screen_Sound_04.Modelos;
namespace Screen_Sound_04.Filtros;

internal class LinqOrder
{
    public static void OrdenarArtistasPeloNome(List<Musica> ConjuntoDeMusicasDaAPI)
    {
        var artistasOrdenadosPeloNome = ConjuntoDeMusicasDaAPI.OrderBy(musica => musica.nomeDoArtista).Select(musica => musica.nomeDoArtista).Distinct().ToList();
        var artistasOrdenadosInversamentePeloNome = ConjuntoDeMusicasDaAPI.OrderByDescending(msuica => msuica.nomeDoArtista).Select(musica => musica.nomeDoArtista).Distinct().ToList();

        for (int i = 0; i < artistasOrdenadosPeloNome.Count; i++)
        {
            Console.WriteLine($"- {artistasOrdenadosPeloNome[i]}");
        }
        Menu.ConfirmarRetornoAoMenuPrincipal();
    }
}
