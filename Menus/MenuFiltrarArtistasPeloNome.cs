using Screen_Sound_04.Filtros;
using Screen_Sound_04.Modelos;


namespace Screen_Sound_04.Menus;

internal class MenuFiltrarArtistasPeloNome : Menu
{
    public override void Executar(List<Musica> ConjuntoDeMusicasDaAPI)
    {
        base.Executar(ConjuntoDeMusicasDaAPI);
        ExibirTituloFormatado("Artistas Filtrados Pelo Nome");
        Console.WriteLine("Os artistas disponíveis nessa API são:\n");

        LinqOrder.OrdenarArtistasPeloNome(ConjuntoDeMusicasDaAPI);
        
    }
}
