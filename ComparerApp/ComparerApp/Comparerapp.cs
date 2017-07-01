using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComparerApp.Model;

namespace ComparerApp
{
    public partial class Concertapp : Form
    {
        private List<Concert> concerten;
        public Concertapp()
        {
            InitializeComponent();

            addinListbox();
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
            ArtistLBox.DataSource = addConcerts();

        }
    }
}
