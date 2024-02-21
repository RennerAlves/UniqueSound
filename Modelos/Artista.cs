using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Screen_Sound_04.Modelos
{
    internal class Artista
    {
        public Artista(string nome)
        {
            Nome = nome;
        }
        public string Nome { get;  }

        private List<Musica> listaDeMusica;
        public IEnumerable<Musica> ListaDeMusica => listaDeMusica;

        public void AdicionarMusica(Musica musica)
        {
            listaDeMusica.Add(musica);
        }

    }
}
