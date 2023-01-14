namespace TouristOffice
{
    partial class frmHomePage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tblUserTable = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picPfp = new System.Windows.Forms.PictureBox();
            this.pnlDisplay = new System.Windows.Forms.Panel();
            this.pnlUser = new System.Windows.Forms.Panel();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnAirLines = new System.Windows.Forms.Button();
            this.btnCountries = new System.Windows.Forms.Button();
            this.lblUserName = new System.Windows.Forms.Label();
            this.tblMenuBar = new System.Windows.Forms.TableLayoutPanel();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.picMax = new System.Windows.Forms.PictureBox();
            this.picMin = new System.Windows.Forms.PictureBox();
            this.pnlNothing = new System.Windows.Forms.Panel();
            this.pnlBackGroundDisplay = new System.Windows.Forms.Panel();
            this.btnCloseAdmin = new System.Windows.Forms.Button();
            this.lblEmptyAirLine = new System.Windows.Forms.Label();
            this.lblEmptyChild = new System.Windows.Forms.Label();
            this.lblEmptyInfant = new System.Windows.Forms.Label();
            this.lblEmptyClass = new System.Windows.Forms.Label();
            this.lblEmptyAdult = new System.Windows.Forms.Label();
            this.lblEmptyCities = new System.Windows.Forms.Label();
            this.dgvAdminPanel = new System.Windows.Forms.DataGridView();
            this.btnAdminPanel = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.pnlAirLines = new System.Windows.Forms.Panel();
            this.cbxCities = new System.Windows.Forms.ComboBox();
            this.cbxChild = new System.Windows.Forms.ComboBox();
            this.cbxInfant = new System.Windows.Forms.ComboBox();
            this.cbxAirLines = new System.Windows.Forms.ComboBox();
            this.lblAdult = new System.Windows.Forms.Label();
            this.lblCities = new System.Windows.Forms.Label();
            this.lblChild = new System.Windows.Forms.Label();
            this.lblAirLine = new System.Windows.Forms.Label();
            this.cbxAdult = new System.Windows.Forms.ComboBox();
            this.lblInfant = new System.Windows.Forms.Label();
            this.lblClass = new System.Windows.Forms.Label();
            this.cbxClass = new System.Windows.Forms.ComboBox();
            this.tblUserTable.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPfp)).BeginInit();
            this.pnlUser.SuspendLayout();
            this.tblMenuBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMin)).BeginInit();
            this.pnlNothing.SuspendLayout();
            this.pnlBackGroundDisplay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminPanel)).BeginInit();
            this.SuspendLayout();
            // 
            // tblUserTable
            // 
            this.tblUserTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(135)))));
            this.tblUserTable.ColumnCount = 1;
            this.tblUserTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblUserTable.Controls.Add(this.panel1, 0, 0);
            this.tblUserTable.Controls.Add(this.pnlDisplay, 0, 3);
            this.tblUserTable.Controls.Add(this.pnlUser, 0, 2);
            this.tblUserTable.Controls.Add(this.lblUserName, 0, 1);
            this.tblUserTable.Dock = System.Windows.Forms.DockStyle.Left;
            this.tblUserTable.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tblUserTable.Location = new System.Drawing.Point(0, 0);
            this.tblUserTable.Name = "tblUserTable";
            this.tblUserTable.RowCount = 4;
            this.tblUserTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tblUserTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblUserTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tblUserTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblUserTable.Size = new System.Drawing.Size(274, 450);
            this.tblUserTable.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.picPfp);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(268, 94);
            this.panel1.TabIndex = 7;
            // 
            // picPfp
            // 
            this.picPfp.Image = global::TouristOffice.Properties.Resources.guest;
            this.picPfp.Location = new System.Drawing.Point(79, 9);
            this.picPfp.Name = "picPfp";
            this.picPfp.Size = new System.Drawing.Size(113, 67);
            this.picPfp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPfp.TabIndex = 6;
            this.picPfp.TabStop = false;
            // 
            // pnlDisplay
            // 
            this.pnlDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(111)))), ((int)(((byte)(147)))));
            this.pnlDisplay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDisplay.Location = new System.Drawing.Point(3, 153);
            this.pnlDisplay.Name = "pnlDisplay";
            this.pnlDisplay.Size = new System.Drawing.Size(268, 294);
            this.pnlDisplay.TabIndex = 0;
            // 
            // pnlUser
            // 
            this.pnlUser.Controls.Add(this.btnInfo);
            this.pnlUser.Controls.Add(this.btnAirLines);
            this.pnlUser.Controls.Add(this.btnCountries);
            this.pnlUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlUser.Location = new System.Drawing.Point(3, 123);
            this.pnlUser.Name = "pnlUser";
            this.pnlUser.Size = new System.Drawing.Size(268, 24);
            this.pnlUser.TabIndex = 6;
            // 
            // btnInfo
            // 
            this.btnInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(41)))), ((int)(((byte)(91)))));
            this.btnInfo.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnInfo.ForeColor = System.Drawing.Color.White;
            this.btnInfo.Location = new System.Drawing.Point(178, 0);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(89, 24);
            this.btnInfo.TabIndex = 5;
            this.btnInfo.Text = "Info";
            this.btnInfo.UseVisualStyleBackColor = false;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnAirLines
            // 
            this.btnAirLines.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(41)))), ((int)(((byte)(91)))));
            this.btnAirLines.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAirLines.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAirLines.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAirLines.ForeColor = System.Drawing.Color.White;
            this.btnAirLines.Location = new System.Drawing.Point(89, 0);
            this.btnAirLines.Name = "btnAirLines";
            this.btnAirLines.Size = new System.Drawing.Size(89, 24);
            this.btnAirLines.TabIndex = 5;
            this.btnAirLines.Text = "AirLines";
            this.btnAirLines.UseVisualStyleBackColor = false;
            this.btnAirLines.Click += new System.EventHandler(this.btnAirLines_Click);
            // 
            // btnCountries
            // 
            this.btnCountries.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(41)))), ((int)(((byte)(91)))));
            this.btnCountries.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCountries.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCountries.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCountries.ForeColor = System.Drawing.Color.White;
            this.btnCountries.Location = new System.Drawing.Point(0, 0);
            this.btnCountries.Name = "btnCountries";
            this.btnCountries.Size = new System.Drawing.Size(89, 24);
            this.btnCountries.TabIndex = 5;
            this.btnCountries.Text = "Cities";
            this.btnCountries.UseVisualStyleBackColor = false;
            this.btnCountries.Click += new System.EventHandler(this.btnCountries_Click);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUserName.ForeColor = System.Drawing.Color.White;
            this.lblUserName.Location = new System.Drawing.Point(3, 100);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(54, 20);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "Guest";
            this.lblUserName.TextChanged += new System.EventHandler(this.lblUserName_TextChanged);
            // 
            // tblMenuBar
            // 
            this.tblMenuBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(111)))), ((int)(((byte)(171)))));
            this.tblMenuBar.ColumnCount = 4;
            this.tblMenuBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMenuBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblMenuBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblMenuBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblMenuBar.Controls.Add(this.picClose, 3, 0);
            this.tblMenuBar.Controls.Add(this.picMax, 2, 0);
            this.tblMenuBar.Controls.Add(this.picMin, 1, 0);
            this.tblMenuBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblMenuBar.Location = new System.Drawing.Point(274, 0);
            this.tblMenuBar.Name = "tblMenuBar";
            this.tblMenuBar.RowCount = 1;
            this.tblMenuBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMenuBar.Size = new System.Drawing.Size(536, 25);
            this.tblMenuBar.TabIndex = 4;
            // 
            // picClose
            // 
            this.picClose.BackgroundImage = global::TouristOffice.Properties.Resources.CloseB1;
            this.picClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picClose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picClose.Location = new System.Drawing.Point(512, 1);
            this.picClose.Margin = new System.Windows.Forms.Padding(1);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(23, 23);
            this.picClose.TabIndex = 0;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            this.picClose.MouseLeave += new System.EventHandler(this.picClose_MouseLeave);
            this.picClose.MouseHover += new System.EventHandler(this.picClose_MouseHover);
            // 
            // picMax
            // 
            this.picMax.BackgroundImage = global::TouristOffice.Properties.Resources.MaxB2;
            this.picMax.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picMax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picMax.Location = new System.Drawing.Point(487, 1);
            this.picMax.Margin = new System.Windows.Forms.Padding(1);
            this.picMax.Name = "picMax";
            this.picMax.Size = new System.Drawing.Size(23, 23);
            this.picMax.TabIndex = 1;
            this.picMax.TabStop = false;
            this.picMax.Click += new System.EventHandler(this.picMax_Click);
            this.picMax.MouseLeave += new System.EventHandler(this.picMax_MouseLeave);
            this.picMax.MouseHover += new System.EventHandler(this.picMax_MouseHover);
            // 
            // picMin
            // 
            this.picMin.BackgroundImage = global::TouristOffice.Properties.Resources.minusB;
            this.picMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picMin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picMin.Location = new System.Drawing.Point(462, 1);
            this.picMin.Margin = new System.Windows.Forms.Padding(1);
            this.picMin.Name = "picMin";
            this.picMin.Size = new System.Drawing.Size(23, 23);
            this.picMin.TabIndex = 2;
            this.picMin.TabStop = false;
            this.picMin.Click += new System.EventHandler(this.picMin_Click);
            this.picMin.MouseLeave += new System.EventHandler(this.picMin_MouseLeave);
            this.picMin.MouseHover += new System.EventHandler(this.picMin_MouseHover);
            // 
            // pnlNothing
            // 
            this.pnlNothing.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlNothing.Controls.Add(this.pnlBackGroundDisplay);
            this.pnlNothing.Controls.Add(this.tblMenuBar);
            this.pnlNothing.Controls.Add(this.tblUserTable);
            this.pnlNothing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlNothing.Location = new System.Drawing.Point(0, 0);
            this.pnlNothing.Name = "pnlNothing";
            this.pnlNothing.Size = new System.Drawing.Size(810, 450);
            this.pnlNothing.TabIndex = 1;
            // 
            // pnlBackGroundDisplay
            // 
            this.pnlBackGroundDisplay.BackColor = System.Drawing.Color.Transparent;
            this.pnlBackGroundDisplay.BackgroundImage = global::TouristOffice.Properties.Resources.plane;
            this.pnlBackGroundDisplay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlBackGroundDisplay.Controls.Add(this.btnCloseAdmin);
            this.pnlBackGroundDisplay.Controls.Add(this.lblEmptyAirLine);
            this.pnlBackGroundDisplay.Controls.Add(this.lblEmptyChild);
            this.pnlBackGroundDisplay.Controls.Add(this.lblEmptyInfant);
            this.pnlBackGroundDisplay.Controls.Add(this.lblEmptyClass);
            this.pnlBackGroundDisplay.Controls.Add(this.lblEmptyAdult);
            this.pnlBackGroundDisplay.Controls.Add(this.lblEmptyCities);
            this.pnlBackGroundDisplay.Controls.Add(this.dgvAdminPanel);
            this.pnlBackGroundDisplay.Controls.Add(this.btnAdminPanel);
            this.pnlBackGroundDisplay.Controls.Add(this.btnSubmit);
            this.pnlBackGroundDisplay.Controls.Add(this.pnlAirLines);
            this.pnlBackGroundDisplay.Controls.Add(this.cbxCities);
            this.pnlBackGroundDisplay.Controls.Add(this.cbxChild);
            this.pnlBackGroundDisplay.Controls.Add(this.cbxInfant);
            this.pnlBackGroundDisplay.Controls.Add(this.cbxAirLines);
            this.pnlBackGroundDisplay.Controls.Add(this.lblAdult);
            this.pnlBackGroundDisplay.Controls.Add(this.lblCities);
            this.pnlBackGroundDisplay.Controls.Add(this.lblChild);
            this.pnlBackGroundDisplay.Controls.Add(this.lblAirLine);
            this.pnlBackGroundDisplay.Controls.Add(this.cbxAdult);
            this.pnlBackGroundDisplay.Controls.Add(this.lblInfant);
            this.pnlBackGroundDisplay.Controls.Add(this.lblClass);
            this.pnlBackGroundDisplay.Controls.Add(this.cbxClass);
            this.pnlBackGroundDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBackGroundDisplay.ForeColor = System.Drawing.Color.White;
            this.pnlBackGroundDisplay.Location = new System.Drawing.Point(274, 25);
            this.pnlBackGroundDisplay.Name = "pnlBackGroundDisplay";
            this.pnlBackGroundDisplay.Size = new System.Drawing.Size(536, 425);
            this.pnlBackGroundDisplay.TabIndex = 5;
            // 
            // btnCloseAdmin
            // 
            this.btnCloseAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(41)))), ((int)(((byte)(91)))));
            this.btnCloseAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCloseAdmin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCloseAdmin.Location = new System.Drawing.Point(443, 0);
            this.btnCloseAdmin.Name = "btnCloseAdmin";
            this.btnCloseAdmin.Size = new System.Drawing.Size(93, 34);
            this.btnCloseAdmin.TabIndex = 4;
            this.btnCloseAdmin.Text = "Close Panel";
            this.btnCloseAdmin.UseVisualStyleBackColor = false;
            this.btnCloseAdmin.Click += new System.EventHandler(this.btnCloseAdmin_Click);
            // 
            // lblEmptyAirLine
            // 
            this.lblEmptyAirLine.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEmptyAirLine.AutoSize = true;
            this.lblEmptyAirLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEmptyAirLine.ForeColor = System.Drawing.Color.Red;
            this.lblEmptyAirLine.Location = new System.Drawing.Point(269, 304);
            this.lblEmptyAirLine.Name = "lblEmptyAirLine";
            this.lblEmptyAirLine.Size = new System.Drawing.Size(154, 13);
            this.lblEmptyAirLine.TabIndex = 6;
            this.lblEmptyAirLine.Text = "You cant leave this empty";
            // 
            // lblEmptyChild
            // 
            this.lblEmptyChild.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEmptyChild.AutoSize = true;
            this.lblEmptyChild.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEmptyChild.ForeColor = System.Drawing.Color.Red;
            this.lblEmptyChild.Location = new System.Drawing.Point(165, 235);
            this.lblEmptyChild.Name = "lblEmptyChild";
            this.lblEmptyChild.Size = new System.Drawing.Size(154, 13);
            this.lblEmptyChild.TabIndex = 6;
            this.lblEmptyChild.Text = "You cant leave this empty";
            // 
            // lblEmptyInfant
            // 
            this.lblEmptyInfant.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEmptyInfant.AutoSize = true;
            this.lblEmptyInfant.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEmptyInfant.ForeColor = System.Drawing.Color.Red;
            this.lblEmptyInfant.Location = new System.Drawing.Point(330, 235);
            this.lblEmptyInfant.Name = "lblEmptyInfant";
            this.lblEmptyInfant.Size = new System.Drawing.Size(154, 13);
            this.lblEmptyInfant.TabIndex = 6;
            this.lblEmptyInfant.Text = "You cant leave this empty";
            // 
            // lblEmptyClass
            // 
            this.lblEmptyClass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEmptyClass.AutoSize = true;
            this.lblEmptyClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEmptyClass.ForeColor = System.Drawing.Color.Red;
            this.lblEmptyClass.Location = new System.Drawing.Point(98, 304);
            this.lblEmptyClass.Name = "lblEmptyClass";
            this.lblEmptyClass.Size = new System.Drawing.Size(154, 13);
            this.lblEmptyClass.TabIndex = 6;
            this.lblEmptyClass.Text = "You cant leave this empty";
            // 
            // lblEmptyAdult
            // 
            this.lblEmptyAdult.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEmptyAdult.AutoSize = true;
            this.lblEmptyAdult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEmptyAdult.ForeColor = System.Drawing.Color.Red;
            this.lblEmptyAdult.Location = new System.Drawing.Point(0, 235);
            this.lblEmptyAdult.Name = "lblEmptyAdult";
            this.lblEmptyAdult.Size = new System.Drawing.Size(154, 13);
            this.lblEmptyAdult.TabIndex = 6;
            this.lblEmptyAdult.Text = "You cant leave this empty";
            // 
            // lblEmptyCities
            // 
            this.lblEmptyCities.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEmptyCities.AutoSize = true;
            this.lblEmptyCities.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEmptyCities.ForeColor = System.Drawing.Color.Red;
            this.lblEmptyCities.Location = new System.Drawing.Point(160, 176);
            this.lblEmptyCities.Name = "lblEmptyCities";
            this.lblEmptyCities.Size = new System.Drawing.Size(154, 13);
            this.lblEmptyCities.TabIndex = 6;
            this.lblEmptyCities.Text = "You cant leave this empty";
            // 
            // dgvAdminPanel
            // 
            this.dgvAdminPanel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAdminPanel.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAdminPanel.BackgroundColor = System.Drawing.SystemColors.Highlight;
            this.dgvAdminPanel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdminPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvAdminPanel.GridColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.dgvAdminPanel.Location = new System.Drawing.Point(0, 40);
            this.dgvAdminPanel.Name = "dgvAdminPanel";
            this.dgvAdminPanel.RowTemplate.Height = 25;
            this.dgvAdminPanel.Size = new System.Drawing.Size(536, 385);
            this.dgvAdminPanel.TabIndex = 5;
            // 
            // btnAdminPanel
            // 
            this.btnAdminPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(41)))), ((int)(((byte)(91)))));
            this.btnAdminPanel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdminPanel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdminPanel.Location = new System.Drawing.Point(0, 0);
            this.btnAdminPanel.Name = "btnAdminPanel";
            this.btnAdminPanel.Size = new System.Drawing.Size(93, 34);
            this.btnAdminPanel.TabIndex = 4;
            this.btnAdminPanel.Text = "Admin Panel";
            this.btnAdminPanel.UseVisualStyleBackColor = false;
            this.btnAdminPanel.Click += new System.EventHandler(this.btnAdminPanel_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(41)))), ((int)(((byte)(91)))));
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSubmit.Location = new System.Drawing.Point(212, 325);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(93, 34);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // pnlAirLines
            // 
            this.pnlAirLines.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlAirLines.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlAirLines.Location = new System.Drawing.Point(336, 325);
            this.pnlAirLines.Name = "pnlAirLines";
            this.pnlAirLines.Size = new System.Drawing.Size(200, 100);
            this.pnlAirLines.TabIndex = 3;
            // 
            // cbxCities
            // 
            this.cbxCities.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxCities.FormattingEnabled = true;
            this.cbxCities.Items.AddRange(new object[] {
            "Aqaba(Jordan)",
            "Abu Dhabi(UAE)",
            "Alghero(Italy)",
            "Ankara(Turkey)",
            "Bangkok(Thailand)",
            "Istanbul(Turkey)"});
            this.cbxCities.Location = new System.Drawing.Point(158, 150);
            this.cbxCities.Name = "cbxCities";
            this.cbxCities.Size = new System.Drawing.Size(202, 23);
            this.cbxCities.TabIndex = 2;
            this.cbxCities.SelectedIndexChanged += new System.EventHandler(this.cbxCities_SelectedIndexChanged);
            this.cbxCities.TextChanged += new System.EventHandler(this.cbxCities_TextChanged);
            // 
            // cbxChild
            // 
            this.cbxChild.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxChild.FormattingEnabled = true;
            this.cbxChild.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbxChild.Location = new System.Drawing.Point(212, 209);
            this.cbxChild.Name = "cbxChild";
            this.cbxChild.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbxChild.Size = new System.Drawing.Size(93, 23);
            this.cbxChild.TabIndex = 1;
            this.cbxChild.TextChanged += new System.EventHandler(this.cbxChild_TextChanged);
            // 
            // cbxInfant
            // 
            this.cbxInfant.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxInfant.FormattingEnabled = true;
            this.cbxInfant.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.cbxInfant.Location = new System.Drawing.Point(330, 209);
            this.cbxInfant.Name = "cbxInfant";
            this.cbxInfant.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbxInfant.Size = new System.Drawing.Size(93, 23);
            this.cbxInfant.TabIndex = 1;
            this.cbxInfant.TextChanged += new System.EventHandler(this.cbxInfant_TextChanged);
            // 
            // cbxAirLines
            // 
            this.cbxAirLines.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxAirLines.FormattingEnabled = true;
            this.cbxAirLines.Items.AddRange(new object[] {
            "Royal Jordanian",
            "Air Cairo",
            "Turkish Airlines",
            "Fly Emirates"});
            this.cbxAirLines.Location = new System.Drawing.Point(267, 278);
            this.cbxAirLines.Name = "cbxAirLines";
            this.cbxAirLines.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbxAirLines.Size = new System.Drawing.Size(93, 23);
            this.cbxAirLines.TabIndex = 1;
            this.cbxAirLines.SelectedIndexChanged += new System.EventHandler(this.cbxAirLines_SelectedIndexChanged);
            this.cbxAirLines.TextChanged += new System.EventHandler(this.cbxAirLines_TextChanged);
            // 
            // lblAdult
            // 
            this.lblAdult.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAdult.AutoSize = true;
            this.lblAdult.BackColor = System.Drawing.Color.Transparent;
            this.lblAdult.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAdult.Location = new System.Drawing.Point(91, 191);
            this.lblAdult.Name = "lblAdult";
            this.lblAdult.Size = new System.Drawing.Size(42, 17);
            this.lblAdult.TabIndex = 0;
            this.lblAdult.Text = "Adult";
            // 
            // lblCities
            // 
            this.lblCities.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCities.AutoSize = true;
            this.lblCities.BackColor = System.Drawing.Color.Transparent;
            this.lblCities.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCities.Location = new System.Drawing.Point(243, 128);
            this.lblCities.Name = "lblCities";
            this.lblCities.Size = new System.Drawing.Size(42, 17);
            this.lblCities.TabIndex = 0;
            this.lblCities.Text = "Cities";
            // 
            // lblChild
            // 
            this.lblChild.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblChild.AutoSize = true;
            this.lblChild.BackColor = System.Drawing.Color.Transparent;
            this.lblChild.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblChild.Location = new System.Drawing.Point(212, 191);
            this.lblChild.Name = "lblChild";
            this.lblChild.Size = new System.Drawing.Size(40, 17);
            this.lblChild.TabIndex = 0;
            this.lblChild.Text = "Child";
            // 
            // lblAirLine
            // 
            this.lblAirLine.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAirLine.AutoSize = true;
            this.lblAirLine.BackColor = System.Drawing.Color.Transparent;
            this.lblAirLine.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAirLine.Location = new System.Drawing.Point(267, 260);
            this.lblAirLine.Name = "lblAirLine";
            this.lblAirLine.Size = new System.Drawing.Size(52, 17);
            this.lblAirLine.TabIndex = 0;
            this.lblAirLine.Text = "AirLine";
            // 
            // cbxAdult
            // 
            this.cbxAdult.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxAdult.FormattingEnabled = true;
            this.cbxAdult.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cbxAdult.Location = new System.Drawing.Point(91, 209);
            this.cbxAdult.Name = "cbxAdult";
            this.cbxAdult.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbxAdult.Size = new System.Drawing.Size(93, 23);
            this.cbxAdult.TabIndex = 1;
            this.cbxAdult.TextChanged += new System.EventHandler(this.cbxAdult_TextChanged);
            // 
            // lblInfant
            // 
            this.lblInfant.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblInfant.AutoSize = true;
            this.lblInfant.BackColor = System.Drawing.Color.Transparent;
            this.lblInfant.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblInfant.Location = new System.Drawing.Point(330, 191);
            this.lblInfant.Name = "lblInfant";
            this.lblInfant.Size = new System.Drawing.Size(45, 17);
            this.lblInfant.TabIndex = 0;
            this.lblInfant.Text = "Infant";
            // 
            // lblClass
            // 
            this.lblClass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblClass.AutoSize = true;
            this.lblClass.BackColor = System.Drawing.Color.Transparent;
            this.lblClass.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblClass.Location = new System.Drawing.Point(158, 260);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(39, 17);
            this.lblClass.TabIndex = 0;
            this.lblClass.Text = "Class";
            // 
            // cbxClass
            // 
            this.cbxClass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxClass.FormattingEnabled = true;
            this.cbxClass.Items.AddRange(new object[] {
            "Economy",
            "Premium Economy",
            "Business",
            "First"});
            this.cbxClass.Location = new System.Drawing.Point(158, 278);
            this.cbxClass.Name = "cbxClass";
            this.cbxClass.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbxClass.Size = new System.Drawing.Size(84, 23);
            this.cbxClass.TabIndex = 1;
            this.cbxClass.TextChanged += new System.EventHandler(this.cbxClass_TextChanged);
            // 
            // frmHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 450);
            this.Controls.Add(this.pnlNothing);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomePage";
            this.Load += new System.EventHandler(this.frmHomePage_Load);
            this.tblUserTable.ResumeLayout(false);
            this.tblUserTable.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picPfp)).EndInit();
            this.pnlUser.ResumeLayout(false);
            this.tblMenuBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMin)).EndInit();
            this.pnlNothing.ResumeLayout(false);
            this.pnlBackGroundDisplay.ResumeLayout(false);
            this.pnlBackGroundDisplay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminPanel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tblUserTable;
        private Panel pnlUser;
        private Button btnInfo;
        private Button btnAirLines;
        private Button btnCountries;
        private TableLayoutPanel tblMenuBar;
        private PictureBox picClose;
        private PictureBox picMax;
        private PictureBox picMin;
        private Panel pnlNothing;
        private Panel pnlDisplay;
        private Panel panel1;
        private ComboBox cbxClass;
        private Label lblChild;
        private Label lblInfant;
        private Label lblClass;
        private Label lblAirLine;
        private Label lblAdult;
        public Panel pnlBackGroundDisplay;
        private Label lblCities;
        public Panel pnlAirLines;
        public ComboBox cbxAirLines;
        public ComboBox cbxCities;
        public PictureBox picPfp;
        public Label lblUserName;
        private Button btnSubmit;
        private Button btnAdminPanel;
        private DataGridView dgvAdminPanel;
        private Button btnCloseAdmin;
        public ComboBox cbxInfant;
        public ComboBox cbxChild;
        public ComboBox cbxAdult;
        private Label lblEmptyAirLine;
        private Label lblEmptyClass;
        private Label lblEmptyAdult;
        private Label lblEmptyCities;
        private Label lblEmptyChild;
        private Label lblEmptyInfant;
    }
}