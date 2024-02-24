
using Screen_Sound_04.Modelos;

namespace Screen_Sound_04.Abstract.Products
{
    public interface IMenu
    {
        public void ExibirTitulo();
        public void ExibirMensagemDeContextualizacao();
        public void ExecutarMenu(List<Musica> ConjuntoDeMusicasDaAPI);

    }
}
