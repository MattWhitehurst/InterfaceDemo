using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    // creates a public class called physical product model 
    // have to have what you are inheriting from be first, can only inherit from one parent
    // can put interfaces anywhere after, can inherit from a bunch of interfaces
    public class PhysicalProductModel : IProductModel
    {
        // place holder for the title 
        public string Title { get; set; }
        
        // placeholder for the bool value representing order completion
        public bool HasOrderBeenCompleted { get; private set; }

        // method called ship item which takes in a custemer model
        // returns nothing
        public void ShipItem(CustomerModel customer)
        {
            // only executes the code if the order has not been completed yet, then sets the code to true so it wont run this code again
            // this code is going to be ran a lot of times so we want to do it once and not have it do itself again
            if (HasOrderBeenCompleted == false)
            {
                Console.WriteLine($"Simulating shipping { Title } to { customer.FirstName } in { customer.City }");
                HasOrderBeenCompleted = true;
            }
        }
    }
}
