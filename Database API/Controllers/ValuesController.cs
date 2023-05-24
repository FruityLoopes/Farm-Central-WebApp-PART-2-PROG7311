using Microsoft.AspNetCore.Mvc;

namespace Database_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ValuesController : ControllerBase
    {

        ProductFactory productFactory = new ProductFactory();
        IProduct iprod;

        private readonly ILogger<ValuesController> _logger;

        public ValuesController(ILogger<ValuesController> logger)
        {
            _logger = logger;
        }

        [HttpGet("All")]
        public IEnumerable<string> All(String Select)
        {
            //_logger.Log(LogLevel.Trace , Select);
            //_logger.LogInformation(Select);

            iprod = productFactory.GetType(Select);

            return Type.getInstance().All(iprod.GetProduct());

        }

    }
}