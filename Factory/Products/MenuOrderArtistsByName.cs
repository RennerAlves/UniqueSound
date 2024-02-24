using Screen_Sound_04.Filtros;
using Screen_Sound_04.Menus;
using Screen_Sound_04.Modelos;

namespace Screen_Sound_04.Factory.Products;

public class MenuOrderArtistsByName
{
    public void ExecutarMenu(List<Musica> ConjuntodeMusicasDaAPI)
    {
        ExibirTitulo();
        ExibirMensagemDeContextualizacao();
        OrdenarArtistasPeloNome(ConjuntodeMusicasDaAPI);
    }

    public void ExibirTitulo()
    {
        Menu.ExibirTituloFormatado("Exibir Artistas Ordenados");
    }
    public void ExibirMensagemDeContextualizacao()
    {
        Console.WriteLine("Artistas ordenados pelo nome com base em dados da API::\n");
    }
    public void OrdenarArtistasPeloNome(List<Musica> conjuntodeMusicas)
    {
        LinqOrder.OrdenarArtistasPeloNome(conjuntodeMusicas);
    }
}
