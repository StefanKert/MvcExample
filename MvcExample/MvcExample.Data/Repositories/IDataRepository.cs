using System.Collections.Generic;

namespace MvcExample.Data
{
	public interface IDataRepository {
		List<Customer> GetAllCustomers();
	}
}
