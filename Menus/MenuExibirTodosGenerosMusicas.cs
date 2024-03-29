﻿using Screen_Sound_04.Modelos;
using Screen_Sound_04.Filtros;


namespace Screen_Sound_04.Menus;

internal class MenuExibirTodosGenerosMusicas : Menu
{
    public override void Executar(List<Musica> ConjuntoDeMusicasDaAPI)
    {
        base.Executar(ConjuntoDeMusicasDaAPI);
        Console.Clear();
        ExibirTituloFormatado("Exibir os Gêneros Musicais");
        Console.WriteLine("Os gêneros musicas disponíveis nessa API são:\n");

        
        LinqFilter.ExibirTodosGenerosMusicais(ConjuntoDeMusicasDaAPI);
        

    }
}
