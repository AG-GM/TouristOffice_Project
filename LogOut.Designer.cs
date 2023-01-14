namespace TouristOffice
{
    partial class frmLogOut
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
            this.pblLogOut = new System.Windows.Forms.Panel();
            this.btnNo = new System.Windows.Forms.Button();
            this.btnYes = new System.Windows.Forms.Button();
            this.lblMessege2 = new System.Windows.Forms.Label();
            this.lblMessege1 = new System.Windows.Forms.Label();
            this.pblLogOut.SuspendLayout();
            this.SuspendLayout();
            // 
            // pblLogOut
            // 
            this.pblLogOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pblLogOut.Controls.Add(this.btnNo);
            this.pblLogOut.Controls.Add(this.btnYes);
            this.pblLogOut.Controls.Add(this.lblMessege2);
            this.pblLogOut.Controls.Add(this.lblMessege1);
            this.pblLogOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pblLogOut.Location = new System.Drawing.Point(0, 0);
            this.pblLogOut.Name = "pblLogOut";
            this.pblLogOut.Size = new System.Drawing.Size(311, 187);
            this.pblLogOut.TabIndex = 0;
            // 
            // btnNo
            // 
            this.btnNo.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNo.ForeColor = System.Drawing.Color.White;
            this.btnNo.Location = new System.Drawing.Point(179, 113);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(75, 45);
            this.btnNo.TabIndex = 4;
            this.btnNo.Text = "No";
            this.btnNo.UseVisualStyleBackColor = false;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // btnYes
            // 
            this.btnYes.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnYes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnYes.ForeColor = System.Drawing.Color.Red;
            this.btnYes.Location = new System.Drawing.Point(44, 113);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(79, 45);
            this.btnYes.TabIndex = 5;
            this.btnYes.Text = "YES, log me out";
            this.btnYes.UseVisualStyleBackColor = false;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // lblMessege2
            // 
            this.lblMessege2.AutoSize = true;
            this.lblMessege2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMessege2.Location = new System.Drawing.Point(72, 46);
            this.lblMessege2.Name = "lblMessege2";
            this.lblMessege2.Size = new System.Drawing.Size(145, 20);
            this.lblMessege2.TabIndex = 2;
            this.lblMessege2.Text = " OF THIS ACCOUNT";
            // 
            // lblMessege1
            // 
            this.lblMessege1.AutoSize = true;
            this.lblMessege1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMessege1.Location = new System.Drawing.Point(10, 17);
            this.lblMessege1.Name = "lblMessege1";
            this.lblMessege1.Size = new System.Drawing.Size(291, 20);
            this.lblMessege1.TabIndex = 3;
            this.lblMessege1.Text = "ARE YOU SURE YOU WANT TO LOG OUT";
            // 
            // frmLogOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(311, 187);
            this.Controls.Add(this.pblLogOut);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogOut";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.pblLogOut.ResumeLayout(false);
            this.pblLogOut.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pblLogOut;
        private Button btnNo;
        private Button btnYes;
        private Label lblMessege2;
        private Label lblMessege1;
    }
}