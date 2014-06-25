using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebapiOAuth.Repositories
{
    public class TempRepository : ITempRepository
    {
        public List<string> GetAll()
        {
            return new List<string> { "temp1", "temp2" };
        }
    }
}