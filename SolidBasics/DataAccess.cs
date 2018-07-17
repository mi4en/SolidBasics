using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidBasics
{
    class DataAccess //this class will become CustomerDataAccess with the further impl of the DIP
    {
        public DataAccess()
        {

        }

        public string getCustomerName(int id)
        {
            return "Dummy Customer Name"; // get it from real app DB here
        }


    }
}
