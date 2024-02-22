using Screen_Sound_04.Filtros;
using Screen_Sound_04.Modelos;


namespace Screen_Sound_04.Menus;

internal class MenuFiltrarMusicasPorAno : Menu
{
    public override void Executar(List<Musica> musica)
    {
        base.Executar(musica);
        ExibirTituloFormatado($"Músicas do Ano");
        Console.Write("Digite o ano que deseja para filtrar as músicas: ");
        string ano = Console.ReadLine()!;
        Console.WriteLine($"\nAs músicas cadastradas nessa API do ano de {ano} são:\n");

        LinqFilter.FiltrarMusicasDoAno(musica, ano);
        
    }
}
