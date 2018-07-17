using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidBasics
{
    class CustomerDataAccess : ICustomerDataAccess
    {
        public CustomerDataAccess()
        {

        }

        public string GetCustomerName(int id)
        {
            return ("Dummy customer name");
        }
    }
}
