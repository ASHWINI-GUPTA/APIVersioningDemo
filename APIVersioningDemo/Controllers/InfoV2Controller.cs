using System.Collections.Generic;
using System.Linq;
using APIVersioningDemo.Data;
using APIVersioningDemo.Model.Response;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace APIVersioningDemo.Controllers
{
    [Route("api/info")]
    [ApiVersion("2.0")]
    [ApiController]

    public class InfoV2Controller : ControllerBase
    {
        private readonly IMapper _mapper;

        public InfoV2Controller(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<ContactInfo>> Get()
        {
            var userData = new Seed().Info;

            return _mapper.Map<IEnumerable<ContactInfo>>(userData).ToList(); ;
        }
    }
}
