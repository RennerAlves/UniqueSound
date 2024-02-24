using Screen_Sound_04.Factory.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Screen_Sound_04.Abstract;

public interface IMenuFactory
{
    MenuGenerateJsonFile CreateMenuGenerateJsonFile();
    MenuFilterSongsByArtists CreateMenuFilterSongsByArtists();
    MenuOrderArtistsByName CreateMenuOrderArtistsByName();
    MenuSoundsByYear CreateMenuSoundsByYear();
    MusicGenresMenu CreateMusicGenresMenu();
}
