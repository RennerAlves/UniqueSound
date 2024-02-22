using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Screen_Sound_04.Modelos
{
    internal class Artista
    {
        public Artista(string nomeDoArtista)
        {
            NomeDoArtista = nomeDoArtista;
            MusicasDoArtista = new();
        }
        public string NomeDoArtista { get;  }

        private List<Musica> MusicasDoArtista;
        public IEnumerable<Musica> ConjuntoDeMusicasDoArtista => MusicasDoArtista;

        public void AdicionarMusica(Musica musicaASerAdicionada)
        {
            MusicasDoArtista.Add(musicaASerAdicionada);
        }

    }
}
