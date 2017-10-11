using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace AspNetCoreDemoApp.Controllers
{
	[Route("api/[controller]")]
	public class ValuesController : Controller
	{
		// GET: api/values
		[HttpGet]
		public IEnumerable<string> Get()
		{
			return new[] { "Fuck Cason", "Fuck Haven" };
		}

		// GET api/values/5
		[HttpGet("{id}")]
		public string Get(int id)
		{
			return "value";
		}
	}
}