using Screen_Sound_04.Abstract.Products;
using Screen_Sound_04.Filtros;
using Screen_Sound_04.Menus;
using Screen_Sound_04.Modelos;

namespace Screen_Sound_04.Factory.Products
{
    public class MenuSoundsByYear : Menu, IMenu
    {
        public void ExecutarMenu(List<Musica> ConjuntoDeMusicasDaAPI)
        {
            ExibirTitulo();
            int AnoDesejado = CapturarAnoParaFiltro();
            ExibirMensagemDeContextualizacao();
            ExibirMusicasDoAno(ConjuntoDeMusicasDaAPI, AnoDesejado);

        }

        public void ExibirTitulo()
        {
            Menu.ExibirTituloFormatado("Músicas Do Ano");
        }
        public int CapturarAnoParaFiltro()
        {
            Console.Write("Digite um ano para conhecer as músicas que foram sucesso nele: ");
            int anoDasMusicas = int.Parse(Console.ReadLine()!);
            return anoDasMusicas;
        }
        public void ExibirMensagemDeContextualizacao()
        {
            Console.WriteLine("\nMúsicas que foram sucesso no ano:");
        }
        public void ExibirMusicasDoAno(List<Musica> musicasDaAPI, int anoParaFiltragem)
        {
            LinqFilter.FiltrarMusicasDoAno(musicasDaAPI, anoParaFiltragem);
        }

 

    }
}
