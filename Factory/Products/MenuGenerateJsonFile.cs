using Screen_Sound_04.Menus;
using Screen_Sound_04.Abstract;
using Screen_Sound_04.Abstract.Products;

namespace Screen_Sound_04.Factory.Products;

public class MenuGenerateJsonFile : Menu, IMenu
{
    public void ExibirTitulo()
    {
        Menu.ExibirTituloFormatado("Menu Gerar Arquivo Json");
    }
    public void ExibirMensagem()
    {
        Console.WriteLine("Cadastre músicas para gerar um arquivo txt!");
    }
    public void ExecutarAcao()
    {
        //CadastrarMusicas();
        //GerarArquivoJson();
    }


}
