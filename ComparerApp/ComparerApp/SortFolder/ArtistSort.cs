using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComparerApp.Model;


namespace ComparerApp.SortFolder
{
    public class ArtistSort : IComparer<Concert>
    {
        public int Compare(Concert x, Concert y)
        {
            return x.Artist.CompareTo(y.Artist);
        }
    }
}
