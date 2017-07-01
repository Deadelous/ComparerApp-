﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComparerApp.Model;
using ComparerApp.SortFolder;

namespace ComparerApp.Controller
{
    public class MainController
    {
        private Concertapp view {get;}

        public List<Concert> concerten;

        public MainController()
        {
            view = new Concertapp();


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
               ArtistLBox.Items.Add(r);
            }

        }

        public void SortonDate()
        {
            List<Concert> temp = new List<Concert>();
            foreach (Concert r in ArtistLBox.Items)
            {
                temp.Add(r);
            }

            temp.Sort(new DateSort());

            ArtistLBox.Items.Clear();
            foreach (Concert r in temp)
            {

                ArtistLBox.Items.Add(r);

            }
        }

        public void SortonArtist()
        {
            List<Concert> temp = new List<Concert>();
            foreach (Concert r in ArtistLBox.Items)
            {
                temp.Add(r);
            }

            temp.Sort(new ArtistSort());

            ArtistLBox.Items.Clear();
            foreach (Concert r in temp)
            {

                ArtistLBox.Items.Add(r);

            }
        }

        public void SortonPrice()
        {
            List<Concert> temp = new List<Concert>();
            foreach (Concert r in ArtistLBox.Items)
            {
                temp.Add(r);
            }

            temp.Sort(new PriceSort());

            ArtistLBox.Items.Clear();
            foreach (Concert r in temp)
            {

                ArtistLBox.Items.Add(r);

            }
        }
    }
}