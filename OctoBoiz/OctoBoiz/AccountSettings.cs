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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblEmployeeNumber = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtbxFirstNameNEW = new System.Windows.Forms.TextBox();
            this.txtbxLastNameNEW = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.picbxEmployeePicture = new System.Windows.Forms.PictureBox();
            this.txtbxDateofBirthNEW = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.radiobtnMale = new System.Windows.Forms.RadioButton();
            this.radiobtnFemale = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtbxNameofEmployeeAccount = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtbxDateofBirthOLD = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtbxLastNameOLD = new System.Windows.Forms.TextBox();
            this.txtbxFirstNameOLD = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.btnConfirmNewEmployee = new System.Windows.Forms.Button();
            this.btnSaveExistingEmployee = new System.Windows.Forms.Button();
            this.lblActivityLogAccount = new System.Windows.Forms.Label();
            this.lblAccountSettingsAccount = new System.Windows.Forms.Label();
            this.lblSettingsAccount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picbxEmployeePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADMIN - ACCOUNT SETTINGS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "CREATE NEW EMPLOYEE ACCOUNT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "EMPLOYEE DETAILS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(262, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "EMPLOYEE #";
            // 
            // lblEmployeeNumber
            // 
            this.lblEmployeeNumber.AutoSize = true;
            this.lblEmployeeNumber.Location = new System.Drawing.Point(338, 103);
            this.lblEmployeeNumber.Name = "lblEmployeeNumber";
            this.lblEmployeeNumber.Size = new System.Drawing.Size(31, 13);
            this.lblEmployeeNumber.TabIndex = 4;
            this.lblEmployeeNumber.Text = "_ _ _";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(84, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "FIRST NAME";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(221, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "LAST NAME";
            // 
            // txtbxFirstNameNEW
            // 
            this.txtbxFirstNameNEW.Location = new System.Drawing.Point(87, 144);
            this.txtbxFirstNameNEW.Name = "txtbxFirstNameNEW";
            this.txtbxFirstNameNEW.Size = new System.Drawing.Size(131, 20);
            this.txtbxFirstNameNEW.TabIndex = 7;
            // 
            // txtbxLastNameNEW
            // 
            this.txtbxLastNameNEW.Location = new System.Drawing.Point(224, 144);
            this.txtbxLastNameNEW.Name = "txtbxLastNameNEW";
            this.txtbxLastNameNEW.Size = new System.Drawing.Size(136, 20);
            this.txtbxLastNameNEW.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(84, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "UPLOAD PICTURE";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(221, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "DATE OF BIRTH ";
            // 
            // picbxEmployeePicture
            // 
            this.picbxEmployeePicture.Location = new System.Drawing.Point(87, 202);
            this.picbxEmployeePicture.Name = "picbxEmployeePicture";
            this.picbxEmployeePicture.Size = new System.Drawing.Size(131, 112);
            this.picbxEmployeePicture.TabIndex = 11;
            this.picbxEmployeePicture.TabStop = false;
            // 
            // txtbxDateofBirthNEW
            // 
            this.txtbxDateofBirthNEW.Location = new System.Drawing.Point(224, 201);
            this.txtbxDateofBirthNEW.Name = "txtbxDateofBirthNEW";
            this.txtbxDateofBirthNEW.Size = new System.Drawing.Size(136, 20);
            this.txtbxDateofBirthNEW.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(224, 232);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "SEX";
            // 
            // radiobtnMale
            // 
            this.radiobtnMale.AutoSize = true;
            this.radiobtnMale.Location = new System.Drawing.Point(227, 250);
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
            this.radiobtnFemale.Location = new System.Drawing.Point(287, 250);
            this.radiobtnFemale.Name = "radiobtnFemale";
            this.radiobtnFemale.Size = new System.Drawing.Size(67, 17);
            this.radiobtnFemale.TabIndex = 67;
            this.radiobtnFemale.TabStop = true;
            this.radiobtnFemale.Text = "FEMALE";
            this.radiobtnFemale.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(417, 81);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(201, 13);
            this.label10.TabIndex = 68;
            this.label10.Text = "EDIT EXISTING EMPLOYEE ACCOUNT";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(417, 104);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(177, 13);
            this.label11.TabIndex = 69;
            this.label11.Text = "NAME OF EMPLOYEE ACCOUNT: ";
            // 
            // txtbxNameofEmployeeAccount
            // 
            this.txtbxNameofEmployeeAccount.Location = new System.Drawing.Point(590, 101);
            this.txtbxNameofEmployeeAccount.Name = "txtbxNameofEmployeeAccount";
            this.txtbxNameofEmployeeAccount.Size = new System.Drawing.Size(136, 20);
            this.txtbxNameofEmployeeAccount.TabIndex = 70;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(417, 128);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(113, 13);
            this.label12.TabIndex = 71;
            this.label12.Text = "EMPLOYEE DETAILS";
            // 
            // txtbxDateofBirthOLD
            // 
            this.txtbxDateofBirthOLD.Location = new System.Drawing.Point(558, 226);
            this.txtbxDateofBirthOLD.Name = "txtbxDateofBirthOLD";
            this.txtbxDateofBirthOLD.Size = new System.Drawing.Size(136, 20);
            this.txtbxDateofBirthOLD.TabIndex = 79;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(421, 227);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 112);
            this.pictureBox1.TabIndex = 78;
            this.pictureBox1.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(555, 201);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(92, 13);
            this.label14.TabIndex = 77;
            this.label14.Text = "DATE OF BIRTH ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(418, 201);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(101, 13);
            this.label15.TabIndex = 76;
            this.label15.Text = "UPLOAD PICTURE";
            // 
            // txtbxLastNameOLD
            // 
            this.txtbxLastNameOLD.Location = new System.Drawing.Point(558, 169);
            this.txtbxLastNameOLD.Name = "txtbxLastNameOLD";
            this.txtbxLastNameOLD.Size = new System.Drawing.Size(136, 20);
            this.txtbxLastNameOLD.TabIndex = 75;
            // 
            // txtbxFirstNameOLD
            // 
            this.txtbxFirstNameOLD.Location = new System.Drawing.Point(421, 169);
            this.txtbxFirstNameOLD.Name = "txtbxFirstNameOLD";
            this.txtbxFirstNameOLD.Size = new System.Drawing.Size(131, 20);
            this.txtbxFirstNameOLD.TabIndex = 74;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(555, 152);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(68, 13);
            this.label16.TabIndex = 73;
            this.label16.Text = "LAST NAME";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(418, 152);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(72, 13);
            this.label17.TabIndex = 72;
            this.label17.Text = "FIRST NAME";
            // 
            // btnConfirmNewEmployee
            // 
            this.btnConfirmNewEmployee.Location = new System.Drawing.Point(285, 347);
            this.btnConfirmNewEmployee.Name = "btnConfirmNewEmployee";
            this.btnConfirmNewEmployee.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmNewEmployee.TabIndex = 83;
            this.btnConfirmNewEmployee.Text = "CONFIRM";
            this.btnConfirmNewEmployee.UseVisualStyleBackColor = true;
            // 
            // btnSaveExistingEmployee
            // 
            this.btnSaveExistingEmployee.Location = new System.Drawing.Point(651, 347);
            this.btnSaveExistingEmployee.Name = "btnSaveExistingEmployee";
            this.btnSaveExistingEmployee.Size = new System.Drawing.Size(75, 23);
            this.btnSaveExistingEmployee.TabIndex = 84;
            this.btnSaveExistingEmployee.Text = "SAVE";
            this.btnSaveExistingEmployee.UseVisualStyleBackColor = true;
            // 
            // lblActivityLogAccount
            // 
            this.lblActivityLogAccount.AutoSize = true;
            this.lblActivityLogAccount.Location = new System.Drawing.Point(675, 47);
            this.lblActivityLogAccount.Name = "lblActivityLogAccount";
            this.lblActivityLogAccount.Size = new System.Drawing.Size(80, 13);
            this.lblActivityLogAccount.TabIndex = 92;
            this.lblActivityLogAccount.Text = "ACTIVITY LOG";
            // 
            // lblAccountSettingsAccount
            // 
            this.lblAccountSettingsAccount.AutoSize = true;
            this.lblAccountSettingsAccount.Location = new System.Drawing.Point(555, 47);
            this.lblAccountSettingsAccount.Name = "lblAccountSettingsAccount";
            this.lblAccountSettingsAccount.Size = new System.Drawing.Size(116, 13);
            this.lblAccountSettingsAccount.TabIndex = 91;
            this.lblAccountSettingsAccount.Text = "ACCOUNT SETTINGS";
            // 
            // lblSettingsAccount
            // 
            this.lblSettingsAccount.AutoSize = true;
            this.lblSettingsAccount.Location = new System.Drawing.Point(490, 47);
            this.lblSettingsAccount.Name = "lblSettingsAccount";
            this.lblSettingsAccount.Size = new System.Drawing.Size(61, 13);
            this.lblSettingsAccount.TabIndex = 90;
            this.lblSettingsAccount.Text = "SETTINGS";
            // 
            // AccountSettings
            // 
            this.ClientSize = new System.Drawing.Size(781, 458);
            this.Controls.Add(this.lblActivityLogAccount);
            this.Controls.Add(this.lblAccountSettingsAccount);
            this.Controls.Add(this.lblSettingsAccount);
            this.Controls.Add(this.btnSaveExistingEmployee);
            this.Controls.Add(this.btnConfirmNewEmployee);
            this.Controls.Add(this.txtbxDateofBirthOLD);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtbxLastNameOLD);
            this.Controls.Add(this.txtbxFirstNameOLD);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtbxNameofEmployeeAccount);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.radiobtnFemale);
            this.Controls.Add(this.radiobtnMale);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtbxDateofBirthNEW);
            this.Controls.Add(this.picbxEmployeePicture);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtbxLastNameNEW);
            this.Controls.Add(this.txtbxFirstNameNEW);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblEmployeeNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AccountSettings";
            ((System.ComponentModel.ISupportInitialize)(this.picbxEmployeePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
