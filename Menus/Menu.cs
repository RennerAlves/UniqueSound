using Screen_Sound_04.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Screen_Sound_04.Menus;

public class Menu
{
    public virtual void Executar(List<Musica> musica)
    {
        Console.Clear();      
    }

    public static void ExibirTituloFormatado(string tituloEscolhido)
    {
        var asteriscosFormatados = string.Empty.PadLeft(tituloEscolhido.Length, '*');
        Console.WriteLine(asteriscosFormatados);
        Console.WriteLine(tituloEscolhido);
        Console.WriteLine(asteriscosFormatados);
        Console.WriteLine();
    }

    public static void ConfirmarRetornoAoMenuPrincipal()
    {
        Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal...");
        Console.ReadKey();
        Console.Clear();

    }
}





