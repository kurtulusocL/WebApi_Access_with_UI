using ApiSample.Business.Abstract;
using ApiSample.Entities.Concrete;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiSample.WebApi.Controllers
{
    [EnableCors]
    [Route("api/[controller]")]
    [ApiController]
    public class VisitorsController : ControllerBase
    {
        private readonly IVisitorService _visitorService;
        public VisitorsController(IVisitorService visitorService)
        {
            _visitorService = visitorService;
        }

        [HttpGet]
        public IActionResult VisitorList()
        {
            var values = _visitorService.GetAll();
            if (values != null)
            {
                return Ok(values);
            }
            return BadRequest();
        }

        [HttpGet("{id}")]
        public IActionResult GetVisitor(int id)
        {
            var value = _visitorService.GetById(id);
            if (value != null)
            {
                return Ok(value);               
            }
            return NotFound();
        }

        [HttpPost]
        public IActionResult CreateVisitor(Visitor model)
        {
            if (ModelState.IsValid)
            {
                _visitorService.Create(model);
                return Ok();
            }
            return BadRequest();
        }

        [HttpPut]
        public IActionResult UpdateVisitor(Visitor model)
        {
            var value = _visitorService.GetById(model.Id);
            if (value != null)
            {
                _visitorService.Update(model);
                return Ok();
            }
            return BadRequest();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteVisitor(int id)
        {
            var value = _visitorService.GetById(id);
            if (value != null)
            {
                _visitorService.Delete(value);
                return Ok();
            }
            return NotFound();
        }
    }
}
