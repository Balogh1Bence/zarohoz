using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPizza.Repository.Service
{
    class CustomerService
    {
        CustomersRepo cr;

        public CustomerService()
        {
            cr = new CustomersRepo();
        }
        public DataTable LoadCustomerData()
        {

            return cr.getCustomersDataTable();
        }
    }
}
