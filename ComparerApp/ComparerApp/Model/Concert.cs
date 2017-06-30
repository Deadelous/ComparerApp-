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
        public string Artist { get; set; }

        public DateTime Date { get; set; }

        public double Price { get; set; }

        public string Concertinfo { get; set; }

        public override string ToString()
        {
            return $"{Artist} + {Date} + {Price}";
        }
    }
}
