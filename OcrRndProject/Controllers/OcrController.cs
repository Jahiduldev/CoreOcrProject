using Microsoft.AspNetCore.Mvc;
using OcrRndProject.BLL.Contracts;
using OcrRndProject.BLL.DomainModel;
using OcrRndProject.DAL.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OcrRndProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OcrController : ControllerBase 
    {
        private readonly IOcrImplementService _service;
        public OcrController(IOcrImplementService service)
        {
            _service = service;
        }


        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> CreateNidInformation([FromBody]  NidDomainModel nid)
        {
            if (ModelState.IsValid)
            {
               return Ok(await _service.CreateNidInformation(nid));
           }
            else
            {
                return Ok(CommonResponse.Failure("Invalid Info! Try again."));
            }

        }

        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> GetAllNidInformation()
        {
            return Ok(await _service.GetAllNidInformation());
        }



        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> GetNidAddressAndBasicInfo()
        {
            return Ok(await _service.GetNidAddressAndBasicInfo());
        }


        [HttpGet]
        [Route("[action]")]
        public string GetNidInformation()
        {
            return "Test string";
        }


        [HttpGet]
        [Route("[action]")]

        public string OcrRead()
        {
            return "Test string";
        }
    }
}
