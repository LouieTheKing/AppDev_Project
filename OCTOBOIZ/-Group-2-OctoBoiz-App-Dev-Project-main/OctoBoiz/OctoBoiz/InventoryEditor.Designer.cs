namespace OctoBoiz
{
    partial class frmInventoryEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInventoryEditor));
            this.lblInventoryEditor = new System.Windows.Forms.Label();
            this.Inventoryview = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SideMenu = new System.Windows.Forms.Panel();
            this.Logout = new System.Windows.Forms.PictureBox();
            this.Settings = new System.Windows.Forms.PictureBox();
            this.Analytics = new System.Windows.Forms.PictureBox();
            this.inventory = new System.Windows.Forms.PictureBox();
            this.Orders = new System.Windows.Forms.PictureBox();
            this.Dashboard = new System.Windows.Forms.PictureBox();
            this.lblActivityLogAccount = new System.Windows.Forms.Label();
            this.lblAccountSettingsAccount = new System.Windows.Forms.Label();
            this.lblSettingsAccount = new System.Windows.Forms.Label();
            this.TopBar = new System.Windows.Forms.Panel();
            this.tb_SearchBar = new System.Windows.Forms.TextBox();
            this.pbOctoBoiz = new System.Windows.Forms.PictureBox();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.Inventoryview)).BeginInit();
            this.SideMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Settings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Analytics)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Orders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dashboard)).BeginInit();
            this.TopBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOctoBoiz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInventoryEditor
            // 
            this.lblInventoryEditor.AutoSize = true;
            this.lblInventoryEditor.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F);
            this.lblInventoryEditor.Location = new System.Drawing.Point(122, 75);
            this.lblInventoryEditor.Name = "lblInventoryEditor";
            this.lblInventoryEditor.Size = new System.Drawing.Size(126, 26);
            this.lblInventoryEditor.TabIndex = 1;
            this.lblInventoryEditor.Text = "INVENTORY";
            // 
            // Inventoryview
            // 
            this.Inventoryview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Inventoryview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column1,
            this.Column3,
            this.Column4,
            this.Column5});
            this.Inventoryview.Location = new System.Drawing.Point(118, 123);
            this.Inventoryview.Name = "Inventoryview";
            this.Inventoryview.Size = new System.Drawing.Size(708, 363);
            this.Inventoryview.TabIndex = 2;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "ITEMS";
            this.Column2.Name = "Column2";
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "RECEPIES, INGREDIENTS";
            this.Column1.Name = "Column1";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "QUANTITY";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "STATUS";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "";
            this.Column5.Name = "Column5";
            // 
            // SideMenu
            // 
            this.SideMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.SideMenu.Controls.Add(this.Logout);
            this.SideMenu.Controls.Add(this.Settings);
            this.SideMenu.Controls.Add(this.Analytics);
            this.SideMenu.Controls.Add(this.inventory);
            this.SideMenu.Controls.Add(this.Orders);
            this.SideMenu.Controls.Add(this.Dashboard);
            this.SideMenu.Location = new System.Drawing.Point(0, 67);
            this.SideMenu.Name = "SideMenu";
            this.SideMenu.Size = new System.Drawing.Size(106, 431);
            this.SideMenu.TabIndex = 86;
            // 
            // Logout
            // 
            this.Logout.Image = ((System.Drawing.Image)(resources.GetObject("Logout.Image")));
            this.Logout.Location = new System.Drawing.Point(3, 368);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(100, 60);
            this.Logout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logout.TabIndex = 5;
            this.Logout.TabStop = false;
            // 
            // Settings
            // 
            this.Settings.Image = ((System.Drawing.Image)(resources.GetObject("Settings.Image")));
            this.Settings.Location = new System.Drawing.Point(3, 295);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(100, 60);
            this.Settings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Settings.TabIndex = 4;
            this.Settings.TabStop = false;
            // 
            // Analytics
            // 
            this.Analytics.Image = ((System.Drawing.Image)(resources.GetObject("Analytics.Image")));
            this.Analytics.Location = new System.Drawing.Point(3, 215);
            this.Analytics.Name = "Analytics";
            this.Analytics.Size = new System.Drawing.Size(100, 60);
            this.Analytics.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Analytics.TabIndex = 3;
            this.Analytics.TabStop = false;
            // 
            // inventory
            // 
            this.inventory.Image = ((System.Drawing.Image)(resources.GetObject("inventory.Image")));
            this.inventory.Location = new System.Drawing.Point(3, 145);
            this.inventory.Name = "inventory";
            this.inventory.Size = new System.Drawing.Size(100, 60);
            this.inventory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.inventory.TabIndex = 2;
            this.inventory.TabStop = false;
            // 
            // Orders
            // 
            this.Orders.Image = ((System.Drawing.Image)(resources.GetObject("Orders.Image")));
            this.Orders.Location = new System.Drawing.Point(3, 75);
            this.Orders.Name = "Orders";
            this.Orders.Size = new System.Drawing.Size(100, 60);
            this.Orders.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Orders.TabIndex = 1;
            this.Orders.TabStop = false;
            // 
            // Dashboard
            // 
            this.Dashboard.Image = ((System.Drawing.Image)(resources.GetObject("Dashboard.Image")));
            this.Dashboard.Location = new System.Drawing.Point(3, 5);
            this.Dashboard.Name = "Dashboard";
            this.Dashboard.Size = new System.Drawing.Size(100, 60);
            this.Dashboard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Dashboard.TabIndex = 0;
            this.Dashboard.TabStop = false;
            // 
            // lblActivityLogAccount
            // 
            this.lblActivityLogAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblActivityLogAccount.AutoSize = true;
            this.lblActivityLogAccount.Location = new System.Drawing.Point(722, 83);
            this.lblActivityLogAccount.Name = "lblActivityLogAccount";
            this.lblActivityLogAccount.Size = new System.Drawing.Size(104, 13);
            this.lblActivityLogAccount.TabIndex = 95;
            this.lblActivityLogAccount.Text = "PRODUCT EDITOR";
            // 
            // lblAccountSettingsAccount
            // 
            this.lblAccountSettingsAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAccountSettingsAccount.AutoSize = true;
            this.lblAccountSettingsAccount.Location = new System.Drawing.Point(630, 83);
            this.lblAccountSettingsAccount.Name = "lblAccountSettingsAccount";
            this.lblAccountSettingsAccount.Size = new System.Drawing.Size(86, 13);
            this.lblAccountSettingsAccount.TabIndex = 94;
            this.lblAccountSettingsAccount.Text = "PRODUCT LIST";
            // 
            // lblSettingsAccount
            // 
            this.lblSettingsAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSettingsAccount.AutoSize = true;
            this.lblSettingsAccount.Location = new System.Drawing.Point(554, 83);
            this.lblSettingsAccount.Name = "lblSettingsAccount";
            this.lblSettingsAccount.Size = new System.Drawing.Size(70, 13);
            this.lblSettingsAccount.TabIndex = 93;
            this.lblSettingsAccount.Text = "INVENTORY";
            // 
            // TopBar
            // 
            this.TopBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TopBar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.TopBar.Controls.Add(this.tb_SearchBar);
            this.TopBar.Controls.Add(this.pbOctoBoiz);
            this.TopBar.Controls.Add(this.pbLogo);
            this.TopBar.Controls.Add(this.panel2);
            this.TopBar.Location = new System.Drawing.Point(0, 0);
            this.TopBar.Name = "TopBar";
            this.TopBar.Size = new System.Drawing.Size(838, 67);
            this.TopBar.TabIndex = 96;
            // 
            // tb_SearchBar
            // 
            this.tb_SearchBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_SearchBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            this.tb_SearchBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_SearchBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_SearchBar.Location = new System.Drawing.Point(596, 12);
            this.tb_SearchBar.Multiline = true;
            this.tb_SearchBar.Name = "tb_SearchBar";
            this.tb_SearchBar.Size = new System.Drawing.Size(230, 40);
            this.tb_SearchBar.TabIndex = 89;
            this.tb_SearchBar.Text = "Search product or any order...";
            // 
            // pbOctoBoiz
            // 
            this.pbOctoBoiz.Image = ((System.Drawing.Image)(resources.GetObject("pbOctoBoiz.Image")));
            this.pbOctoBoiz.Location = new System.Drawing.Point(76, 0);
            this.pbOctoBoiz.Name = "pbOctoBoiz";
            this.pbOctoBoiz.Size = new System.Drawing.Size(191, 67);
            this.pbOctoBoiz.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbOctoBoiz.TabIndex = 88;
            this.pbOctoBoiz.TabStop = false;
            // 
            // pbLogo
            // 
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(0, 0);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(70, 67);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 87;
            this.pbLogo.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(2, 68);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(114, 430);
            this.panel2.TabIndex = 86;
            // 
            // frmInventoryEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(838, 498);
            this.Controls.Add(this.TopBar);
            this.Controls.Add(this.lblActivityLogAccount);
            this.Controls.Add(this.lblAccountSettingsAccount);
            this.Controls.Add(this.lblSettingsAccount);
            this.Controls.Add(this.SideMenu);
            this.Controls.Add(this.Inventoryview);
            this.Controls.Add(this.lblInventoryEditor);
            this.Name = "frmInventoryEditor";
            this.Text = "Inventory Editor";
            ((System.ComponentModel.ISupportInitialize)(this.Inventoryview)).EndInit();
            this.SideMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Logout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Settings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Analytics)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Orders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dashboard)).EndInit();
            this.TopBar.ResumeLayout(false);
            this.TopBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOctoBoiz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblInventoryEditor;
        private System.Windows.Forms.DataGridView Inventoryview;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Panel SideMenu;
        private System.Windows.Forms.PictureBox Dashboard;
        private System.Windows.Forms.PictureBox Logout;
        private System.Windows.Forms.PictureBox Settings;
        private System.Windows.Forms.PictureBox Analytics;
        private System.Windows.Forms.PictureBox inventory;
        private System.Windows.Forms.PictureBox Orders;
        private System.Windows.Forms.Label lblActivityLogAccount;
        private System.Windows.Forms.Label lblAccountSettingsAccount;
        private System.Windows.Forms.Label lblSettingsAccount;
        private System.Windows.Forms.Panel TopBar;
        private System.Windows.Forms.TextBox tb_SearchBar;
        private System.Windows.Forms.PictureBox pbOctoBoiz;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Panel panel2;
    }
}

