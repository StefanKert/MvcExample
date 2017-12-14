using Microsoft.EntityFrameworkCore;
using MvcExample.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MvcExample.Data
{

	public class EntityFrameworkDataRepository : IDataRepository
	{
		public List<Customer> GetAllCustomers() {
			using (var db = new NorthwindContext()){
				return db.Customers.ToList();
			}
		}
	}

	public class NorthwindContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Constants.CONNECTIONSTRING);
        } 
    }
}

