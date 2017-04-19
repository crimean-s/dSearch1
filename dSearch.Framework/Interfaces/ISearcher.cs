using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dSearch.Framework.FrameworkItems;

namespace dSearch.Framework.Interfaces
{
    public interface ISearcher
    {
        string Name { get; set; } //имя "искателя"
        List<SearchResult> Search(string param); //возвращает типизированный результат в виде коллекции
        string Search_JSON(string param); // возвращает нетипизированный результат в виде json строки
    }
}
