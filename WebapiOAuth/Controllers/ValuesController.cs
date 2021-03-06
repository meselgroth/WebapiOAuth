﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebapiOAuth.Repositories;

namespace WebapiOAuth.Controllers
{
    //[Authorize]
    public class ValuesController : ApiController
    {
        ITempRepository _tempRepository;

        public ValuesController(ITempRepository tempRepository)
        {
            _tempRepository = tempRepository;
        }

        // GET api/values
        public IEnumerable<string> Get()
        {
            return _tempRepository.GetAll();
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
