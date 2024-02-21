using Screen_Sound_04.Filtros;
using Screen_Sound_04.Modelos;


namespace Screen_Sound_04.Menus;

internal class MenuFiltrarMusicasDeUmArtista : Menu
{
    public override void Executar(List<Musica> musica)
    {
        base.Executar(musica);
        ExibirOpcaoDeTitulo($"Exibir músicas de um artista");
        Console.Write("\nDigite o nome do artista que você deseja conhecer as músicas: ");
        string nomeDoArtista = Console.ReadLine()!;

        Console.WriteLine($"\nAs músicas disponíveis na API do artista {nomeDoArtista} são:\n");

        LinqFilter.FiltrarMusicasDeUmArtista(musica, nomeDoArtista);
        
    }
}
