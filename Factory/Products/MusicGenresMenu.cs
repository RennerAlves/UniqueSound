using Screen_Sound_04.Abstract.Products;
using Screen_Sound_04.Filtros;
using Screen_Sound_04.Menus;
using Screen_Sound_04.Modelos;

namespace Screen_Sound_04.Factory.Products;

public class MusicGenresMenu : Menu, IMenu
{
    public void ExecutarMenu(List<Musica> ConjuntodeMusicasDaAPI)
    {
        ExibirTitulo();
        ExibirMensagemDeContextualizacao();
        ExibirGenerosMusicaisDaAPI(ConjuntodeMusicasDaAPI);
    }

    public void ExibirTitulo()
    {
        Menu.ExibirTituloFormatado("Exibir os Gêneros Musicais");
    }
    public void ExibirMensagemDeContextualizacao()
    {
        Console.WriteLine("Os gêneros musicas disponíveis nessa API são:\n");
    }
    public void ExibirGenerosMusicaisDaAPI(List<Musica> conjuntodeMusicas)
    {
        LinqFilter.ExibirTodosGenerosMusicais(conjuntodeMusicas);
    }


}