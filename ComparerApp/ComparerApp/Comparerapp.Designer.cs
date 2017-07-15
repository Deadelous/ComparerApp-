namespace ComparerApp
{
    partial class Mainview
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ArtistLBox = new System.Windows.Forms.ListBox();
            this.Order = new System.Windows.Forms.GroupBox();
            this.Ticketslbl = new System.Windows.Forms.Label();
            this.Countlbl = new System.Windows.Forms.Label();
            this.Pricetotallbl = new System.Windows.Forms.Label();
            this.Pricenamelbl = new System.Windows.Forms.Label();
            this.Datenamelbl = new System.Windows.Forms.Label();
            this.artistnameLbl = new System.Windows.Forms.Label();
            this.totalpricelbl = new System.Windows.Forms.Label();
            this.manylbl = new System.Windows.Forms.Label();
            this.Order_BTN = new System.Windows.Forms.Button();
            this.Totalticketlbl = new System.Windows.Forms.Label();
            this.Pricelbl = new System.Windows.Forms.Label();
            this.Datumlbl = new System.Windows.Forms.Label();
            this.Artiestlbl = new System.Windows.Forms.Label();
            this.NewListofConcerts = new System.Windows.Forms.Button();
            this.SortArtistBtn = new System.Windows.Forms.Button();
            this.SortPriceBtn = new System.Windows.Forms.Button();
            this.SortDateBtn = new System.Windows.Forms.Button();
            this.numberoftickets = new System.Windows.Forms.NumericUpDown();
            this.Order.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberoftickets)).BeginInit();
            this.SuspendLayout();
            // 
            // ArtistLBox
            // 
            this.ArtistLBox.FormattingEnabled = true;
            this.ArtistLBox.Location = new System.Drawing.Point(54, 114);
            this.ArtistLBox.Name = "ArtistLBox";
            this.ArtistLBox.Size = new System.Drawing.Size(549, 355);
            this.ArtistLBox.TabIndex = 3;
            this.ArtistLBox.SelectedIndexChanged += new System.EventHandler(this.ArtistLBox_SelectedIndexChanged);
            // 
            // Order
            // 
            this.Order.Controls.Add(this.numberoftickets);
            this.Order.Controls.Add(this.Ticketslbl);
            this.Order.Controls.Add(this.Countlbl);
            this.Order.Controls.Add(this.Pricetotallbl);
            this.Order.Controls.Add(this.Pricenamelbl);
            this.Order.Controls.Add(this.Datenamelbl);
            this.Order.Controls.Add(this.artistnameLbl);
            this.Order.Controls.Add(this.totalpricelbl);
            this.Order.Controls.Add(this.manylbl);
            this.Order.Controls.Add(this.Order_BTN);
            this.Order.Controls.Add(this.Totalticketlbl);
            this.Order.Controls.Add(this.Pricelbl);
            this.Order.Controls.Add(this.Datumlbl);
            this.Order.Controls.Add(this.Artiestlbl);
            this.Order.Location = new System.Drawing.Point(715, 41);
            this.Order.Name = "Order";
            this.Order.Size = new System.Drawing.Size(406, 428);
            this.Order.TabIndex = 4;
            this.Order.TabStop = false;
            this.Order.Text = "Bestellen";
            // 
            // Ticketslbl
            // 
            this.Ticketslbl.AutoSize = true;
            this.Ticketslbl.Location = new System.Drawing.Point(204, 289);
            this.Ticketslbl.Name = "Ticketslbl";
            this.Ticketslbl.Size = new System.Drawing.Size(38, 13);
            this.Ticketslbl.TabIndex = 13;
            this.Ticketslbl.Text = "tickets";
            // 
            // Countlbl
            // 
            this.Countlbl.AutoSize = true;
            this.Countlbl.Location = new System.Drawing.Point(151, 289);
            this.Countlbl.Name = "Countlbl";
            this.Countlbl.Size = new System.Drawing.Size(10, 13);
            this.Countlbl.TabIndex = 12;
            this.Countlbl.Text = ".";
            // 
            // Pricetotallbl
            // 
            this.Pricetotallbl.AutoSize = true;
            this.Pricetotallbl.Location = new System.Drawing.Point(157, 328);
            this.Pricetotallbl.Name = "Pricetotallbl";
            this.Pricetotallbl.Size = new System.Drawing.Size(13, 13);
            this.Pricetotallbl.TabIndex = 11;
            this.Pricetotallbl.Text = "0";
            // 
            // Pricenamelbl
            // 
            this.Pricenamelbl.AutoSize = true;
            this.Pricenamelbl.Location = new System.Drawing.Point(119, 106);
            this.Pricenamelbl.Name = "Pricenamelbl";
            this.Pricenamelbl.Size = new System.Drawing.Size(10, 13);
            this.Pricenamelbl.TabIndex = 10;
            this.Pricenamelbl.Text = "-";
            // 
            // Datenamelbl
            // 
            this.Datenamelbl.AutoSize = true;
            this.Datenamelbl.Location = new System.Drawing.Point(119, 73);
            this.Datenamelbl.Name = "Datenamelbl";
            this.Datenamelbl.Size = new System.Drawing.Size(10, 13);
            this.Datenamelbl.TabIndex = 9;
            this.Datenamelbl.Text = "-";
            // 
            // artistnameLbl
            // 
            this.artistnameLbl.AutoSize = true;
            this.artistnameLbl.Location = new System.Drawing.Point(119, 37);
            this.artistnameLbl.Name = "artistnameLbl";
            this.artistnameLbl.Size = new System.Drawing.Size(10, 13);
            this.artistnameLbl.TabIndex = 8;
            this.artistnameLbl.Text = "-";
            // 
            // totalpricelbl
            // 
            this.totalpricelbl.AutoSize = true;
            this.totalpricelbl.Location = new System.Drawing.Point(75, 328);
            this.totalpricelbl.Name = "totalpricelbl";
            this.totalpricelbl.Size = new System.Drawing.Size(61, 13);
            this.totalpricelbl.TabIndex = 7;
            this.totalpricelbl.Text = "Total Price:";
            // 
            // manylbl
            // 
            this.manylbl.AutoSize = true;
            this.manylbl.Location = new System.Drawing.Point(75, 289);
            this.manylbl.Name = "manylbl";
            this.manylbl.Size = new System.Drawing.Size(53, 13);
            this.manylbl.TabIndex = 6;
            this.manylbl.Text = "There are";
            // 
            // Order_BTN
            // 
            this.Order_BTN.Location = new System.Drawing.Point(119, 230);
            this.Order_BTN.Name = "Order_BTN";
            this.Order_BTN.Size = new System.Drawing.Size(179, 23);
            this.Order_BTN.TabIndex = 5;
            this.Order_BTN.Text = "Order";
            this.Order_BTN.UseVisualStyleBackColor = true;
            this.Order_BTN.Click += new System.EventHandler(this.Order_BTN_Click);
            // 
            // Totalticketlbl
            // 
            this.Totalticketlbl.AutoSize = true;
            this.Totalticketlbl.Location = new System.Drawing.Point(20, 154);
            this.Totalticketlbl.Name = "Totalticketlbl";
            this.Totalticketlbl.Size = new System.Drawing.Size(68, 13);
            this.Totalticketlbl.TabIndex = 3;
            this.Totalticketlbl.Text = "Total tickets:";
            // 
            // Pricelbl
            // 
            this.Pricelbl.AutoSize = true;
            this.Pricelbl.Location = new System.Drawing.Point(20, 106);
            this.Pricelbl.Name = "Pricelbl";
            this.Pricelbl.Size = new System.Drawing.Size(31, 13);
            this.Pricelbl.TabIndex = 2;
            this.Pricelbl.Text = "Price";
            // 
            // Datumlbl
            // 
            this.Datumlbl.AutoSize = true;
            this.Datumlbl.Location = new System.Drawing.Point(20, 73);
            this.Datumlbl.Name = "Datumlbl";
            this.Datumlbl.Size = new System.Drawing.Size(30, 13);
            this.Datumlbl.TabIndex = 1;
            this.Datumlbl.Text = "Date";
            // 
            // Artiestlbl
            // 
            this.Artiestlbl.AutoSize = true;
            this.Artiestlbl.Location = new System.Drawing.Point(17, 37);
            this.Artiestlbl.Name = "Artiestlbl";
            this.Artiestlbl.Size = new System.Drawing.Size(30, 13);
            this.Artiestlbl.TabIndex = 0;
            this.Artiestlbl.Text = "Artist";
            // 
            // NewListofConcerts
            // 
            this.NewListofConcerts.Location = new System.Drawing.Point(12, 41);
            this.NewListofConcerts.Name = "NewListofConcerts";
            this.NewListofConcerts.Size = new System.Drawing.Size(121, 39);
            this.NewListofConcerts.TabIndex = 5;
            this.NewListofConcerts.Text = "New List of concerts";
            this.NewListofConcerts.UseVisualStyleBackColor = true;
            this.NewListofConcerts.Click += new System.EventHandler(this.NewListofConcerts_Click);
            // 
            // SortArtistBtn
            // 
            this.SortArtistBtn.Location = new System.Drawing.Point(170, 41);
            this.SortArtistBtn.Name = "SortArtistBtn";
            this.SortArtistBtn.Size = new System.Drawing.Size(154, 39);
            this.SortArtistBtn.TabIndex = 6;
            this.SortArtistBtn.Text = "Sort on Artist";
            this.SortArtistBtn.UseVisualStyleBackColor = true;
            this.SortArtistBtn.Click += new System.EventHandler(this.SortArtistBtn_Click);
            // 
            // SortPriceBtn
            // 
            this.SortPriceBtn.Location = new System.Drawing.Point(346, 41);
            this.SortPriceBtn.Name = "SortPriceBtn";
            this.SortPriceBtn.Size = new System.Drawing.Size(154, 39);
            this.SortPriceBtn.TabIndex = 7;
            this.SortPriceBtn.Text = "Sort on Price";
            this.SortPriceBtn.UseVisualStyleBackColor = true;
            this.SortPriceBtn.Click += new System.EventHandler(this.SortPriceBtn_Click);
            // 
            // SortDateBtn
            // 
            this.SortDateBtn.Location = new System.Drawing.Point(517, 41);
            this.SortDateBtn.Name = "SortDateBtn";
            this.SortDateBtn.Size = new System.Drawing.Size(154, 39);
            this.SortDateBtn.TabIndex = 8;
            this.SortDateBtn.Text = "Sort on Date";
            this.SortDateBtn.UseVisualStyleBackColor = true;
            this.SortDateBtn.Click += new System.EventHandler(this.SortDateBtn_Click);
            // 
            // numberoftickets
            // 
            this.numberoftickets.Location = new System.Drawing.Point(131, 154);
            this.numberoftickets.Name = "numberoftickets";
            this.numberoftickets.Size = new System.Drawing.Size(120, 20);
            this.numberoftickets.TabIndex = 14;
            // 
            // Mainview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 522);
            this.Controls.Add(this.SortDateBtn);
            this.Controls.Add(this.SortPriceBtn);
            this.Controls.Add(this.SortArtistBtn);
            this.Controls.Add(this.NewListofConcerts);
            this.Controls.Add(this.Order);
            this.Controls.Add(this.ArtistLBox);
            this.Name = "Mainview";
            this.Text = "Order ConcertTickets";
            this.Order.ResumeLayout(false);
            this.Order.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberoftickets)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox ArtistLBox;
        private System.Windows.Forms.GroupBox Order;
        private System.Windows.Forms.Label Pricetotallbl;
        private System.Windows.Forms.Label Pricenamelbl;
        private System.Windows.Forms.Label Datenamelbl;
        private System.Windows.Forms.Label artistnameLbl;
        private System.Windows.Forms.Label totalpricelbl;
        private System.Windows.Forms.Label manylbl;
        private System.Windows.Forms.Button Order_BTN;
        private System.Windows.Forms.Label Totalticketlbl;
        private System.Windows.Forms.Label Pricelbl;
        private System.Windows.Forms.Label Datumlbl;
        private System.Windows.Forms.Label Artiestlbl;
        private System.Windows.Forms.Label Ticketslbl;
        private System.Windows.Forms.Label Countlbl;
        private System.Windows.Forms.Button NewListofConcerts;
        private System.Windows.Forms.Button SortArtistBtn;
        private System.Windows.Forms.Button SortPriceBtn;
        private System.Windows.Forms.Button SortDateBtn;
        private System.Windows.Forms.NumericUpDown numberoftickets;
    }
}

