﻿using dSearch.Framework;
using dSearch.Framework.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dSearch.Framework.FileSearcher
{
    public class FileSearcher : ISearcher
    {
        public List<SerachResult> Search(string param)
        {
            throw new NotImplementedException();
        }

        public string Search_JSON(string param)
        {
            //Здесь можно среилаизовать в JSON результат Search(string param)
            return string.Empty;
        }
    }
}
