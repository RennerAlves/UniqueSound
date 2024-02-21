using Screen_Sound_04.Menus;
using Screen_Sound_04.Modelos;
namespace Screen_Sound_04.Filtros;

internal class LinqOrder
{
    public static void OrdenarArtistasPeloNome(List<Musica> musicas)
    {
        var artistasOrdenadosPeloNome = musicas.OrderBy(m => m.artista).Select(m => m.artista).Distinct().ToList();
        var artistasOrdenadosInversamentePeloNome = musicas.OrderByDescending(m => m.artista).Select(m => m.artista).Distinct().ToList();

        for (int i = 0; i < artistasOrdenadosPeloNome.Count; i++)
        {
            Console.WriteLine($"- {artistasOrdenadosPeloNome[i]}");
        }
        Menu.VoltarAoMenuPrincipal();
    }
}
