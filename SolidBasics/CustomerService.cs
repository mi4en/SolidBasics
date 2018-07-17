using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidBasics
{
    class CustomerService
    {
        CustomerBusinessLogic _customerBusinessLogic;

        public CustomerService()
        {
            _customerBusinessLogic = new CustomerBusinessLogic(new CustomerDataAccess());
        }

        public string GetCustomerName(int id)
        {
            return _customerBusinessLogic.GetCustomerName(id);
        }
    }
}
