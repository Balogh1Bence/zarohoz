using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepositoryPizza.Customer;
using ConnectToMysqlDatabase;
using System.Data;

namespace RepositoryPizza.CustomerRepo
{
    class CustomerRepos
    {
        List<Customer.Customer> customer;

        public CustomerRepos(List<Customer.Customer> customer)
        {
            customer = new List<Customer.Customer>();
            fillCustomerListFromDataBase();
        }

        private void fillCustomerListFromDataBase()
        {
            MySQLDatabaseInterface mdi = new MySQLDatabaseInterface();
            Adatbazis a = new Adatbazis();
            mdi = a.kapcsolodas();
            mdi.open();
            string query = "select * from pvevo";
            DataTable dt = mdi.getToDataTable(query);
            mdi.close();
            foreach(DataRow rw in dt.Rows)
            {

            }

        }
    }
}
