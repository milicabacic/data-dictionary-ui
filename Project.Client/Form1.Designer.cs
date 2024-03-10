namespace Project.Client
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.agregacijaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.example1AggregationToolStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.example2AggregationToolStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spezijalizacijaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.example1SpecializationToolStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.example2SpecializationToolStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.example1SetToolStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.example2SetToolStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregacijaToolStripMenuItem,
            this.spezijalizacijaToolStripMenuItem,
            this.setToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // agregacijaToolStripMenuItem
            // 
            this.agregacijaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.example1AggregationToolStripItem,
            this.example2AggregationToolStripItem});
            this.agregacijaToolStripMenuItem.Name = "agregacijaToolStripMenuItem";
            this.agregacijaToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.agregacijaToolStripMenuItem.Text = "Agregacija";
            // 
            // example1AggregationToolStripItem
            // 
            this.example1AggregationToolStripItem.Name = "example1AggregationToolStripItem";
            this.example1AggregationToolStripItem.Size = new System.Drawing.Size(180, 22);
            this.example1AggregationToolStripItem.Text = "Primer 1";
            this.example1AggregationToolStripItem.Click += new System.EventHandler(this.example1AggregationToolStripItem_Click);
            // 
            // example2AggregationToolStripItem
            // 
            this.example2AggregationToolStripItem.Name = "example2AggregationToolStripItem";
            this.example2AggregationToolStripItem.Size = new System.Drawing.Size(180, 22);
            this.example2AggregationToolStripItem.Text = "Primer 2";
            this.example2AggregationToolStripItem.Click += new System.EventHandler(this.example2AggregationToolStripItem_Click);
            // 
            // spezijalizacijaToolStripMenuItem
            // 
            this.spezijalizacijaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.example1SpecializationToolStripItem,
            this.example2SpecializationToolStripItem});
            this.spezijalizacijaToolStripMenuItem.Name = "spezijalizacijaToolStripMenuItem";
            this.spezijalizacijaToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.spezijalizacijaToolStripMenuItem.Text = "Spezijalizacija";
            // 
            // example1SpecializationToolStripItem
            // 
            this.example1SpecializationToolStripItem.Name = "example1SpecializationToolStripItem";
            this.example1SpecializationToolStripItem.Size = new System.Drawing.Size(180, 22);
            this.example1SpecializationToolStripItem.Text = "Primer 1";
            this.example1SpecializationToolStripItem.Click += new System.EventHandler(this.example1SpecializationToolStripItem_Click);
            // 
            // example2SpecializationToolStripItem
            // 
            this.example2SpecializationToolStripItem.Name = "example2SpecializationToolStripItem";
            this.example2SpecializationToolStripItem.Size = new System.Drawing.Size(180, 22);
            this.example2SpecializationToolStripItem.Text = "Primer 2";
            this.example2SpecializationToolStripItem.Click += new System.EventHandler(this.example2SpecializationToolStripItem_Click);
            // 
            // setToolStripMenuItem
            // 
            this.setToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.example1SetToolStripItem,
            this.example2SetToolStripItem});
            this.setToolStripMenuItem.Name = "setToolStripMenuItem";
            this.setToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.setToolStripMenuItem.Text = "Set ";
            // 
            // example1SetToolStripItem
            // 
            this.example1SetToolStripItem.Name = "example1SetToolStripItem";
            this.example1SetToolStripItem.Size = new System.Drawing.Size(180, 22);
            this.example1SetToolStripItem.Text = "Primer 1";
            this.example1SetToolStripItem.Click += new System.EventHandler(this.example1SetToolStripItem_Click);
            // 
            // example2SetToolStripItem
            // 
            this.example2SetToolStripItem.Name = "example2SetToolStripItem";
            this.example2SetToolStripItem.Size = new System.Drawing.Size(180, 22);
            this.example2SetToolStripItem.Text = "Primer 2";
            this.example2SetToolStripItem.Click += new System.EventHandler(this.example2SetToolStripItem_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 637);
            this.panel1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Vizuelna reprezentacija recnika podataka";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem agregacijaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem example1AggregationToolStripItem;
        private System.Windows.Forms.ToolStripMenuItem example2AggregationToolStripItem;
        private System.Windows.Forms.ToolStripMenuItem spezijalizacijaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem example1SpecializationToolStripItem;
        private System.Windows.Forms.ToolStripMenuItem example2SpecializationToolStripItem;
        private System.Windows.Forms.ToolStripMenuItem setToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem example1SetToolStripItem;
        private System.Windows.Forms.ToolStripMenuItem example2SetToolStripItem;
        private System.Windows.Forms.Panel panel1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

