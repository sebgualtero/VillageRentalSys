using System;
using System.Windows.Forms;
using static VillageRentalSys.Classess;

namespace VillageRentalSys
{
    public partial class MainForm : Form
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

        private RentalSystem rentalSystem;

        

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.tbCustomerID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.bt_AddCustomer = new System.Windows.Forms.Button();
            this.bt_DisplayCustomers = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbEquipmentID = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbEName = new System.Windows.Forms.TextBox();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.tbDCost = new System.Windows.Forms.TextBox();
            this.btAddEquipment = new System.Windows.Forms.Button();
            this.btDisplayEquipment = new System.Windows.Forms.Button();
            this.btDeleteEquipment = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tbRentalID = new System.Windows.Forms.TextBox();
            this.tbRCxID = new System.Windows.Forms.TextBox();
            this.tbRentDays = new System.Windows.Forms.TextBox();
            this.tbREquipID = new System.Windows.Forms.TextBox();
            this.btCreateRental = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.DisplayRentals = new System.Windows.Forms.Button();
            this.SaveAndClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer ID";
            // 
            // tbCustomerID
            // 
            this.tbCustomerID.Location = new System.Drawing.Point(12, 97);
            this.tbCustomerID.Name = "tbCustomerID";
            this.tbCustomerID.Size = new System.Drawing.Size(175, 31);
            this.tbCustomerID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(11, 159);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(176, 31);
            this.tbName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Contact Phone";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(10, 255);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(65, 25);
            this.email.TabIndex = 5;
            this.email.Text = "Email";
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(15, 221);
            this.tbPhone.MaxLength = 10;
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(151, 31);
            this.tbPhone.TabIndex = 6;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(11, 283);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(146, 31);
            this.tbEmail.TabIndex = 7;
            // 
            // bt_AddCustomer
            // 
            this.bt_AddCustomer.Location = new System.Drawing.Point(11, 427);
            this.bt_AddCustomer.Name = "bt_AddCustomer";
            this.bt_AddCustomer.Size = new System.Drawing.Size(201, 44);
            this.bt_AddCustomer.TabIndex = 8;
            this.bt_AddCustomer.Text = "Add Customer";
            this.bt_AddCustomer.UseVisualStyleBackColor = true;
            this.bt_AddCustomer.Click += new System.EventHandler(this.bt_AddCustomer_Click);
            // 
            // bt_DisplayCustomers
            // 
            this.bt_DisplayCustomers.Location = new System.Drawing.Point(12, 477);
            this.bt_DisplayCustomers.Name = "bt_DisplayCustomers";
            this.bt_DisplayCustomers.Size = new System.Drawing.Size(205, 47);
            this.bt_DisplayCustomers.TabIndex = 9;
            this.bt_DisplayCustomers.Text = "Display Customers";
            this.bt_DisplayCustomers.UseVisualStyleBackColor = true;
            this.bt_DisplayCustomers.Click += new System.EventHandler(this.bt_DisplayCustomers_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(240, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Equipment ID";
            // 
            // tbEquipmentID
            // 
            this.tbEquipmentID.Location = new System.Drawing.Point(245, 97);
            this.tbEquipmentID.Name = "tbEquipmentID";
            this.tbEquipmentID.Size = new System.Drawing.Size(176, 31);
            this.tbEquipmentID.TabIndex = 11;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(240, 131);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(68, 25);
            this.Label5.TabIndex = 12;
            this.Label5.Text = "Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(240, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Description";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(240, 289);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "Daily Cost";
            // 
            // tbEName
            // 
            this.tbEName.Location = new System.Drawing.Point(245, 158);
            this.tbEName.Name = "tbEName";
            this.tbEName.Size = new System.Drawing.Size(176, 31);
            this.tbEName.TabIndex = 15;
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(245, 218);
            this.tbDescription.MinimumSize = new System.Drawing.Size(176, 62);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(176, 62);
            this.tbDescription.TabIndex = 16;
            // 
            // tbDCost
            // 
            this.tbDCost.Location = new System.Drawing.Point(245, 317);
            this.tbDCost.Name = "tbDCost";
            this.tbDCost.Size = new System.Drawing.Size(176, 31);
            this.tbDCost.TabIndex = 17;
            // 
            // btAddEquipment
            // 
            this.btAddEquipment.Location = new System.Drawing.Point(245, 427);
            this.btAddEquipment.Name = "btAddEquipment";
            this.btAddEquipment.Size = new System.Drawing.Size(176, 44);
            this.btAddEquipment.TabIndex = 18;
            this.btAddEquipment.Text = "Add Equipment";
            this.btAddEquipment.UseVisualStyleBackColor = true;
            this.btAddEquipment.Click += new System.EventHandler(this.btAddEquipment_Click);
            // 
            // btDisplayEquipment
            // 
            this.btDisplayEquipment.Location = new System.Drawing.Point(245, 477);
            this.btDisplayEquipment.Name = "btDisplayEquipment";
            this.btDisplayEquipment.Size = new System.Drawing.Size(176, 69);
            this.btDisplayEquipment.TabIndex = 19;
            this.btDisplayEquipment.Text = "Display Equipment";
            this.btDisplayEquipment.UseVisualStyleBackColor = true;
            this.btDisplayEquipment.Click += new System.EventHandler(this.btDisplayEquipment_Click);
            // 
            // btDeleteEquipment
            // 
            this.btDeleteEquipment.Location = new System.Drawing.Point(245, 552);
            this.btDeleteEquipment.Name = "btDeleteEquipment";
            this.btDeleteEquipment.Size = new System.Drawing.Size(176, 65);
            this.btDeleteEquipment.TabIndex = 20;
            this.btDeleteEquipment.Text = "Delete Equipment";
            this.btDeleteEquipment.UseVisualStyleBackColor = true;
            this.btDeleteEquipment.Click += new System.EventHandler(this.btDeleteEquipment_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(887, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(9, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 31);
            this.label8.TabIndex = 22;
            this.label8.Text = "Customers";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(239, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(152, 31);
            this.label9.TabIndex = 23;
            this.label9.Text = "Equipment";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(557, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 31);
            this.label10.TabIndex = 24;
            this.label10.Text = "Rentals";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(563, 68);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 25);
            this.label11.TabIndex = 25;
            this.label11.Text = "Rental ID";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(563, 128);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(125, 25);
            this.label12.TabIndex = 26;
            this.label12.Text = "Rental Date";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(563, 190);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(130, 25);
            this.label13.TabIndex = 27;
            this.label13.Text = "Customer ID";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(563, 255);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(112, 25);
            this.label14.TabIndex = 28;
            this.label14.Text = "Rent Days";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(563, 317);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(140, 25);
            this.label15.TabIndex = 29;
            this.label15.Text = "Equipment ID";
            // 
            // tbRentalID
            // 
            this.tbRentalID.Location = new System.Drawing.Point(568, 96);
            this.tbRentalID.Name = "tbRentalID";
            this.tbRentalID.Size = new System.Drawing.Size(150, 31);
            this.tbRentalID.TabIndex = 30;
            // 
            // tbRCxID
            // 
            this.tbRCxID.Location = new System.Drawing.Point(568, 218);
            this.tbRCxID.Name = "tbRCxID";
            this.tbRCxID.Size = new System.Drawing.Size(150, 31);
            this.tbRCxID.TabIndex = 32;
            // 
            // tbRentDays
            // 
            this.tbRentDays.Location = new System.Drawing.Point(568, 282);
            this.tbRentDays.Name = "tbRentDays";
            this.tbRentDays.Size = new System.Drawing.Size(150, 31);
            this.tbRentDays.TabIndex = 33;
            // 
            // tbREquipID
            // 
            this.tbREquipID.Location = new System.Drawing.Point(563, 345);
            this.tbREquipID.Name = "tbREquipID";
            this.tbREquipID.Size = new System.Drawing.Size(155, 31);
            this.tbREquipID.TabIndex = 34;
            // 
            // btCreateRental
            // 
            this.btCreateRental.Location = new System.Drawing.Point(563, 427);
            this.btCreateRental.Name = "btCreateRental";
            this.btCreateRental.Size = new System.Drawing.Size(155, 44);
            this.btCreateRental.TabIndex = 36;
            this.btCreateRental.Text = "Create Rental";
            this.btCreateRental.UseVisualStyleBackColor = true;
            this.btCreateRental.Click += new System.EventHandler(this.btCreateRental_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "MM/DD/YYYY";
            this.dateTimePicker1.Location = new System.Drawing.Point(568, 156);
            this.dateTimePicker1.MinDate = new System.DateTime(2024, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(300, 31);
            this.dateTimePicker1.TabIndex = 37;
            this.dateTimePicker1.Value = new System.DateTime(2024, 4, 15, 15, 36, 49, 0);
            // 
            // DisplayRentals
            // 
            this.DisplayRentals.Location = new System.Drawing.Point(563, 477);
            this.DisplayRentals.Name = "DisplayRentals";
            this.DisplayRentals.Size = new System.Drawing.Size(155, 69);
            this.DisplayRentals.TabIndex = 38;
            this.DisplayRentals.Text = "Display Rentals";
            this.DisplayRentals.UseVisualStyleBackColor = true;
            this.DisplayRentals.Click += new System.EventHandler(this.DisplayRentals_Click);
            // 
            // SaveAndClose
            // 
            this.SaveAndClose.ForeColor = System.Drawing.Color.Red;
            this.SaveAndClose.Location = new System.Drawing.Point(792, 552);
            this.SaveAndClose.Name = "SaveAndClose";
            this.SaveAndClose.Size = new System.Drawing.Size(170, 65);
            this.SaveAndClose.TabIndex = 39;
            this.SaveAndClose.Text = "Save And Close";
            this.SaveAndClose.UseVisualStyleBackColor = true;
            this.SaveAndClose.Click += new System.EventHandler(this.SaveAndClose_Click);
            // 
            // MainForm
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(974, 629);
            this.Controls.Add(this.SaveAndClose);
            this.Controls.Add(this.DisplayRentals);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btCreateRental);
            this.Controls.Add(this.tbREquipID);
            this.Controls.Add(this.tbRentDays);
            this.Controls.Add(this.tbRCxID);
            this.Controls.Add(this.tbRentalID);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btDeleteEquipment);
            this.Controls.Add(this.btDisplayEquipment);
            this.Controls.Add(this.btAddEquipment);
            this.Controls.Add(this.tbDCost);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.tbEName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.tbEquipmentID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bt_DisplayCustomers);
            this.Controls.Add(this.bt_AddCustomer);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.email);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbCustomerID);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 700);
            this.MinimumSize = new System.Drawing.Size(1000, 700);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Village Rentals";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

}

        private Label label1;
        private TextBox tbCustomerID;
        private Label label2;
        private TextBox tbName;
        private Label label3;
        private Label email;
        private TextBox tbPhone;
        private TextBox tbEmail;
        private Button bt_AddCustomer;
        private Button bt_DisplayCustomers;
        private Label label4;
        private TextBox tbEquipmentID;
        private Label Label5;
        private Label label6;
        private Label label7;
        private TextBox tbEName;
        private TextBox tbDescription;
        private TextBox tbDCost;
        private Button btAddEquipment;
        private Button btDisplayEquipment;
        private Button btDeleteEquipment;
        private ToolTip toolTip1;
        private PictureBox pictureBox1;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private TextBox tbRentalID;
        private TextBox tbRCxID;
        private TextBox tbRentDays;
        private TextBox tbREquipID;
        private Button btCreateRental;
        private DateTimePicker dateTimePicker1;
        private Button DisplayRentals;
        private Button SaveAndClose;
    }

        #endregion

 
    }
