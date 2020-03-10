namespace PizzaCostJoelle
{
    partial class frmPizzaCost
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
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblDiameter = new System.Windows.Forms.Label();
            this.lblStateCost = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.txtDiameter = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(315, 174);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(150, 42);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // lblDiameter
            // 
            this.lblDiameter.AutoSize = true;
            this.lblDiameter.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiameter.Location = new System.Drawing.Point(29, 97);
            this.lblDiameter.Name = "lblDiameter";
            this.lblDiameter.Size = new System.Drawing.Size(436, 27);
            this.lblDiameter.TabIndex = 1;
            this.lblDiameter.Text = "Enter the diameter of the pizza (in inches): ";
            // 
            // lblStateCost
            // 
            this.lblStateCost.AutoSize = true;
            this.lblStateCost.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStateCost.Location = new System.Drawing.Point(103, 316);
            this.lblStateCost.Name = "lblStateCost";
            this.lblStateCost.Size = new System.Drawing.Size(226, 21);
            this.lblStateCost.TabIndex = 2;
            this.lblStateCost.Text = "The cost (including taxes) is:";
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCost.Location = new System.Drawing.Point(472, 310);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(30, 26);
            this.lblCost.TabIndex = 3;
            this.lblCost.Text = "hi";
            // 
            // txtDiameter
            // 
            this.txtDiameter.Location = new System.Drawing.Point(539, 103);
            this.txtDiameter.Name = "txtDiameter";
            this.txtDiameter.Size = new System.Drawing.Size(100, 20);
            this.txtDiameter.TabIndex = 4;
            // 
            // frmPizzaCost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtDiameter);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.lblStateCost);
            this.Controls.Add(this.lblDiameter);
            this.Controls.Add(this.btnCalculate);
            this.Name = "frmPizzaCost";
            this.Text = "PizzaCost   by: Joelle Ishimwe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblDiameter;
        private System.Windows.Forms.Label lblStateCost;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.TextBox txtDiameter;
    }
}

