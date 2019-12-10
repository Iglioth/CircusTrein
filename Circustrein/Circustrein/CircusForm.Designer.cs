namespace Circustrein
{
    partial class FCircusTrein
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
            this.GBAddAnimal = new System.Windows.Forms.GroupBox();
            this.LAnimalType = new System.Windows.Forms.Label();
            this.LAnimalSize = new System.Windows.Forms.Label();
            this.CBanimalType = new System.Windows.Forms.ComboBox();
            this.CBAnimalSize = new System.Windows.Forms.ComboBox();
            this.BAddAnimal = new System.Windows.Forms.Button();
            this.LVanimals = new System.Windows.Forms.ListView();
            this.chFormaat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chEetSoort = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPoints = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BAlgorithm = new System.Windows.Forms.Button();
            this.TrainListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GBAddAnimal.SuspendLayout();
            this.SuspendLayout();
            // 
            // GBAddAnimal
            // 
            this.GBAddAnimal.Controls.Add(this.LAnimalType);
            this.GBAddAnimal.Controls.Add(this.LAnimalSize);
            this.GBAddAnimal.Controls.Add(this.CBanimalType);
            this.GBAddAnimal.Controls.Add(this.CBAnimalSize);
            this.GBAddAnimal.Controls.Add(this.BAddAnimal);
            this.GBAddAnimal.Location = new System.Drawing.Point(12, 12);
            this.GBAddAnimal.Name = "GBAddAnimal";
            this.GBAddAnimal.Size = new System.Drawing.Size(334, 191);
            this.GBAddAnimal.TabIndex = 8;
            this.GBAddAnimal.TabStop = false;
            this.GBAddAnimal.Text = "Add animal:";
            // 
            // LAnimalType
            // 
            this.LAnimalType.AutoSize = true;
            this.LAnimalType.Location = new System.Drawing.Point(34, 87);
            this.LAnimalType.Name = "LAnimalType";
            this.LAnimalType.Size = new System.Drawing.Size(68, 13);
            this.LAnimalType.TabIndex = 16;
            this.LAnimalType.Text = "Animal Type:";
            // 
            // LAnimalSize
            // 
            this.LAnimalSize.AutoSize = true;
            this.LAnimalSize.Location = new System.Drawing.Point(34, 49);
            this.LAnimalSize.Name = "LAnimalSize";
            this.LAnimalSize.Size = new System.Drawing.Size(64, 13);
            this.LAnimalSize.TabIndex = 15;
            this.LAnimalSize.Text = "Animal Size:";
            // 
            // CBanimalType
            // 
            this.CBanimalType.FormattingEnabled = true;
            this.CBanimalType.Location = new System.Drawing.Point(108, 84);
            this.CBanimalType.Name = "CBanimalType";
            this.CBanimalType.Size = new System.Drawing.Size(121, 21);
            this.CBanimalType.TabIndex = 14;
            // 
            // CBAnimalSize
            // 
            this.CBAnimalSize.FormattingEnabled = true;
            this.CBAnimalSize.Location = new System.Drawing.Point(108, 46);
            this.CBAnimalSize.Name = "CBAnimalSize";
            this.CBAnimalSize.Size = new System.Drawing.Size(121, 21);
            this.CBAnimalSize.TabIndex = 13;
            // 
            // BAddAnimal
            // 
            this.BAddAnimal.Location = new System.Drawing.Point(154, 124);
            this.BAddAnimal.Name = "BAddAnimal";
            this.BAddAnimal.Size = new System.Drawing.Size(75, 23);
            this.BAddAnimal.TabIndex = 12;
            this.BAddAnimal.Text = "Add";
            this.BAddAnimal.UseVisualStyleBackColor = true;
            this.BAddAnimal.Click += new System.EventHandler(this.BAddAnimal_Click);
            // 
            // LVanimals
            // 
            this.LVanimals.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chFormaat,
            this.chEetSoort,
            this.chPoints});
            this.LVanimals.HideSelection = false;
            this.LVanimals.Location = new System.Drawing.Point(12, 209);
            this.LVanimals.Name = "LVanimals";
            this.LVanimals.Size = new System.Drawing.Size(277, 182);
            this.LVanimals.TabIndex = 10;
            this.LVanimals.UseCompatibleStateImageBehavior = false;
            this.LVanimals.View = System.Windows.Forms.View.Details;
            // 
            // chFormaat
            // 
            this.chFormaat.Text = "Formaat";
            this.chFormaat.Width = 121;
            // 
            // chEetSoort
            // 
            this.chEetSoort.Text = "EetSoort";
            this.chEetSoort.Width = 92;
            // 
            // chPoints
            // 
            this.chPoints.Text = "Punten";
            // 
            // BAlgorithm
            // 
            this.BAlgorithm.Location = new System.Drawing.Point(214, 397);
            this.BAlgorithm.Name = "BAlgorithm";
            this.BAlgorithm.Size = new System.Drawing.Size(75, 23);
            this.BAlgorithm.TabIndex = 17;
            this.BAlgorithm.Text = "Put into train";
            this.BAlgorithm.UseVisualStyleBackColor = true;
            this.BAlgorithm.Click += new System.EventHandler(this.BAlgorithm_Click);
            // 
            // TrainListView
            // 
            this.TrainListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.TrainListView.HideSelection = false;
            this.TrainListView.Location = new System.Drawing.Point(12, 209);
            this.TrainListView.Name = "TrainListView";
            this.TrainListView.Size = new System.Drawing.Size(277, 182);
            this.TrainListView.TabIndex = 18;
            this.TrainListView.UseCompatibleStateImageBehavior = false;
            this.TrainListView.View = System.Windows.Forms.View.Details;
            this.TrainListView.Visible = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Wagon";
            this.columnHeader1.Width = 121;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Animal Count";
            this.columnHeader2.Width = 92;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Points";
            // 
            // FCircusTrein
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 450);
            this.Controls.Add(this.TrainListView);
            this.Controls.Add(this.BAlgorithm);
            this.Controls.Add(this.LVanimals);
            this.Controls.Add(this.GBAddAnimal);
            this.Name = "FCircusTrein";
            this.Text = "CircusTreinForm";
            this.GBAddAnimal.ResumeLayout(false);
            this.GBAddAnimal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox GBAddAnimal;
        private System.Windows.Forms.Button BAddAnimal;
        private System.Windows.Forms.Label LAnimalType;
        private System.Windows.Forms.Label LAnimalSize;
        private System.Windows.Forms.ComboBox CBanimalType;
        private System.Windows.Forms.ComboBox CBAnimalSize;
        private System.Windows.Forms.ListView LVanimals;
        private System.Windows.Forms.ColumnHeader chFormaat;
        private System.Windows.Forms.ColumnHeader chEetSoort;
        private System.Windows.Forms.ColumnHeader chPoints;
        private System.Windows.Forms.Button BAlgorithm;
        private System.Windows.Forms.ListView TrainListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}

