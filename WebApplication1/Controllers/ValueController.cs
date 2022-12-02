//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;

//namespace WebApplication1.Controllers
//{

//    [ApiController]
//    [Route("Get")]
//    public class ValueController : ControllerBase
//    {
//        static List<string> strings =
//            new List<string>() { "values0", "values1", "values2" };

      
//        public IEnumerable<string> Get()
//        {
//            return strings;

//        }
//        [HttpGet("get/{id}")]
//        public string Get([FromRoute] int id)
//        {
//            return strings[id];
//        }

//        public List<string> Add( int id, [FromBody] string values)
//        {
//            strings[id] = values;
//            return strings;

//        }
//    }
//}
