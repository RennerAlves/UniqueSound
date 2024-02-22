using Screen_Sound_04.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Screen_Sound_04.Menus;

internal class Menu
{
    public virtual void Executar(List<Musica> musica)
    {
        Console.Clear();      
    }

    public void ExibirOpcaoDeTitulo(string nome)
    {
        var titulo = string.Empty.PadLeft(nome.Length, '*');
        Console.WriteLine(titulo);
        Console.WriteLine(nome);
        Console.WriteLine(titulo);
        Console.WriteLine();
    }

    public static void ConfirmarRetornoAoMenuPrincipal()
    {
        Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal...");
        Console.ReadKey();
        Console.Clear();

    }
}





