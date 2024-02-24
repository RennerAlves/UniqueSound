using Screen_Sound_04.Abstract;
using Screen_Sound_04.Factory.Products;

namespace Screen_Sound_04.Factory;

public class MenuFactory : IMenuFactory
{
    public MenuGenerateJsonFile CreateMenuGenerateJsonFile()
    {
        return new MenuGenerateJsonFile();
    }
    public MenuFilterSongsByArtists CreateMenuFilterSongsByArtists()
    {
        return new MenuFilterSongsByArtists();
    }
    public MenuOrderArtistsByName CreateMenuOrderArtistsByName()
    {
        return new MenuOrderArtistsByName();
    }
    public MenuSoundsByYear CreateMenuSoundsByYear()
    {
        return new MenuSoundsByYear();
    }
    public MusicGenresMenu CreateMusicGenresMenu()
    {
        return new MusicGenresMenu();
    }
}



