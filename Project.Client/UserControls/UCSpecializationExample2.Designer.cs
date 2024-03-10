using System.Windows.Forms;

namespace Project.Client.UserControls
{
    partial class UCSpecializationExample2
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.animalSpeciesTree = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvAnimals = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnimals)).BeginInit();
            this.SuspendLayout();
            // 
            // animalSpeciesTree
            // 
            this.animalSpeciesTree.Location = new System.Drawing.Point(44, 96);
            this.animalSpeciesTree.Name = "animalSpeciesTree";
            this.animalSpeciesTree.Size = new System.Drawing.Size(329, 308);
            this.animalSpeciesTree.TabIndex = 0;
            this.animalSpeciesTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.animalSpeciesTree_AfterSelect);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ekskluzivna specijalizacija za prikaz zivotinjskih vrsta:";
            // 
            // dgvAnimals
            // 
            this.dgvAnimals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAnimals.Location = new System.Drawing.Point(469, 96);
            this.dgvAnimals.Name = "dgvAnimals";
            this.dgvAnimals.Size = new System.Drawing.Size(461, 308);
            this.dgvAnimals.TabIndex = 2;
            // 
            // UCSpecializationExample2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.dgvAnimals);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.animalSpeciesTree);
            this.Name = "UCSpecializationExample2";
            this.Size = new System.Drawing.Size(1000, 700);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnimals)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView animalSpeciesTree;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvAnimals;

        public TreeView AnimalSpeciesTree { get => animalSpeciesTree; set => animalSpeciesTree = value; }
        public Label Label1 { get => label1; set => label1 = value; }
        public DataGridView DgvAnimals { get => dgvAnimals; set => dgvAnimals = value; }
    }
}
