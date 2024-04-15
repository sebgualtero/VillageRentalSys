using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VillageRentalSys
{
    public partial class MainForm : Form
    {

        private List<Customer> villageCustomers;
        private List<Equipment> villageEquipment;
        private List<Rental> villageRentals;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            villageCustomers = new List<Customer>();
            villageEquipment = new List<Equipment>();
            villageRentals = new List<Rental>();
            PopulateCustomers();
            PopulateEquipment();
            PopulateRentals();
        }

        public class Customer
        {
            public int CustomerID { get; set; }
            public string Name { get; set; }
            public string ContactPhone { get; set; }
            public string Email { get; set; }

            public Customer(int customerID, string name, string contactPhone, string email)
            {
                CustomerID = customerID;
                Name = name;
                ContactPhone = contactPhone;
                Email = email;
            }
            public override string ToString()
            {
                return $"Customer ID: {CustomerID}\nName: {Name}\nContact Phone: {ContactPhone}\nEmail: {Email}";
            }

        }
        public void PopulateCustomers()
        {
            //loads the path for a file called customers.csv within the project package and the resources folder
            string basedir = AppDomain.CurrentDomain.BaseDirectory;
            DirectoryInfo d = new DirectoryInfo(basedir);

            string path = d.Parent.Parent.FullName + "\\Resources\\customers.csv";

            //reads the file and adds the data to the list
            using (TextFieldParser parser = new TextFieldParser(path))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");
                while (!parser.EndOfData)
                {
                    string[] fields = parser.ReadFields();
                    int customerID = Convert.ToInt32(fields[0]);
                    string name = fields[1];
                    string contactPhone = fields[2];
                    string email = fields[3];

                    Customer newcustomer = new Customer(customerID, name, contactPhone, email);

                    AddCustomer(newcustomer);
                }
            }         
        }

        public class Equipment
        {
            public int EquipmentID { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public double DailyRentalCost { get; set; }

            public Equipment(int equipmentID, string name, string description, double dailyRentalCost)
            {
                EquipmentID = equipmentID;
                Name = name;
                Description = description;
                DailyRentalCost = dailyRentalCost;
            }

            public override string ToString()
            {
                return $"Equipment ID: {EquipmentID}\nName: {Name}\nDescription: {Description}\nDaily Rental Cost: {DailyRentalCost}";
            }
        }

        public void PopulateEquipment()
        {
            string basedir = AppDomain.CurrentDomain.BaseDirectory;
            DirectoryInfo d = new DirectoryInfo(basedir);

            string path = d.Parent.Parent.FullName + "\\Resources\\equipment.csv";

            using (TextFieldParser parser = new TextFieldParser(path))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");
                while (!parser.EndOfData)
                {
                    string[] fields = parser.ReadFields();
                    int equipmentID = Convert.ToInt32(fields[0]);
                    string name = fields[1];
                    string description = fields[2];
                    double dailyRentalCost = Convert.ToDouble(fields[3]);

                    Equipment newequipment = new Equipment(equipmentID, name, description, dailyRentalCost);

                    AddEquipment(newequipment);
                }
            }
        }

        public class Rental
        {
            public int RentalID { get; set; }
            public DateTime RentalDate { get; set; }
            public int RentalDays { get; set; }
            public int CustomerID { get; set; } // Reference to Customer
            public int EquipmentID { get; set; } // Reference to Equipment
            public double RentalPrice { get; set; }

            public Rental(int rentalID, DateTime rentalDate, int rentalDays, int customerID, int equipmentID)
            {
                RentalID = rentalID;
                RentalDate = rentalDate;
                RentalDays = rentalDays;
                CustomerID = customerID;
                EquipmentID = equipmentID;
            }

            public override string ToString()
            {
                return $"Rental ID: {RentalID}\nRental Date: {RentalDate}\nRental Days: {RentalDays}\nCustomer ID: {CustomerID}\nEquipment ID: {EquipmentID}";
            }

        }

        public void PopulateRentals()
        {
            string basedir = AppDomain.CurrentDomain.BaseDirectory;
            DirectoryInfo d = new DirectoryInfo(basedir);

            string path = d.Parent.Parent.FullName + "\\Resources\\rentals.csv";

            using (TextFieldParser parser = new TextFieldParser(path))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");
                while (!parser.EndOfData)
                {
                    string[] fields = parser.ReadFields();
                    int rentalID = Convert.ToInt32(fields[0]);
                    DateTime rentalDate = Convert.ToDateTime(fields[1]);
                    int rentalDays = Convert.ToInt32(fields[2]);
                    int customerID = Convert.ToInt32(fields[3]);
                    int equipmentID = Convert.ToInt32(fields[4]);

                    Rental newrental = new Rental(rentalID, rentalDate, rentalDays, customerID, equipmentID);

                    AddRental(newrental);
                }
            }
        }


        public void AddCustomer(Customer customer)
        {
            villageCustomers.Add(customer);
        }

        public void AddEquipment(Equipment equipment)
        {
            villageEquipment.Add(equipment);
        }

        public void AddRental(Rental rental)
        {
            villageRentals.Add(rental);
        }

        private void bt_AddCustomer_Click(object sender, EventArgs e)
        {
            int customerID = Convert.ToInt32(tbCustomerID.Text);
            string name = tbName.Text;
            string contactPhone = tbPhone.Text;
            string email = tbEmail.Text;

            Customer newcustomer = new Customer(customerID, name, contactPhone, email);

            AddCustomer(newcustomer);

            MessageBox.Show("Customer added successfully");

            //clear textboxes
            tbCustomerID.Text = "";
            tbName.Text = "";
            tbPhone.Text = "";
            tbEmail.Text = "";

        }

        private void bt_DisplayCustomers_Click(object sender, EventArgs e)
        {

            string allcustomers = "";
            string title = "Customers\n\n";

            foreach (Customer customer in villageCustomers)
            {
                allcustomers += customer.ToString() + "\n\n";
            }

            MessageBox.Show(allcustomers, title);
        }

        private void btAddEquipment_Click(object sender, EventArgs e)
        {
            int equipmentID = Convert.ToInt32(tbEquipmentID.Text);
            string name = tbEName.Text;
            string description = tbDescription.Text;
            double dailyRentalCost = Convert.ToDouble(tbDCost.Text);

            Equipment newequipment = new Equipment(equipmentID, name, description, dailyRentalCost);

            AddEquipment(newequipment);

            MessageBox.Show("Equipment added successfully");

            //clear textboxes
            tbEquipmentID.Text = "";
            tbEName.Text = "";
            tbDescription.Text = "";
            tbDCost.Text = "";
        }

        private void btDisplayEquipment_Click(object sender, EventArgs e)
        {
            string allequipment = "";
            string title = "Equipment\n\n";

            foreach (Equipment equipment in villageEquipment)
            {
                allequipment += equipment.ToString() + "\n\n";
            }

            MessageBox.Show(allequipment, title);
        }

        private void btDeleteEquipment_Click(object sender, EventArgs e)
        {
            int equipmentID = Convert.ToInt32(tbEquipmentID.Text);
            Equipment equipment = villageEquipment.FirstOrDefault(eq => eq.EquipmentID == equipmentID);

            if (equipment == null)
            {
                MessageBox.Show("Equipment not found");
            }
            else
            {
                villageEquipment.Remove(equipment);
                MessageBox.Show("Equipment deleted successfully");
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btCreateRental_Click(object sender, EventArgs e)
        {
            int rentalID = Convert.ToInt32(tbRentalID.Text);
            DateTime rentalDate = dateTimePicker1.Value;
            int rentalDays = Convert.ToInt32(tbRentDays.Text);
            int customerID = Convert.ToInt32(tbRCxID.Text);
            int equipmentID = Convert.ToInt32(tbREquipID.Text);

            // Check if customer and equipment exist
            Customer customer = villageCustomers.FirstOrDefault(c => c.CustomerID == customerID);
            Equipment equipment = villageEquipment.FirstOrDefault(eq => eq.EquipmentID == equipmentID);

            if (customer == null)
            {
                MessageBox.Show("Customer not found");
                return;
            }

            if (equipment == null)
            {
                MessageBox.Show("Equipment not found");
                return;
            }

            // Calculate rental price
            double rentalPrice = equipment.DailyRentalCost * rentalDays;

            // Create rental object
            Rental rental = new Rental(rentalID, rentalDate, rentalDays, customerID, equipmentID);

            AddRental(rental);

            MessageBox.Show("Rental created successfully");

            //clear textboxes
            tbRentalID.Text = "";
            tbRentDays.Text = "";
            tbRCxID.Text = "";
            tbREquipID.Text = "";
        }

        private void DisplayRentals_Click(object sender, EventArgs e)
        {
            string allrentals = "";
            string title = "Rentals\n\n";

            foreach (Rental rental in villageRentals)
            {
                allrentals += rental.ToString();
                allrentals += "\nRental Price: " + (villageEquipment.FirstOrDefault(eq => eq.EquipmentID == rental.EquipmentID).DailyRentalCost * rental.RentalDays) + "\n\n";
            }
            MessageBox.Show(allrentals, title);
        }

        public void SaveCustomersListToCSV()
        {
            string basedir = AppDomain.CurrentDomain.BaseDirectory;
            DirectoryInfo d = new DirectoryInfo(basedir);

            string path = d.Parent.Parent.FullName + "\\Resources\\customers.csv";

            using (StreamWriter writer = new StreamWriter(path))
            {
                foreach (Customer customer in villageCustomers)
                {
                    writer.WriteLine($"{customer.CustomerID},{customer.Name},{customer.ContactPhone},{customer.Email}");
                }
            }
        }

        public void SaveEquipmentListToCSV()
        {
            string basedir = AppDomain.CurrentDomain.BaseDirectory;
            DirectoryInfo d = new DirectoryInfo(basedir);

            string path = d.Parent.Parent.FullName + "\\Resources\\equipment.csv";

            using (StreamWriter writer = new StreamWriter(path))
            {
                foreach (Equipment equipment in villageEquipment)
                {
                    writer.WriteLine($"{equipment.EquipmentID},{equipment.Name},{equipment.Description},{equipment.DailyRentalCost}");
                }
            }
        }

        public void SaveRentalsListToCSV()
        {
            string basedir = AppDomain.CurrentDomain.BaseDirectory;
            DirectoryInfo d = new DirectoryInfo(basedir);

            string path = d.Parent.Parent.FullName + "\\Resources\\rentals.csv";

            using (StreamWriter writer = new StreamWriter(path))
            {
                foreach (Rental rental in villageRentals)
                {
                    writer.WriteLine($"{rental.RentalID},{rental.RentalDate},{rental.RentalDays},{rental.CustomerID},{rental.EquipmentID}");
                }
            }
        }

        private void SaveAndClose_Click(object sender, EventArgs e)
        {
            SaveCustomersListToCSV();
            SaveEquipmentListToCSV();
            SaveRentalsListToCSV();
            this.Close();
        }
    }
}
