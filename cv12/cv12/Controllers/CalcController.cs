using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CalcApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalcController : ControllerBase
    {
        [HttpPost(Name = "Calculate")]
        public decimal Post([FromBody] CalcDTO calcDTO)
        {
            decimal cislo;
            switch (calcDTO.Operation)
            {
                case "plus":
                    cislo = calcDTO.Operand1 + calcDTO.Operand2;
                    break;
                case "minus":
                    cislo = calcDTO.Operand1 - calcDTO.Operand2;
                    break;
                case "krat":
                    cislo = calcDTO.Operand1 * calcDTO.Operand2;
                    break;
                case "deleno":
                    cislo = calcDTO.Operand1 / calcDTO.Operand2;
                    break;
                default:
                    cislo = 0;
                    break;
            }
            return cislo;
         }
    }
}
