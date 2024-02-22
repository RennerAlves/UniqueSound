using Screen_Sound_04.Modelos;


namespace Screen_Sound_04.Menus;

internal class MenuSair : Menu
{
    public override void Executar(List<Musica> ConjuntoDeMusicasDaAPI)
    {
        Console.WriteLine("Obrigado por usar nosso programa!");
    }
}
