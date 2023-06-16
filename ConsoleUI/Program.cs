using DemoLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    // creates a class called program
    class Program
    {
        // creates a "Main" file that is static and returns nothing
        static void Main(string[] args)
        {
            // creates a list called cart and assigns it things from the PhysicalProductModel and uses AddSampleMethod to populate the list
            List<IProductModel> cart = AddSampleData();
            // creates a customer variable and sets it equal to the result of the method get customer 
            // To populate this custmer model i have this get customer method
            CustomerModel customer = GetCustomer();

            // foreach ( class-variable "in" variable )
            // loops through the list physicalproductmodel and finds the prods that are in the list cart
            foreach (IProductModel prod in cart)
            {
                // for each prod, it will execute the code ship item and use the info stored in customer to tell it how to do that (what does ship item do?)
                prod.ShipItem(customer);
                // if a product is implemented in the digital product model add it to the local variable that we just created
                if (prod is IDigitalProductModel digital) 
                {
                    Console.WriteLine($"For the {digital.Title} you have {digital.TotalDownloadsLeft} downloads left.");
                }
            }

            // read the console line (why)
            Console.ReadLine();
        }
        // calls the class and executes the get customer method
        private static CustomerModel GetCustomer()
        {
            // returns the data input below to be the new output of customermodel class
            // gotta have some get, sets over in customer model
            return new CustomerModel
            {
                FirstName = "Matt",
                LastName = "Whitehurst",
                City = "Austin",
                EmailAddress = "matt@me.com",
                PhoneNumber = "555-1212"
            };
        }

        // adds these things the list physicalproductmodel
        // gotta have a  get,set for title
        private static List<IProductModel> AddSampleData()
        {
            List<IProductModel> output = new List<IProductModel>();

            output.Add(new PhysicalProductModel { Title = "Nerf Football" });
            output.Add(new PhysicalProductModel { Title = "IAmTimCorey T-Shirt" });
            output.Add(new PhysicalProductModel { Title = "Hard Drive" });
            output.Add(new DigitalProductModel { Title = "Lesson Source Code" });
            output.Add(new CourseProductModel { Title = ".NET Core Start to Finish" });


            return output;
        }
    }
}
