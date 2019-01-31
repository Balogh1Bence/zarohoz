using RepositoryPizza.Repository.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RepositoryPizza
{
    public partial class FormCustomer : Form
    {
        CustomerService cs;
        public FormCustomer()
        {
            cs = new CustomerService();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = cs.LoadCustomerData();
        }
        
      


    }
}
