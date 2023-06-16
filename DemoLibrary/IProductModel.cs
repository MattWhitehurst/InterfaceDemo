using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    // this is an interface
    // interfaces are all always public. do not declare anything inside an interface public
    // also get; private set; doesnt work, delete the private set

    // contract that says whoever implements me will have a title property, a get and set that is a string...
    // agreement states basically what you are going to get if you implement the IProductModel
    public interface IProductModel
    {
        // signature line
        // a signature is just the important bits.  IMPORTANT return type, name 
        string Title { get; set; }

        // the property's signature IMPORTANT return type name
        bool HasOrderBeenCompleted { get; }
        // the method's signature IMPORTANT return type method name
        void ShipItem(CustomerModel customer);
    }
}
