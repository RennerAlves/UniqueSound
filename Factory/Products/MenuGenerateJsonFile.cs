using Screen_Sound_04.Menus;
using Screen_Sound_04.Modelos;
using Screen_Sound_04.Abstract.Products;

namespace Screen_Sound_04.Factory.Products;

public class MenuGenerateJsonFile : Menu, IMenu
{
    public void ExecutarMenu(List<Musica> ConjuntodeMusicasDaAPI)
    {
        ExibirTitulo();
        ExibirMensagemDeContextualizacao();
        GerarArquivoJson();
    }

    public void ExibirTitulo()
    {
        Menu.ExibirTituloFormatado("Menu Gerar Arquivo Json");
    }
    public void ExibirMensagemDeContextualizacao()
    {
        Console.WriteLine("Cadastre músicas para gerar um arquivo txt!");
    }
    public void GerarArquivoJson()
    {
        //Realizar implementação.
    }
}
