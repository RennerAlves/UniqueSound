using Screen_Sound_04.Modelos;
using Screen_Sound_04.Menus;
using Screen_Sound_04.API;


List<Musica> listaDeMusicasDaAPI = new();

Dictionary<int, Menu> opcoes = new();
opcoes.Add(1, new MenuExibirTodosGenerosMusicas());
opcoes.Add(2, new MenuFiltrarArtistasPeloNome());
opcoes.Add(3, new MenuFiltrarMusicasDeUmArtista());
opcoes.Add(4, new MenuFiltrarMusicasPorAno());
opcoes.Add(-1, new MenuSair());






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
    string opcaoEscolhida = Console.ReadLine()!;

    try
    {

        int numeroOpcao = int.Parse(opcaoEscolhida);
        if (opcoes.ContainsKey(numeroOpcao))
        {

            Menu menuASerExibido = opcoes[numeroOpcao];
            menuASerExibido.Executar(listaDeMusicasDaAPI);

            if (numeroOpcao > 0)
            {
                Console.Clear();
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
    catch
    {
        Console.WriteLine("Opção inválida! Tente novamente.");
        Thread.Sleep(2000);
        Console.Clear();
        ExibirOpcoesDoMenu();
    }

}



listaDeMusicasDaAPI = await DesserializacaoDosDados.DesserializarDadosDaAPIJson(listaDeMusicasDaAPI);
ExibirOpcoesDoMenu();


