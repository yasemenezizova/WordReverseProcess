using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using WordReverseProcess.Utilities;

namespace WordReverseProcess.Controller
{
    public class HomeController : ApiController
    {
        [HttpGet]
        [Route("home/all/{word}")]
        public IHttpActionResult GetAll(string word)
        {
            string reversedWord = string.Empty;
            try
            {
                if (!string.IsNullOrEmpty(word))
                    reversedWord = WordProcess.ReverseItem(word);
            }
            catch (Exception)
            {
                throw new Exception("Error has eccured!");
            }
            return Ok(reversedWord);
        }
    }
}
