
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RepositoryPizza.TableClasses;
using ConnectToMysqlDatabase;
using System.Data;

namespace RepositoryPizza.Repository
{
    class CustomersRepo
    {
        List<Customer> customers;
        DataTable dt;
        public CustomersRepo()
        {
            customers = new List<Customer>();
            fillCustomersListFromDatabase();
        }
        public DataTable getCustomersDataTable()
        {
            dt = new DataTable();
            dt.Columns.Add("Azon",typeof(int));
            dt.Columns.Add("Vevő név",typeof(string));
            dt.Columns.Add("vevő cím",typeof(string));
            foreach (Customer c in customers)
            {
                dt.Rows.Add(c.getId(), c.getName(), c.getAddress());

            }

            return dt;
        }

        private void fillCustomersListFromDatabase()
        {
            MySQLDatabase md = new MySQLDatabase();
            MySQLDatabaseInterface mdi = md.getDatabaseInterface();
            mdi.open();
            string query = "SELECT * FROM pvevo ";
            DataTable dtCustomer = mdi.getToDataTable(query);
            mdi.close();

            foreach(DataRow row in dtCustomer.Rows)
            {
                int customerID = Convert.ToInt32(row["vazon"].ToString());
                string customerName = row["vnev"].ToString();
                string customerAddress = row["vcim"].ToString();
                Customer c = new Customer(customerID, customerName, customerAddress);
                customers.Add(c);
            }

        }


    }
}
