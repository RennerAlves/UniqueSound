using Screen_Sound_04.Abstract;
using Screen_Sound_04.Factory.Products;

namespace Screen_Sound_04.Factory
{
    public class MenuFactory : IMenuFactory
    {
        public MenuGenerateJsonFile CreateMenuGenerateJsonFile()
        {
            return new MenuGenerateJsonFile();
        }
    }
}


