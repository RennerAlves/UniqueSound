using Screen_Sound_04.Modelos;
using Screen_Sound_04.Menus;

namespace Screen_Sound_04.Filtros;

internal class LinqFilter
{
    public static void ExibirTodosGenerosMusicais(List<Musica> ConjuntoDeMusicasDaAPI)
    {
        var todosGenerosMusicais = ConjuntoDeMusicasDaAPI.Select(m => m.GeneroMusical).Distinct().ToList();

        for (int i = 0; i < todosGenerosMusicais.Count; i++)
        {
            Console.WriteLine($"- {todosGenerosMusicais[i]}");
        }

    }


    //Precisamos filtrar todos os artistas ONDE o gênero deles é igual ao especificado.
    public static void FiltrarArtistasPorGeneroMusical(List<Musica> ConjuntoDeMusicasDaAPI, string GeneroMusicalEspecificado)
    {
        var artistasDoGeneroMusical = ConjuntoDeMusicasDaAPI.Where(musica => musica.GeneroMusical!.Contains(GeneroMusicalEspecificado))
            .Select(musica => musica.nomeDoArtista).Distinct().ToList();

        for (int i = 0; i < artistasDoGeneroMusical.Count; i++)
        {
            Console.WriteLine($"- {artistasDoGeneroMusical[i]}");
        }

    }


    public static void FiltrarMusicasDeUmArtista(List<Musica> ConjuntoDeMusicasDaAPI, string nomeDoArtista)
    {
        var musicasDoArtista = ConjuntoDeMusicasDaAPI.Where(musica => musica.nomeDoArtista!.Contains(nomeDoArtista)).ToList();

        for (int i = 0; i < musicasDoArtista.Count; i++)
        {
            Console.WriteLine(musicasDoArtista[i].NomeDaMusica);
        }
       
    }


    public static void FiltrarMusicasDoAno(List<Musica> ConjuntoDeMusicasDaAPI, string ano)
    {
        int anoDaMusica = int.Parse(ano);
        var musicasDoAno = ConjuntoDeMusicasDaAPI.Where(m => m.Ano == anoDaMusica).ToList();

        for (int i = 0; i < musicasDoAno.Count; i++)
        {
            Console.WriteLine(musicasDoAno[i].NomeDaMusica);
            
        }
        
    }
}
