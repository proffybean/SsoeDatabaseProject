using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace DataLayer
{
    public class BusinessLayer
    {
        public IEnumerable<Customer> Customers()
        {
            var customers = new List<Customer>();
            using (SqlConnection con = new SqlConnection())
            {
                string s = "select * from Customer";
                SqlCommand cmd = new SqlCommand(s, con);
                

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    var foo = new Customer();
                    foo.customerId = Convert.ToInt32(reader[0]);
                    foo.LastName = Convert.ToString(reader[1]);
                    foo.FirstName = Convert.ToString(reader[2]);
                    foo.EmailAddress = Convert.ToString(reader[3]);
                    customers.Add(foo);
                }
            }

            return customers;
        }

        
    }
}
