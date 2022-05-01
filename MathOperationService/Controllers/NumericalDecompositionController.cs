using MathOperationService.Models;
using MathOperationService.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MathOperationService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NumericalDecompositionController : Controller
    {
        private readonly IServiceMath _service;

        public NumericalDecompositionController()
        {
            _service = new ServiceMath();
        }

        [HttpGet("{number}", Name = "GetAllNumericalDecomposition")]
        public ActionResult<NumericalDecomposition> GetAllNumericalDecomposition(decimal number)
        {
            if (_service.isValid(number))
            {
                try
                {
                    List<decimal> divisorsNumbers = new(_service.getAllDivisorsNumbers(number));
                    List<decimal> primeNumbers = new(_service.getAllPrimeNumbers(divisorsNumbers));
                
                    return Ok(new NumericalDecomposition(number, divisorsNumbers, primeNumbers));
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.Message);
                }              
            }

            return BadRequest("Favor Informar um numero inteiro, com até 18 caracteres.");
        }
    }
}
