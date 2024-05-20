namespace DAL.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DAL.Models.ProjectContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DAL.Models.ProjectContext context)
        {
            Random random = new Random();

            // Seeding random data for Admins
            for (int i = 0; i < 10; i++)
            {
                context.Admins.AddOrUpdate(new DAL.Models.Admin
                {
                    Name = "Admin" + i,
                    Username = "admin" + i,
                    Password = "password" + i,
                    Email = "admin" + i + "@example.com",
                });
            }

            // Seeding random data for Deliverymen
            for (int i = 0; i < 10; i++)
            {
                context.Deliverymans.AddOrUpdate(new DAL.Models.Deliveryman
                {
                    Name = "Deliveryman" + i,
                    Username = "deliveryman" + i,
                    Password = "password" + i,
                    Rating = random.Next(1, 6),
                    Location = "Location" + i,
                    DeliveryManStatus = "Active",
                    MobileNumber = "1234567890",
                    dtId = random.Next(1, 5) // assuming you have at least 4 deliveryman types
                });
            }

            // Seeding random data for Users
            for (int i = 0; i < 10; i++)
            {
                context.Users.AddOrUpdate(new DAL.Models.User
                {
                    Name = "User" + i,
                    Username = "user" + i,
                    DOB = DateTime.Now.AddYears(-random.Next(18, 50)),
                    Email = "user" + i + "@example.com",
                    Gender = (i % 2 == 0) ? "Male" : "Female",
                    Password = "password" + i,
                    Address = "Address" + i,
                    MobileNumber = "0987654321",
                });
            }

            context.SaveChanges();
        }

    }
}
