using System.Collections.Generic;

namespace MvcExample.Data
{
	public class HardcodedDataRepository : IDataRepository
	{
		public static List<Customer> _hardcodedListOfCustomers = new List<Customer>
		{
			new Customer {
				CustomerID = "ALFKI",
				CompanyName = "Alfreds Futterkiste",
				ContactName = "Maria Anders",
				ContactTitle = "Sales Representative",
				Address = "Obere Str.56",
				City = "Berlin",
				Region = null,
				PostalCode = "122209",
				Country = "Germany",
				Phone = "030-0074321",
				Fax = "030-0076545"
			},
			new Customer {
				CustomerID = "ANATR",
				CompanyName = "Ana Trujillo Emparedados y helados",
				ContactName = "Ana Trujillo",
				ContactTitle = "Owner",
				Address = "Avda. de la Constitución 2222",
				City = "México D.F.",
				Region = null,
				PostalCode = "05021",
				Country = "Mexico",
				Phone = "(5) 555-4729",
				Fax = "(5) 555-3745"
			}
		};

		public List<Customer> GetAllCustomers() {
			return _hardcodedListOfCustomers;
		}
	}
}

