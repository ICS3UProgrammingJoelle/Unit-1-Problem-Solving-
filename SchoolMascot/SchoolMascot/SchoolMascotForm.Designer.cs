namespace SchoolMascot
{
    partial class SchoolMascotForm
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
            this.mmnSchoolMascots = new System.Windows.Forms.MenuStrip();
            this.grpSchools = new System.Windows.Forms.GroupBox();
            this.lblSchool = new System.Windows.Forms.Label();
            this.lblMascot = new System.Windows.Forms.Label();
            this.mmnSchools = new System.Windows.Forms.ToolStripMenuItem();
            this.immaculataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.motherTeresaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stPatrickToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stMatthewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mmnSchoolMascots.SuspendLayout();
            this.grpSchools.SuspendLayout();
            this.SuspendLayout();
            // 
            // mmnSchoolMascots
            // 
            this.mmnSchoolMascots.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mmnSchools});
            this.mmnSchoolMascots.Location = new System.Drawing.Point(0, 0);
            this.mmnSchoolMascots.Name = "mmnSchoolMascots";
            this.mmnSchoolMascots.Size = new System.Drawing.Size(800, 24);
            this.mmnSchoolMascots.TabIndex = 0;
            this.mmnSchoolMascots.Text = "School Mascots";
            // 
            // grpSchools
            // 
            this.grpSchools.Controls.Add(this.lblMascot);
            this.grpSchools.Controls.Add(this.lblSchool);
            this.grpSchools.Location = new System.Drawing.Point(176, 152);
            this.grpSchools.Name = "grpSchools";
            this.grpSchools.Size = new System.Drawing.Size(391, 192);
            this.grpSchools.TabIndex = 1;
            this.grpSchools.TabStop = false;
            // 
            // lblSchool
            // 
            this.lblSchool.AutoSize = true;
            this.lblSchool.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSchool.Location = new System.Drawing.Point(40, 40);
            this.lblSchool.Name = "lblSchool";
            this.lblSchool.Size = new System.Drawing.Size(155, 37);
            this.lblSchool.TabIndex = 2;
            this.lblSchool.Text = "Immaculata";
            this.lblSchool.Click += new System.EventHandler(this.LblSchool_Click);
            // 
            // lblMascot
            // 
            this.lblMascot.AutoSize = true;
            this.lblMascot.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMascot.Location = new System.Drawing.Point(125, 100);
            this.lblMascot.Name = "lblMascot";
            this.lblMascot.Size = new System.Drawing.Size(70, 25);
            this.lblMascot.TabIndex = 3;
            this.lblMascot.Text = "Saints";
            // 
            // mmnSchools
            // 
            this.mmnSchools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.immaculataToolStripMenuItem,
            this.motherTeresaToolStripMenuItem,
            this.stPatrickToolStripMenuItem,
            this.stMatthewToolStripMenuItem});
            this.mmnSchools.Name = "mmnSchools";
            this.mmnSchools.Size = new System.Drawing.Size(60, 20);
            this.mmnSchools.Text = "Schools";
            this.mmnSchools.Click += new System.EventHandler(this.ToolStripMenuItem1_Click);
            // 
            // immaculataToolStripMenuItem
            // 
            this.immaculataToolStripMenuItem.Name = "immaculataToolStripMenuItem";
            this.immaculataToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.immaculataToolStripMenuItem.Text = "Immaculata";
            this.immaculataToolStripMenuItem.Click += new System.EventHandler(this.ImmaculataToolStripMenuItem_Click);
            // 
            // motherTeresaToolStripMenuItem
            // 
            this.motherTeresaToolStripMenuItem.Name = "motherTeresaToolStripMenuItem";
            this.motherTeresaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.motherTeresaToolStripMenuItem.Text = "Mother Teresa";
            this.motherTeresaToolStripMenuItem.Click += new System.EventHandler(this.MotherTerresaToolStripMenuItem_Click);
            // 
            // stPatrickToolStripMenuItem
            // 
            this.stPatrickToolStripMenuItem.Name = "stPatrickToolStripMenuItem";
            this.stPatrickToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.stPatrickToolStripMenuItem.Text = "St. Patrick";
            this.stPatrickToolStripMenuItem.Click += new System.EventHandler(this.StPattricksToolStripMenuItem_Click);
            // 
            // stMatthewToolStripMenuItem
            // 
            this.stMatthewToolStripMenuItem.Name = "stMatthewToolStripMenuItem";
            this.stMatthewToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.stMatthewToolStripMenuItem.Text = "St. Matthew ";
            this.stMatthewToolStripMenuItem.Click += new System.EventHandler(this.StMatthiewsToolStripMenuItem_Click);
            // 
            // SchoolMascotForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpSchools);
            this.Controls.Add(this.mmnSchoolMascots);
            this.MainMenuStrip = this.mmnSchoolMascots;
            this.Name = "SchoolMascotForm";
            this.Text = "Form1";
            this.mmnSchoolMascots.ResumeLayout(false);
            this.mmnSchoolMascots.PerformLayout();
            this.grpSchools.ResumeLayout(false);
            this.grpSchools.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mmnSchoolMascots;
        private System.Windows.Forms.GroupBox grpSchools;
        private System.Windows.Forms.Label lblSchool;
        private System.Windows.Forms.ToolStripMenuItem mmnSchools;
        private System.Windows.Forms.Label lblMascot;
        private System.Windows.Forms.ToolStripMenuItem immaculataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem motherTeresaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stPatrickToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stMatthewToolStripMenuItem;
    }
}

