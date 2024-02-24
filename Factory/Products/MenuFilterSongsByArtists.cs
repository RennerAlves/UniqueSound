using Screen_Sound_04.Filtros;
using Screen_Sound_04.Menus;
using Screen_Sound_04.Modelos;

namespace Screen_Sound_04.Factory.Products;

public class MenuFilterSongsByArtists
{
    public void ExecutarMenu(List<Musica> ConjuntodeMusicasDaAPI)
    {
        ExibirTitulo();
        string nomeDoArtista = CaptarNomeDoArtista();
        ExibirMensagemDeContextualizacao();
        FiltrarMusicasDoArtista(ConjuntodeMusicasDaAPI, nomeDoArtista);
    }

    public void ExibirTitulo()
    {
        Menu.ExibirTituloFormatado("Músicas de um Artista");
    }
    public string CaptarNomeDoArtista()
    {
        Console.Write("Digite o nome do artista que deseja buscar: ");
        string nomeDoArtista = Console.ReadLine()!;
        return nomeDoArtista;
    }
    public void ExibirMensagemDeContextualizacao()
    {
        Console.WriteLine("\nAs músicas desse artista que estão disponíveis na API são:\n");
    }

    public void FiltrarMusicasDoArtista(List<Musica> conjuntodeMusicas, string nomeDoArtista)
    {
        LinqFilter.FiltrarMusicasDeUmArtista(conjuntodeMusicas, nomeDoArtista);
    }
}
