using System.Collections.Generic;
using System.Linq;
using APIVersioningDemo.Data;
using APIVersioningDemo.Model.Response;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace APIVersioningDemo.Controllers
{
    [Route("api/info")]
    [ApiVersion("1.0")]
    [ApiVersion("1.1")]
    [ApiController]
    public class InfoController : ControllerBase
    {
        private readonly IMapper _mapper;

        public InfoController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpGet]
        [MapToApiVersion("1.0")]
        public ActionResult<IEnumerable<InfoModel>> Get()
        {
            var userData = new Seed().Info;

            return _mapper.Map<IEnumerable<InfoModel>>(userData).ToList();
        }

        [HttpGet]
        [MapToApiVersion("1.1")]
        public ActionResult<IEnumerable<GenderModal>> GetWithGender()
        {
            var userData = new Seed().Info;

            return _mapper.Map<IEnumerable<GenderModal>>(userData).ToList();
        }

        [HttpGet]
        [Route("method")]
        public ActionResult GetString()
        {
            const string message = "This is unaffected method";
            return new JsonResult(message);
        }

    }
}
