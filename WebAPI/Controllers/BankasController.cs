using Business1.Abstract;
using Business1.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BankasController : ControllerBase
    {
        IBankaService _bankaService;
        public BankasController(IBankaService bankaService)
        {
            _bankaService = bankaService;
        }

      [HttpGet]
      public IActionResult Get()
        {
            var result = _bankaService.GetAll();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

        [HttpPost]
        public IActionResult Post(Banka banka)
        {
            var result = _bankaService.Add(banka);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
