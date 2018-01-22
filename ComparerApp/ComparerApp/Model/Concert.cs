using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparerApp.Model
{
    public class Concert
    {

        public Concert(string artist, DateTime date, double price)
        {
            this.Artist = artist;
            this.Date = date;
            this.Price = price;
        }
        public string Artist { get;  }

        public DateTime Date { get; }

        public double Price { get; }

        public string Concertinfo { get; }

        public override string ToString()
        {
            return $"{Artist} + {Date.ToShortDateString()} + {Price.ToString("c")}";
        }
    }
}
