using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OctoBoiz
{
    public partial class AccountSettings : Form
    {
        public AccountSettings()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountSettings));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtbxFirstNameNEW = new System.Windows.Forms.TextBox();
            this.txtbxLastNameNEW = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtbxDateofBirthNEW = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.radiobtnMale = new System.Windows.Forms.RadioButton();
            this.radiobtnFemale = new System.Windows.Forms.RadioButton();
            this.btnConfirmNewEmployee = new System.Windows.Forms.Button();
            this.lblActivityLogAccount = new System.Windows.Forms.Label();
            this.lblAccountSettingsAccount = new System.Windows.Forms.Label();
            this.lblSettingsAccount = new System.Windows.Forms.Label();
            this.SideMenu = new System.Windows.Forms.Panel();
            this.Logout_AdminAccSettings = new System.Windows.Forms.PictureBox();
            this.Settings_AdminAccSettings = new System.Windows.Forms.PictureBox();
            this.Analytics_AdminAccSettings = new System.Windows.Forms.PictureBox();
            this.Inventory_AdminAccSettings = new System.Windows.Forms.PictureBox();
            this.Orders_AdminAccSettings = new System.Windows.Forms.PictureBox();
            this.Dashboard_AdminAccSettings = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtbxFirstNameOLD = new System.Windows.Forms.TextBox();
            this.txtbxLastNameOLD = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnSaveExistingEmployee = new System.Windows.Forms.Button();
            this.txtbxDateofBirthOLD = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TopBar = new System.Windows.Forms.Panel();
            this.tb_SearchBar = new System.Windows.Forms.TextBox();
            this.pbOctoBoiz = new System.Windows.Forms.PictureBox();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SideMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logout_AdminAccSettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Settings_AdminAccSettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Analytics_AdminAccSettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Inventory_AdminAccSettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Orders_AdminAccSettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dashboard_AdminAccSettings)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.TopBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOctoBoiz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F);
            this.label1.Location = new System.Drawing.Point(122, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADMIN - ACCOUNT SETTINGS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "CREATE NEW EMPLOYEE ACCOUNT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "EMPLOYEE DETAILS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(217, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "EMPLOYEE #";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "FIRST NAME";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(153, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "LAST NAME";
            // 
            // txtbxFirstNameNEW
            // 
            this.txtbxFirstNameNEW.Location = new System.Drawing.Point(19, 94);
            this.txtbxFirstNameNEW.Name = "txtbxFirstNameNEW";
            this.txtbxFirstNameNEW.Size = new System.Drawing.Size(131, 20);
            this.txtbxFirstNameNEW.TabIndex = 7;
            // 
            // txtbxLastNameNEW
            // 
            this.txtbxLastNameNEW.Location = new System.Drawing.Point(156, 94);
            this.txtbxLastNameNEW.Name = "txtbxLastNameNEW";
            this.txtbxLastNameNEW.Size = new System.Drawing.Size(136, 20);
            this.txtbxLastNameNEW.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "DATE OF BIRTH ";
            // 
            // txtbxDateofBirthNEW
            // 
            this.txtbxDateofBirthNEW.Location = new System.Drawing.Point(19, 152);
            this.txtbxDateofBirthNEW.Name = "txtbxDateofBirthNEW";
            this.txtbxDateofBirthNEW.Size = new System.Drawing.Size(131, 20);
            this.txtbxDateofBirthNEW.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(157, 127);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "SEX";
            // 
            // radiobtnMale
            // 
            this.radiobtnMale.AutoSize = true;
            this.radiobtnMale.Location = new System.Drawing.Point(160, 153);
            this.radiobtnMale.Name = "radiobtnMale";
            this.radiobtnMale.Size = new System.Drawing.Size(54, 17);
            this.radiobtnMale.TabIndex = 66;
            this.radiobtnMale.TabStop = true;
            this.radiobtnMale.Text = "MALE";
            this.radiobtnMale.UseVisualStyleBackColor = true;
            // 
            // radiobtnFemale
            // 
            this.radiobtnFemale.AutoSize = true;
            this.radiobtnFemale.Location = new System.Drawing.Point(220, 153);
            this.radiobtnFemale.Name = "radiobtnFemale";
            this.radiobtnFemale.Size = new System.Drawing.Size(67, 17);
            this.radiobtnFemale.TabIndex = 67;
            this.radiobtnFemale.TabStop = true;
            this.radiobtnFemale.Text = "FEMALE";
            this.radiobtnFemale.UseVisualStyleBackColor = true;
            // 
            // btnConfirmNewEmployee
            // 
            this.btnConfirmNewEmployee.Location = new System.Drawing.Point(217, 297);
            this.btnConfirmNewEmployee.Name = "btnConfirmNewEmployee";
            this.btnConfirmNewEmployee.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmNewEmployee.TabIndex = 83;
            this.btnConfirmNewEmployee.Text = "CONFIRM";
            this.btnConfirmNewEmployee.UseVisualStyleBackColor = true;
            // 
            // lblActivityLogAccount
            // 
            this.lblActivityLogAccount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblActivityLogAccount.AutoSize = true;
            this.lblActivityLogAccount.Location = new System.Drawing.Point(743, 83);
            this.lblActivityLogAccount.Name = "lblActivityLogAccount";
            this.lblActivityLogAccount.Size = new System.Drawing.Size(80, 13);
            this.lblActivityLogAccount.TabIndex = 92;
            this.lblActivityLogAccount.Text = "ACTIVITY LOG";
            // 
            // lblAccountSettingsAccount
            // 
            this.lblAccountSettingsAccount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAccountSettingsAccount.AutoSize = true;
            this.lblAccountSettingsAccount.Location = new System.Drawing.Point(623, 83);
            this.lblAccountSettingsAccount.Name = "lblAccountSettingsAccount";
            this.lblAccountSettingsAccount.Size = new System.Drawing.Size(116, 13);
            this.lblAccountSettingsAccount.TabIndex = 91;
            this.lblAccountSettingsAccount.Text = "ACCOUNT SETTINGS";
            // 
            // lblSettingsAccount
            // 
            this.lblSettingsAccount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSettingsAccount.AutoSize = true;
            this.lblSettingsAccount.Location = new System.Drawing.Point(558, 83);
            this.lblSettingsAccount.Name = "lblSettingsAccount";
            this.lblSettingsAccount.Size = new System.Drawing.Size(61, 13);
            this.lblSettingsAccount.TabIndex = 90;
            this.lblSettingsAccount.Text = "SETTINGS";
            // 
            // SideMenu
            // 
            this.SideMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.SideMenu.Controls.Add(this.Logout_AdminAccSettings);
            this.SideMenu.Controls.Add(this.Settings_AdminAccSettings);
            this.SideMenu.Controls.Add(this.Analytics_AdminAccSettings);
            this.SideMenu.Controls.Add(this.Inventory_AdminAccSettings);
            this.SideMenu.Controls.Add(this.Orders_AdminAccSettings);
            this.SideMenu.Controls.Add(this.Dashboard_AdminAccSettings);
            this.SideMenu.Location = new System.Drawing.Point(0, 67);
            this.SideMenu.Name = "SideMenu";
            this.SideMenu.Size = new System.Drawing.Size(106, 431);
            this.SideMenu.TabIndex = 94;
            // 
            // Logout_AdminAccSettings
            // 
            this.Logout_AdminAccSettings.Image = ((System.Drawing.Image)(resources.GetObject("Logout_AdminAccSettings.Image")));
            this.Logout_AdminAccSettings.Location = new System.Drawing.Point(3, 368);
            this.Logout_AdminAccSettings.Name = "Logout_AdminAccSettings";
            this.Logout_AdminAccSettings.Size = new System.Drawing.Size(100, 60);
            this.Logout_AdminAccSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logout_AdminAccSettings.TabIndex = 5;
            this.Logout_AdminAccSettings.TabStop = false;
            // 
            // Settings_AdminAccSettings
            // 
            this.Settings_AdminAccSettings.Image = ((System.Drawing.Image)(resources.GetObject("Settings_AdminAccSettings.Image")));
            this.Settings_AdminAccSettings.Location = new System.Drawing.Point(3, 295);
            this.Settings_AdminAccSettings.Name = "Settings_AdminAccSettings";
            this.Settings_AdminAccSettings.Size = new System.Drawing.Size(100, 60);
            this.Settings_AdminAccSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Settings_AdminAccSettings.TabIndex = 4;
            this.Settings_AdminAccSettings.TabStop = false;
            // 
            // Analytics_AdminAccSettings
            // 
            this.Analytics_AdminAccSettings.Image = ((System.Drawing.Image)(resources.GetObject("Analytics_AdminAccSettings.Image")));
            this.Analytics_AdminAccSettings.Location = new System.Drawing.Point(3, 215);
            this.Analytics_AdminAccSettings.Name = "Analytics_AdminAccSettings";
            this.Analytics_AdminAccSettings.Size = new System.Drawing.Size(100, 60);
            this.Analytics_AdminAccSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Analytics_AdminAccSettings.TabIndex = 3;
            this.Analytics_AdminAccSettings.TabStop = false;
            // 
            // Inventory_AdminAccSettings
            // 
            this.Inventory_AdminAccSettings.Image = ((System.Drawing.Image)(resources.GetObject("Inventory_AdminAccSettings.Image")));
            this.Inventory_AdminAccSettings.Location = new System.Drawing.Point(3, 145);
            this.Inventory_AdminAccSettings.Name = "Inventory_AdminAccSettings";
            this.Inventory_AdminAccSettings.Size = new System.Drawing.Size(100, 60);
            this.Inventory_AdminAccSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Inventory_AdminAccSettings.TabIndex = 2;
            this.Inventory_AdminAccSettings.TabStop = false;
            // 
            // Orders_AdminAccSettings
            // 
            this.Orders_AdminAccSettings.Image = ((System.Drawing.Image)(resources.GetObject("Orders_AdminAccSettings.Image")));
            this.Orders_AdminAccSettings.Location = new System.Drawing.Point(3, 75);
            this.Orders_AdminAccSettings.Name = "Orders_AdminAccSettings";
            this.Orders_AdminAccSettings.Size = new System.Drawing.Size(100, 60);
            this.Orders_AdminAccSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Orders_AdminAccSettings.TabIndex = 1;
            this.Orders_AdminAccSettings.TabStop = false;
            // 
            // Dashboard_AdminAccSettings
            // 
            this.Dashboard_AdminAccSettings.Image = ((System.Drawing.Image)(resources.GetObject("Dashboard_AdminAccSettings.Image")));
            this.Dashboard_AdminAccSettings.Location = new System.Drawing.Point(3, 5);
            this.Dashboard_AdminAccSettings.Name = "Dashboard_AdminAccSettings";
            this.Dashboard_AdminAccSettings.Size = new System.Drawing.Size(100, 60);
            this.Dashboard_AdminAccSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Dashboard_AdminAccSettings.TabIndex = 0;
            this.Dashboard_AdminAccSettings.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(201, 13);
            this.label10.TabIndex = 68;
            this.label10.Text = "EDIT EXISTING EMPLOYEE ACCOUNT";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 51);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(177, 13);
            this.label11.TabIndex = 69;
            this.label11.Text = "NAME OF EMPLOYEE ACCOUNT: ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 75);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(113, 13);
            this.label12.TabIndex = 71;
            this.label12.Text = "EMPLOYEE DETAILS";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(13, 99);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(72, 13);
            this.label17.TabIndex = 72;
            this.label17.Text = "FIRST NAME";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(150, 99);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(68, 13);
            this.label16.TabIndex = 73;
            this.label16.Text = "LAST NAME";
            // 
            // txtbxFirstNameOLD
            // 
            this.txtbxFirstNameOLD.Location = new System.Drawing.Point(16, 116);
            this.txtbxFirstNameOLD.Name = "txtbxFirstNameOLD";
            this.txtbxFirstNameOLD.Size = new System.Drawing.Size(131, 20);
            this.txtbxFirstNameOLD.TabIndex = 74;
            // 
            // txtbxLastNameOLD
            // 
            this.txtbxLastNameOLD.Location = new System.Drawing.Point(153, 116);
            this.txtbxLastNameOLD.Name = "txtbxLastNameOLD";
            this.txtbxLastNameOLD.Size = new System.Drawing.Size(136, 20);
            this.txtbxLastNameOLD.TabIndex = 75;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(150, 148);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(92, 13);
            this.label14.TabIndex = 77;
            this.label14.Text = "DATE OF BIRTH ";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(188, 44);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 95;
            // 
            // btnSaveExistingEmployee
            // 
            this.btnSaveExistingEmployee.Location = new System.Drawing.Point(234, 297);
            this.btnSaveExistingEmployee.Name = "btnSaveExistingEmployee";
            this.btnSaveExistingEmployee.Size = new System.Drawing.Size(75, 23);
            this.btnSaveExistingEmployee.TabIndex = 84;
            this.btnSaveExistingEmployee.Text = "SAVE";
            this.btnSaveExistingEmployee.UseVisualStyleBackColor = true;
            // 
            // txtbxDateofBirthOLD
            // 
            this.txtbxDateofBirthOLD.Location = new System.Drawing.Point(153, 173);
            this.txtbxDateofBirthOLD.Name = "txtbxDateofBirthOLD";
            this.txtbxDateofBirthOLD.Size = new System.Drawing.Size(136, 20);
            this.txtbxDateofBirthOLD.TabIndex = 79;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtbxFirstNameNEW);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtbxLastNameNEW);
            this.panel1.Controls.Add(this.btnConfirmNewEmployee);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtbxDateofBirthNEW);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.radiobtnMale);
            this.panel1.Controls.Add(this.radiobtnFemale);
            this.panel1.Location = new System.Drawing.Point(131, 118);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 368);
            this.panel1.TabIndex = 96;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.txtbxFirstNameOLD);
            this.panel3.Controls.Add(this.btnSaveExistingEmployee);
            this.panel3.Controls.Add(this.txtbxLastNameOLD);
            this.panel3.Controls.Add(this.txtbxDateofBirthOLD);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Location = new System.Drawing.Point(480, 118);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(320, 368);
            this.panel3.TabIndex = 97;
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
            this.TopBar.TabIndex = 98;
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
            // AccountSettings
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(838, 498);
            this.Controls.Add(this.TopBar);
            this.Controls.Add(this.SideMenu);
            this.Controls.Add(this.lblActivityLogAccount);
            this.Controls.Add(this.lblAccountSettingsAccount);
            this.Controls.Add(this.lblSettingsAccount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Name = "AccountSettings";
            this.SideMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Logout_AdminAccSettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Settings_AdminAccSettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Analytics_AdminAccSettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Inventory_AdminAccSettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Orders_AdminAccSettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dashboard_AdminAccSettings)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.TopBar.ResumeLayout(false);
            this.TopBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOctoBoiz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
