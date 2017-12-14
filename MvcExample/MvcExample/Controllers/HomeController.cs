using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MvcExample.Data;
using MvcExample.Models;

namespace MvcExample.Controllers
{
	public class BasicCustomerInformationModel {
		public string CustomerID { get; set; }
		public string CompanyName { get; set; }
	}

    public class HomeController : Controller
    {
		private readonly IDataRepository _dataProvider;

		public HomeController(IDataRepository dataProvider) {
			this._dataProvider = dataProvider;
		}

        public IActionResult Index()
        {
			//Getting the data.. no matter what is the source
			var customers = _dataProvider.GetAllCustomers();

			//mapping to our special model because we do not need any data beside id and companyname
			var infoForCustomers = new List<BasicCustomerInformationModel>();
			foreach(var customer in customers){
				infoForCustomers.Add(new BasicCustomerInformationModel{
					CustomerID = customer.CustomerID,
					CompanyName = customer.CompanyName
				});
			}

			//pass the right model to the view
            return View(infoForCustomers);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
