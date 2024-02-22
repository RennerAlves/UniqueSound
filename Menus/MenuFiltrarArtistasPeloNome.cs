using Screen_Sound_04.Filtros;
using Screen_Sound_04.Modelos;


namespace Screen_Sound_04.Menus;

internal class MenuFiltrarArtistasPeloNome : Menu
{
    public override void Executar(List<Musica> musica)
    {
        base.Executar(musica);
        ExibirTituloFormatado("Artistas Filtrados Pelo Nome");
        Console.WriteLine("Os artistas disponíveis nessa API são:\n");

        LinqOrder.OrdenarArtistasPeloNome(musica);
        
    }
}
