using Screen_Sound_04.Modelos;
using Screen_Sound_04.Menus;

namespace Screen_Sound_04.Filtros;

internal class LinqFilter
{
    public static void FiltrarTodosGenerosMusicais(List<Musica> musicas)
    {
        var todosGenerosMusicais = musicas.Select(m => m.GeneroMusical).Distinct().ToList();

        for (int i = 0; i < todosGenerosMusicais.Count; i++)
        {
            Console.WriteLine($"- {todosGenerosMusicais[i]}");
        }

        Menu.VoltarAoMenuPrincipal();
    }


    //Precisamos filtrar todos os artistas ONDE o gênero deles é igual ao especificado.
    public static void FiltrarArtistasPorGeneroMusical(List<Musica> musica, string GeneroMusical)
    {
        var artistasDoGeneroMusical = musica.Where(m => m.GeneroMusical!.Contains(GeneroMusical))
            .Select(m => m.artista).Distinct().ToList();

        for (int i = 0; i < artistasDoGeneroMusical.Count; i++)
        {
            Console.WriteLine($"- {artistasDoGeneroMusical[i]}");
        }

        Menu.VoltarAoMenuPrincipal();
    }


    public static void FiltrarMusicasDeUmArtista(List<Musica> musicas, string nomeDoArtista)
    {
        var musicasDoArtista = musicas.Where(m => m.artista!.Contains(nomeDoArtista)).ToList();

        for (int i = 0; i < musicasDoArtista.Count; i++)
        {
            Console.WriteLine(musicasDoArtista[i].NomeDaMusica);
        }
        Menu.VoltarAoMenuPrincipal();
    }


    public static void FiltrarMusicasPorAno(List<Musica> musicas, string ano)
    {
        int anoDaMusica = int.Parse(ano);
        var musicasDoAno = musicas.Where(m => m.Ano == anoDaMusica).ToList();

        for (int i = 0; i < musicasDoAno.Count; i++)
        {
            Console.WriteLine(musicasDoAno[i].NomeDaMusica);
            
        }
        Menu.VoltarAoMenuPrincipal();
    }
}
