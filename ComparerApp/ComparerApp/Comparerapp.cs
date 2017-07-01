using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComparerApp.SortFolder;
using ComparerApp.Model;

namespace ComparerApp
{
    public partial class Mainview : Form
    {
        public EventHandler Addlistofconcerts;
        public EventHandler Sortdate;
        public EventHandler Sortprice;
        public EventHandler Sortartist;

        public ListBox Concertlist => ArtistLBox;
        public Mainview()
        {
            InitializeComponent();
        }  

 
        private void NewListofConcerts_Click(object sender, EventArgs e)
        {
            Addlistofconcerts?.Invoke(this, new EventArgs());
        }

        private void SortArtistBtn_Click(object sender, EventArgs e)
        {
            Sortartist?.Invoke(this, new EventArgs());
        }

        private void SortPriceBtn_Click(object sender, EventArgs e)
        {
            Sortprice?.Invoke(this, new EventArgs());
        }

        private void SortDateBtn_Click(object sender, EventArgs e)
        {
            Sortdate?.Invoke(this, new EventArgs());
        }
    }
}