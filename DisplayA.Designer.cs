namespace TouristOffice
{
    partial class frmDisplayA
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
            this.btnRoyalJordanian = new System.Windows.Forms.Button();
            this.btnAirCairo = new System.Windows.Forms.Button();
            this.btnTurkishAirlines = new System.Windows.Forms.Button();
            this.btnFlyEmirates = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRoyalJordanian
            // 
            this.btnRoyalJordanian.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(76)))), ((int)(((byte)(108)))));
            this.btnRoyalJordanian.BackgroundImage = global::TouristOffice.Properties.Resources.RoyalJordanian;
            this.btnRoyalJordanian.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRoyalJordanian.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRoyalJordanian.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRoyalJordanian.ForeColor = System.Drawing.Color.White;
            this.btnRoyalJordanian.Location = new System.Drawing.Point(0, 0);
            this.btnRoyalJordanian.Name = "btnRoyalJordanian";
            this.btnRoyalJordanian.Size = new System.Drawing.Size(174, 133);
            this.btnRoyalJordanian.TabIndex = 0;
            this.btnRoyalJordanian.UseVisualStyleBackColor = false;
            this.btnRoyalJordanian.Click += new System.EventHandler(this.btnRoyalJordanian_Click);
            // 
            // btnAirCairo
            // 
            this.btnAirCairo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(76)))), ((int)(((byte)(108)))));
            this.btnAirCairo.BackgroundImage = global::TouristOffice.Properties.Resources.Air_Cairo;
            this.btnAirCairo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAirCairo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAirCairo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAirCairo.ForeColor = System.Drawing.Color.White;
            this.btnAirCairo.Location = new System.Drawing.Point(0, 133);
            this.btnAirCairo.Name = "btnAirCairo";
            this.btnAirCairo.Size = new System.Drawing.Size(174, 133);
            this.btnAirCairo.TabIndex = 0;
            this.btnAirCairo.UseVisualStyleBackColor = false;
            this.btnAirCairo.Click += new System.EventHandler(this.btnAirCairo_Click);
            // 
            // btnTurkishAirlines
            // 
            this.btnTurkishAirlines.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(76)))), ((int)(((byte)(108)))));
            this.btnTurkishAirlines.BackgroundImage = global::TouristOffice.Properties.Resources.Turkish_Airlines;
            this.btnTurkishAirlines.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTurkishAirlines.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTurkishAirlines.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTurkishAirlines.ForeColor = System.Drawing.Color.White;
            this.btnTurkishAirlines.Location = new System.Drawing.Point(0, 266);
            this.btnTurkishAirlines.Name = "btnTurkishAirlines";
            this.btnTurkishAirlines.Size = new System.Drawing.Size(174, 133);
            this.btnTurkishAirlines.TabIndex = 0;
            this.btnTurkishAirlines.UseVisualStyleBackColor = false;
            this.btnTurkishAirlines.Click += new System.EventHandler(this.btnTurkishAirlines_Click);
            // 
            // btnFlyEmirates
            // 
            this.btnFlyEmirates.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(76)))), ((int)(((byte)(108)))));
            this.btnFlyEmirates.BackgroundImage = global::TouristOffice.Properties.Resources.FlyEmirates;
            this.btnFlyEmirates.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFlyEmirates.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFlyEmirates.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFlyEmirates.ForeColor = System.Drawing.Color.White;
            this.btnFlyEmirates.Location = new System.Drawing.Point(0, 399);
            this.btnFlyEmirates.Name = "btnFlyEmirates";
            this.btnFlyEmirates.Size = new System.Drawing.Size(174, 133);
            this.btnFlyEmirates.TabIndex = 0;
            this.btnFlyEmirates.UseVisualStyleBackColor = false;
            this.btnFlyEmirates.Click += new System.EventHandler(this.btnFlyEmirates_Click);
            // 
            // frmDisplayA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(111)))), ((int)(((byte)(147)))));
            this.ClientSize = new System.Drawing.Size(174, 533);
            this.Controls.Add(this.btnFlyEmirates);
            this.Controls.Add(this.btnTurkishAirlines);
            this.Controls.Add(this.btnAirCairo);
            this.Controls.Add(this.btnRoyalJordanian);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDisplayA";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnRoyalJordanian;
        private Button btnAirCairo;
        private Button btnTurkishAirlines;
        private Button btnFlyEmirates;
    }
}