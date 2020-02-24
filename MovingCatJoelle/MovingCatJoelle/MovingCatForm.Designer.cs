namespace MovingCatJoelle
{
    partial class frmMovingCat
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
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mniExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCat = new System.Windows.Forms.ToolStripMenuItem();
            this.mniCat1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mniCat2 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDog = new System.Windows.Forms.ToolStripMenuItem();
            this.mniDog1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mniDog2 = new System.Windows.Forms.ToolStripMenuItem();
            this.picCat = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCat)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuCat,
            this.mnuDog});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "File";
            // 
            // mniExit
            // 
            this.mniExit.Name = "mniExit";
            this.mniExit.Size = new System.Drawing.Size(180, 22);
            this.mniExit.Text = "Exit";
            this.mniExit.Click += new System.EventHandler(this.MniExit_Click);
            // 
            // mnuCat
            // 
            this.mnuCat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniCat1,
            this.mniCat2});
            this.mnuCat.Name = "mnuCat";
            this.mnuCat.Size = new System.Drawing.Size(37, 20);
            this.mnuCat.Text = "Cat";
            // 
            // mniCat1
            // 
            this.mniCat1.Name = "mniCat1";
            this.mniCat1.Size = new System.Drawing.Size(98, 22);
            this.mniCat1.Text = "Cat1";
            this.mniCat1.Click += new System.EventHandler(this.MniCat1_Click);
            // 
            // mniCat2
            // 
            this.mniCat2.Name = "mniCat2";
            this.mniCat2.Size = new System.Drawing.Size(98, 22);
            this.mniCat2.Text = "Cat2";
            this.mniCat2.Click += new System.EventHandler(this.MniCat2_Click);
            // 
            // mnuDog
            // 
            this.mnuDog.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniDog1,
            this.mniDog2});
            this.mnuDog.Name = "mnuDog";
            this.mnuDog.Size = new System.Drawing.Size(41, 20);
            this.mnuDog.Text = "Dog";
            this.mnuDog.Click += new System.EventHandler(this.MnuCars_Click);
            // 
            // mniDog1
            // 
            this.mniDog1.Name = "mniDog1";
            this.mniDog1.Size = new System.Drawing.Size(180, 22);
            this.mniDog1.Text = "Dog1";
            this.mniDog1.Click += new System.EventHandler(this.LamborToolStripMenuItem_Click);
            // 
            // mniDog2
            // 
            this.mniDog2.Name = "mniDog2";
            this.mniDog2.Size = new System.Drawing.Size(180, 22);
            this.mniDog2.Text = "Dog2";
            this.mniDog2.Click += new System.EventHandler(this.MniDog2_Click);
            // 
            // picCat
            // 
            this.picCat.Image = global::MovingCatJoelle.Properties.Resources.Dog2;
            this.picCat.Location = new System.Drawing.Point(260, 108);
            this.picCat.Name = "picCat";
            this.picCat.Size = new System.Drawing.Size(225, 238);
            this.picCat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCat.TabIndex = 0;
            this.picCat.TabStop = false;
            // 
            // frmMovingCat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picCat);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMovingCat";
            this.Text = "Moving Cat  by: Joelle Ishimwe";
            this.Load += new System.EventHandler(this.MovingCatForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picCat;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mniExit;
        private System.Windows.Forms.ToolStripMenuItem mnuCat;
        private System.Windows.Forms.ToolStripMenuItem mniCat1;
        private System.Windows.Forms.ToolStripMenuItem mniCat2;
        private System.Windows.Forms.ToolStripMenuItem mnuDog;
        private System.Windows.Forms.ToolStripMenuItem mniDog1;
        private System.Windows.Forms.ToolStripMenuItem mniDog2;
    }
}

