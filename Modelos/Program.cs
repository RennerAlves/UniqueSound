using Screen_Sound_04.Modelos;
using Screen_Sound_04.Menus;
using Screen_Sound_04.API;


List<Musica> ConjuntoDeMusicasDaAPI = new();

Dictionary<int, Menu> opcoesDoMenuPrincipal = new();
opcoesDoMenuPrincipal.Add(1, new MenuExibirTodosGenerosMusicas());
opcoesDoMenuPrincipal.Add(2, new MenuFiltrarArtistasPeloNome());
opcoesDoMenuPrincipal.Add(3, new MenuFiltrarMusicasDeUmArtista());
opcoesDoMenuPrincipal.Add(4, new MenuFiltrarMusicasPorAno());
opcoesDoMenuPrincipal.Add(-1, new MenuSair());






void ExibirLogo()
{
    Console.WriteLine(@"

██╗░░░██╗███╗░░██╗██╗░██████╗░██╗░░░██╗███████╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██║░░░██║████╗░██║██║██╔═══██╗██║░░░██║██╔════╝  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
██║░░░██║██╔██╗██║██║██║██╗██║██║░░░██║█████╗░░  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
██║░░░██║██║╚████║██║╚██████╔╝██║░░░██║██╔══╝░░  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
╚██████╔╝██║░╚███║██║░╚═██╔═╝░╚██████╔╝███████╗  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
░╚═════╝░╚═╝░░╚══╝╚═╝░░░╚═╝░░░░╚═════╝░╚══════╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");

    Console.WriteLine("\nSeja bem vindo ao Unique Sound!\n");
}


void ExibirOpcoesDoMenu()
{
    Console.Clear();
    ExibirLogo();
    Console.WriteLine("O que você deseja fazer?\n");
    Console.WriteLine("1- Exibir todos os gêneros Musicais");
    Console.WriteLine("2- Exibir artistas ordenados pelo nome");
    Console.WriteLine("3- Exibir Musicas de um artista");
    Console.WriteLine("4- Exibir músicas de um ano");
    Console.WriteLine("-1 para Sair");

    Console.Write("\nDigite a sua opção: ");
    string menuSelecionadoPeloUsuario = Console.ReadLine()!;

    try
    {

        int indiceDoMenuSelecionado = int.Parse(menuSelecionadoPeloUsuario);
        if (opcoesDoMenuPrincipal.ContainsKey(indiceDoMenuSelecionado))
        {

            Menu menuSolicitadoPeloUsuario = opcoesDoMenuPrincipal[indiceDoMenuSelecionado];
            menuSolicitadoPeloUsuario.Executar(ConjuntoDeMusicasDaAPI);

            if (indiceDoMenuSelecionado > 0)
            {
                Menu.ConfirmarRetornoAoMenuPrincipal();
                ExibirOpcoesDoMenu();    
            }

        }
        else
        {
            Console.WriteLine("Opção inválida!");
            Thread.Sleep(2000);
            Console.Clear();
            ExibirOpcoesDoMenu();
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
        Thread.Sleep(2000);
        Console.Clear();
        ExibirOpcoesDoMenu();
    }

}



ConjuntoDeMusicasDaAPI = await DesserializacaoDosDados.DesserializarDadosDaAPIJson(ConjuntoDeMusicasDaAPI);
ExibirOpcoesDoMenu();


