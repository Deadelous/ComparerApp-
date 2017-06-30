using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComparerApp.Model;

namespace ComparerApp.SortFolder
{
    public class PriceSort : IComparer<Concert>
    {
        public int Compare(Concert x, Concert y)
        {
            return x.Price.CompareTo(y.Price);
        }
    }

}

