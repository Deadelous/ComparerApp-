using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComparerApp.Model;
using ComparerApp.SortFolder;

namespace ComparerApp.Controller
{
    class MainController
    {  
        public Mainview view { get; }

        private List<Concert> concerten;

        public MainController()
        {
            view = new Mainview();

            view.Sortartist += (sender, e) => SortonArtist();
            view.Sortdate += (sender, e) => SortonDate();
            view.Sortprice += (sender, e) => SortonPrice();
            view.Addlistofconcerts += (sender, e) => addinListbox();
            view.LabelsofListbox += (sender, e) => labelsListbox();
            view.PriceofTickets += (sender, e) => pricetickets();
            view.CountTicket += (sender, e) => counttickets();

        }

        public List<Concert> addConcerts()
        {
            concerten = new List<Concert>();

            concerten.Add(new Concert("Sting", new DateTime(2014, 12, 3), 75));
            concerten.Add(new Concert("U2", new DateTime(2015, 1, 14), 88));
            concerten.Add(new Concert("Coldplay", new DateTime(2015, 7, 10), 110));
            concerten.Add(new Concert("Afrojack", new DateTime(2014, 11, 17), 65));
            concerten.Add(new Concert("The Killers", new DateTime(2015, 3, 25), 58));
            concerten.Add(new Concert("Pitbull", new DateTime(2015, 2, 24), 96.5));
            concerten.Add(new Concert("Beyonce", new DateTime(2015, 8, 1), 75));
            concerten.Add(new Concert("Pink", new DateTime(2015, 11, 3), 82));
            concerten.Add(new Concert("Adele", new DateTime(2015, 9, 25), 92.5));

            return concerten;

        }

        public void addinListbox()
        {
            foreach (Concert r in addConcerts())
            {
                view.Concertlist.Items.Add(r);

            }

        }

        public void SortonDate()
        {
            List<Concert> temp = new List<Concert>();
            foreach (Concert r in view.Concertlist.Items)
            {
                temp.Add(r);
            }

            temp.Sort(new DateSort());

            view.Concertlist.Items.Clear();
            foreach (Concert r in temp)
            {

                view.Concertlist.Items.Add(r);

            }
        }

        public void SortonArtist()
        {
            List<Concert> temp = new List<Concert>();
            foreach (Concert r in view.Concertlist.Items)
            {
                temp.Add(r);
            }

            temp.Sort(new ArtistSort());

            view.Concertlist.Items.Clear();
            foreach (Concert r in temp)
            {

                view.Concertlist.Items.Add(r);

            }
        }

        public void SortonPrice()
        {
            List<Concert> temp = new List<Concert>();
            foreach (Concert r in view.Concertlist.Items)
            {
                temp.Add(r);
            }

            temp.Sort(new PriceSort());

            view.Concertlist.Items.Clear();
            foreach (Concert r in temp)
            {

                view.Concertlist.Items.Add(r);

            }
        }

        public void labelsListbox()
        {
            Concert concert = (Concert)view.Concertlist.SelectedItem;
            view.ArtistName.Text = concert.Artist;
            view.DateConcert.Text = concert.Date.ToShortDateString();
            view.PriceConcert.Text = concert.Price.ToString("c");

        }

        public void counttickets()
        {
            view.CountTickets.Text = view.TotalTickets.Value.ToString();
        }

        public void pricetickets()
        {
            Concert concert = (Concert)view.Concertlist.SelectedItem;

            double result = concert.Price * Convert.ToDouble(view.TotalTickets.Value);

            view.Pricetotal.Text = result.ToString("c");

           
        }
    }
}

