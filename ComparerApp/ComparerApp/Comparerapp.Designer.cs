namespace ComparerApp
{
    partial class Concertapp
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
            this.ArtistsortBtn = new System.Windows.Forms.Button();
            this.DateSortBtn = new System.Windows.Forms.Button();
            this.PriceSortBtn = new System.Windows.Forms.Button();
            this.ArtistLBox = new System.Windows.Forms.ListBox();
            this.Order = new System.Windows.Forms.GroupBox();
            this.Artiestlbl = new System.Windows.Forms.Label();
            this.Datumlbl = new System.Windows.Forms.Label();
            this.Pricelbl = new System.Windows.Forms.Label();
            this.Totalticketlbl = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.manylbl = new System.Windows.Forms.Label();
            this.totalpricelbl = new System.Windows.Forms.Label();
            this.artistnameLbl = new System.Windows.Forms.Label();
            this.Datenamelbl = new System.Windows.Forms.Label();
            this.Pricenamelbl = new System.Windows.Forms.Label();
            this.Pricetotallbl = new System.Windows.Forms.Label();
            this.Countlbl = new System.Windows.Forms.Label();
            this.Ticketslbl = new System.Windows.Forms.Label();
            this.Order.SuspendLayout();
            this.SuspendLayout();
            // 
            // ArtistsortBtn
            // 
            this.ArtistsortBtn.Location = new System.Drawing.Point(54, 41);
            this.ArtistsortBtn.Name = "ArtistsortBtn";
            this.ArtistsortBtn.Size = new System.Drawing.Size(164, 39);
            this.ArtistsortBtn.TabIndex = 0;
            this.ArtistsortBtn.Text = "Sort on Artist";
            this.ArtistsortBtn.UseVisualStyleBackColor = true;
            // 
            // DateSortBtn
            // 
            this.DateSortBtn.Location = new System.Drawing.Point(239, 41);
            this.DateSortBtn.Name = "DateSortBtn";
            this.DateSortBtn.Size = new System.Drawing.Size(164, 39);
            this.DateSortBtn.TabIndex = 1;
            this.DateSortBtn.Text = "Sort on Date";
            this.DateSortBtn.UseVisualStyleBackColor = true;
            // 
            // PriceSortBtn
            // 
            this.PriceSortBtn.Location = new System.Drawing.Point(425, 41);
            this.PriceSortBtn.Name = "PriceSortBtn";
            this.PriceSortBtn.Size = new System.Drawing.Size(164, 39);
            this.PriceSortBtn.TabIndex = 2;
            this.PriceSortBtn.Text = "Sort on Price";
            this.PriceSortBtn.UseVisualStyleBackColor = true;
            // 
            // ArtistLBox
            // 
            this.ArtistLBox.FormattingEnabled = true;
            this.ArtistLBox.Location = new System.Drawing.Point(54, 114);
            this.ArtistLBox.Name = "ArtistLBox";
            this.ArtistLBox.Size = new System.Drawing.Size(549, 355);
            this.ArtistLBox.TabIndex = 3;
            // 
            // Order
            // 
            this.Order.Controls.Add(this.Ticketslbl);
            this.Order.Controls.Add(this.Countlbl);
            this.Order.Controls.Add(this.Pricetotallbl);
            this.Order.Controls.Add(this.Pricenamelbl);
            this.Order.Controls.Add(this.Datenamelbl);
            this.Order.Controls.Add(this.artistnameLbl);
            this.Order.Controls.Add(this.totalpricelbl);
            this.Order.Controls.Add(this.manylbl);
            this.Order.Controls.Add(this.button1);
            this.Order.Controls.Add(this.textBox1);
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
            // Artiestlbl
            // 
            this.Artiestlbl.AutoSize = true;
            this.Artiestlbl.Location = new System.Drawing.Point(17, 37);
            this.Artiestlbl.Name = "Artiestlbl";
            this.Artiestlbl.Size = new System.Drawing.Size(30, 13);
            this.Artiestlbl.TabIndex = 0;
            this.Artiestlbl.Text = "Artist";
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
            // Pricelbl
            // 
            this.Pricelbl.AutoSize = true;
            this.Pricelbl.Location = new System.Drawing.Point(20, 106);
            this.Pricelbl.Name = "Pricelbl";
            this.Pricelbl.Size = new System.Drawing.Size(31, 13);
            this.Pricelbl.TabIndex = 2;
            this.Pricelbl.Text = "Price";
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(119, 154);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(119, 230);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
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
            // totalpricelbl
            // 
            this.totalpricelbl.AutoSize = true;
            this.totalpricelbl.Location = new System.Drawing.Point(75, 328);
            this.totalpricelbl.Name = "totalpricelbl";
            this.totalpricelbl.Size = new System.Drawing.Size(61, 13);
            this.totalpricelbl.TabIndex = 7;
            this.totalpricelbl.Text = "Total Price:";
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
            // Datenamelbl
            // 
            this.Datenamelbl.AutoSize = true;
            this.Datenamelbl.Location = new System.Drawing.Point(119, 73);
            this.Datenamelbl.Name = "Datenamelbl";
            this.Datenamelbl.Size = new System.Drawing.Size(10, 13);
            this.Datenamelbl.TabIndex = 9;
            this.Datenamelbl.Text = "-";
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
            // Pricetotallbl
            // 
            this.Pricetotallbl.AutoSize = true;
            this.Pricetotallbl.Location = new System.Drawing.Point(157, 328);
            this.Pricetotallbl.Name = "Pricetotallbl";
            this.Pricetotallbl.Size = new System.Drawing.Size(13, 13);
            this.Pricetotallbl.TabIndex = 11;
            this.Pricetotallbl.Text = "0";
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
            // Ticketslbl
            // 
            this.Ticketslbl.AutoSize = true;
            this.Ticketslbl.Location = new System.Drawing.Point(204, 289);
            this.Ticketslbl.Name = "Ticketslbl";
            this.Ticketslbl.Size = new System.Drawing.Size(38, 13);
            this.Ticketslbl.TabIndex = 13;
            this.Ticketslbl.Text = "tickets";
            // 
            // Concertapp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 522);
            this.Controls.Add(this.Order);
            this.Controls.Add(this.ArtistLBox);
            this.Controls.Add(this.PriceSortBtn);
            this.Controls.Add(this.DateSortBtn);
            this.Controls.Add(this.ArtistsortBtn);
            this.Name = "Concertapp";
            this.Text = "Order ConcertTickets";
            this.Order.ResumeLayout(false);
            this.Order.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ArtistsortBtn;
        private System.Windows.Forms.Button DateSortBtn;
        private System.Windows.Forms.Button PriceSortBtn;
        private System.Windows.Forms.ListBox ArtistLBox;
        private System.Windows.Forms.GroupBox Order;
        private System.Windows.Forms.Label Pricetotallbl;
        private System.Windows.Forms.Label Pricenamelbl;
        private System.Windows.Forms.Label Datenamelbl;
        private System.Windows.Forms.Label artistnameLbl;
        private System.Windows.Forms.Label totalpricelbl;
        private System.Windows.Forms.Label manylbl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Totalticketlbl;
        private System.Windows.Forms.Label Pricelbl;
        private System.Windows.Forms.Label Datumlbl;
        private System.Windows.Forms.Label Artiestlbl;
        private System.Windows.Forms.Label Ticketslbl;
        private System.Windows.Forms.Label Countlbl;
    }
}

