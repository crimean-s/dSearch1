using dSearch.Framework.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dSearch.Framework.PluginLoader
{
    public class PluginLoader
    {
        

        public List<ISearcher> LoadPlugins()
        {
            List<ISearcher> ISearcherInstances = new List<ISearcher>();

            //идем в папку, где лежат все dll (в апп конфиге нужно указать, где будут лежать dll устанавливаемых плагинов) (dSearch.Framework.FileSearcher, dSearch.Framework.WikiSearcher и др)
            //грузим dll создаем инстансы ISearcher
            //копим все ISearcher в коллекцию
            //возвращаем список

            return ISearcherInstances;
        }
    }
}
