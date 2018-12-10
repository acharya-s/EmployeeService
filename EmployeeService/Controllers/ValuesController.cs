﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EmployeeService.Controllers
{
	public class ValuesController : ApiController
	{
		static List<string> strings = new List<string>
		{
			"value0", "value1", "value2"
		};

		// GET api/values
		public IEnumerable<string> Get()
		{
			return strings;
		}

		// GET api/values/5
		public string Get(int id)
		{
			return strings[id];
		}

		// POST api/values
		// Used Fiddler to implement adding
		public void Post([FromBody]string value)
		{
			strings.Add(value);
		}

		// PUT api/values/5
		// Used Fiddler to implement insert
		public void Put(int id, [FromBody]string value)
		{
			strings[id] = value;
		}

		// DELETE api/values/5
		// Used Fiddler to implement remove
		public void Delete(int id)
		{
			strings.RemoveAt(id);
		}
	}
}