using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidBasics
{
    class DataAccessFactory
    {
        //public static DataAccess GetDataAccessObj() - this is replaced by the interface
        public static ICustomerDataAccess GetDataAccessObj()
        {
            return new CustomerDataAccess();
        }
    }
}
