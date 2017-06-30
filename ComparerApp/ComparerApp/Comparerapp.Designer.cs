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
            this.ArtiestSorteerBtn = new System.Windows.Forms.Button();
            this.DatumSorteerBtn = new System.Windows.Forms.Button();
            this.PrijsSorteerBtn = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Bestellen = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // ArtiestSorteerBtn
            // 
            this.ArtiestSorteerBtn.Location = new System.Drawing.Point(54, 41);
            this.ArtiestSorteerBtn.Name = "ArtiestSorteerBtn";
            this.ArtiestSorteerBtn.Size = new System.Drawing.Size(164, 39);
            this.ArtiestSorteerBtn.TabIndex = 0;
            this.ArtiestSorteerBtn.Text = "Sorteer op Artiest";
            this.ArtiestSorteerBtn.UseVisualStyleBackColor = true;
            // 
            // DatumSorteerBtn
            // 
            this.DatumSorteerBtn.Location = new System.Drawing.Point(239, 41);
            this.DatumSorteerBtn.Name = "DatumSorteerBtn";
            this.DatumSorteerBtn.Size = new System.Drawing.Size(164, 39);
            this.DatumSorteerBtn.TabIndex = 1;
            this.DatumSorteerBtn.Text = "Sorteer op Datum";
            this.DatumSorteerBtn.UseVisualStyleBackColor = true;
            // 
            // PrijsSorteerBtn
            // 
            this.PrijsSorteerBtn.Location = new System.Drawing.Point(425, 41);
            this.PrijsSorteerBtn.Name = "PrijsSorteerBtn";
            this.PrijsSorteerBtn.Size = new System.Drawing.Size(164, 39);
            this.PrijsSorteerBtn.TabIndex = 2;
            this.PrijsSorteerBtn.Text = "Sorteer op Prijs";
            this.PrijsSorteerBtn.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(54, 114);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(549, 355);
            this.listBox1.TabIndex = 3;
            // 
            // Bestellen
            // 
            this.Bestellen.Location = new System.Drawing.Point(715, 41);
            this.Bestellen.Name = "Bestellen";
            this.Bestellen.Size = new System.Drawing.Size(406, 428);
            this.Bestellen.TabIndex = 4;
            this.Bestellen.TabStop = false;
            this.Bestellen.Text = "Bestellen";
            // 
            // Concertapp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 522);
            this.Controls.Add(this.Bestellen);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.PrijsSorteerBtn);
            this.Controls.Add(this.DatumSorteerBtn);
            this.Controls.Add(this.ArtiestSorteerBtn);
            this.Name = "Concertapp";
            this.Text = "Concertkaarten Bestellen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ArtiestSorteerBtn;
        private System.Windows.Forms.Button DatumSorteerBtn;
        private System.Windows.Forms.Button PrijsSorteerBtn;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox Bestellen;
    }
}

