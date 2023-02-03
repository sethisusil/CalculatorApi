using CalculatorApiCommon.Clients;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CalculatorApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        ICalculator calculator;
        public CalculatorController(ICalculator calculator)
        {
            this.calculator = calculator;
        }
    

        // GET api/<ValuesController>/5
        [HttpGet("{expr}")]
        public async Task<string> Get(string expr)
        {
            return await calculator.Calculate(expr);
        }

    }
}
