using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidBasics
{
    class CustomerBusinessLogic
    {
        ICustomerDataAccess _custDataAccess;
       
        public CustomerBusinessLogic(ICustomerDataAccess customerDataAccess)
        {
            _custDataAccess = customerDataAccess;
        }
        public CustomerBusinessLogic()
        {
            _custDataAccess = new CustomerDataAccess();
        }

        public string GetCustomerName(int id)
        {
            return _custDataAccess.GetCustomerName(id);
        }
    }
}
