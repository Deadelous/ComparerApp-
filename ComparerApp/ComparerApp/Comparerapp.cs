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
        public EventHandler LabelsofListbox;
        public EventHandler CountTicket;
        public EventHandler PriceofTickets;
        

        public ListBox Concertlist => ArtistLBox;
        public Label ArtistName => artistnameLbl;

        public Label DateConcert => Datenamelbl;

        public Label PriceConcert => Pricenamelbl;

        public Label Pricetotal => Pricetotallbl;

        public Label CountTickets => Countlbl;

        public NumericUpDown TotalTickets => numberoftickets;
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

        private void ArtistLBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LabelsofListbox?.Invoke(this, new EventArgs());
        }

        private void Order_BTN_Click(object sender, EventArgs e)
        {
            CountTicket?.Invoke(this, new EventArgs());
            PriceofTickets?.Invoke(this, new EventArgs());
        }
    }
}