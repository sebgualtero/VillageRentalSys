using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillageRentalSys
{
    public class Classess
    {
        // Class representing a Customer
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

        // Class representing Equipment
        public class Equipment
        {
            public int EquipmentID { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public double DailyRentalCost { get; set; }
            public string Status { get; set; }

            public Equipment(int equipmentID, string name, string description, double dailyRentalCost, string status)
            {
                EquipmentID = equipmentID;
                Name = name;
                Description = description;
                DailyRentalCost = dailyRentalCost;
                Status = status;
            }

            public override string ToString()
            {
                return $"Equipment ID: {EquipmentID}\nName: {Name}\nDescription: {Description}\nDaily Rental Cost: {DailyRentalCost}\nStatus: {Status}";
            }
        }

        // Class representing a Rental
        public class Rental
        {
            public int RentalID { get; set; }
            public DateTime RentalDate { get; set; }
            public int RentalDays { get; set; }
            public int CustomerID { get; set; } // Reference to Customer
            public int EquipmentID { get; set; } // Reference to Equipment
            public double RentalPrice { get; set; }

            public Rental(int rentalID, DateTime rentalDate, int rentalDays, int customerID, int equipmentID, double rentalPrice)
            {
                RentalID = rentalID;
                RentalDate = rentalDate;
                RentalDays = rentalDays;
                CustomerID = customerID;
                EquipmentID = equipmentID;
                RentalPrice = rentalPrice;
            }

            public override string ToString()
            {
                return $"Rental ID: {RentalID}\nRental Date: {RentalDate}\nRental Days: {RentalDays}\nCustomer ID: {CustomerID}\nEquipment ID: {EquipmentID}\nRental Price: {RentalPrice}";
            }

        }

        // Main class to manage rentals and customers
        public class RentalSystem
        {
            private List<Customer> customers;
            private List<Equipment> stock;
            private List<Rental> rentals;

            public RentalSystem()
            {
                customers = new List<Customer>();
                stock = new List<Equipment>();
                rentals = new List<Rental>();
            }

            // Methods to add/delete customers and equipment, process rentals, display data, etc.
            // Implement these methods based on your requirements.

            public void AddCustomer(Customer customer)
            {
                customers.Add(customer);
            }

            public void AddEquipment(Equipment equipment)
            {
                stock.Add(equipment);
            }

            public void deleteEquipment(Equipment equipment)
            {
                stock.Remove(equipment);
            }

            public string DisplayCustomers()
            {
                StringBuilder sb = new StringBuilder();
                foreach (Customer customer in customers)
                {
                    sb.AppendLine(customer.ToString());
                    sb.AppendLine();
                }
                return sb.ToString();
            }

            public string DisplayEquipment()
            {
                StringBuilder sb = new StringBuilder();
                foreach (Equipment equipment in stock)
                {
                    sb.AppendLine(equipment.ToString());
                    sb.AppendLine();
                }
                return sb.ToString();
            }

            public void createRental(int rentalID, DateTime rentalDate, int rentalDays, int customerID, int equipmentID)
            {
                // Check if customer and equipment exist
                Customer customer = customers.FirstOrDefault(c => c.CustomerID == customerID);
                Equipment equipment = stock.FirstOrDefault(e => e.EquipmentID == equipmentID);

                if (customer == null)
                {
                    throw new Exception("Customer not found");
                }

                if (equipment == null)
                {
                    throw new Exception("Equipment not found");
                }

                // Calculate rental price
                double rentalPrice = equipment.DailyRentalCost * rentalDays;

                // Create rental object
                Rental rental = new Rental(rentalID, rentalDate, rentalDays, customerID, equipmentID, rentalPrice);

                // Add rental to the list
                rentals.Add(rental);

                // Update equipment status
                equipment.Status = "Rented";
            }


        }
    }
}
