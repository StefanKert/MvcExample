using MvcExample.Data.Repositories;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace MvcExample.Data
{
	public class AdonetDataRepository : IDataRepository
	{
		public AdonetDataRepository() {

		}

		public List<Customer> GetAllCustomers() {
			var customers = new List<Customer>();
			using (var connection = new SqlConnection(Constants.CONNECTIONSTRING)){
				connection.Open();
				var command = new SqlCommand("SELECT * FROM Customers", connection);
				var dataReader = command.ExecuteReader();
				while(dataReader.Read()) {
					var customer = new Customer();
					customer.CustomerID = dataReader["CustomerID"].ToString();
					customer.CompanyName = dataReader["CompanyName"].ToString();
					customer.ContactName = dataReader["ContactName"].ToString();
					customer.ContactTitle = dataReader["ContactTitle"].ToString();
					customer.Address = dataReader["Address"].ToString();
					customer.City = dataReader["City"].ToString();
					customer.Region = dataReader["Region"]?.ToString();;
					customer.PostalCode = dataReader["PostalCode"].ToString();
					customer.Country = dataReader["Country"].ToString();
					customer.Phone = dataReader["Phone"].ToString();
					customer.Fax = dataReader["Fax"].ToString();
					customers.Add(customer);
				}
			}
			return customers;
		}
	}
}

