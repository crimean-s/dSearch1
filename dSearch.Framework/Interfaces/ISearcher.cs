using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dSearch.Framework.Interfaces
{
    public interface ISearcher
    {
        string Name { get; set; } //имя "искателя"
        List<SerachResult> Search(string param); //возвращает типизированный результат в виде коллекции
        string Search_JSON(string param); // возвращает нетипизированный результат в виде json строки
    }
}
