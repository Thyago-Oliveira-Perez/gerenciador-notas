using Microsoft.AspNetCore.Mvc;
using Model.Domain.Entities;
using Model.Domain.Interfaces;

namespace Model.Application.Controllers
{
    public class ExtratoController : Controller
    {
        [Route("api/[controller]")]
        [ApiController]
        public class UserController : ControllerBase
        {
            private IBaseService<Extrato> _baseExtratoService;

            public UserController(IBaseService<Extrato> baseUserService)
            {
                _baseExtratoService = baseUserService;
            }

            [HttpPost]
            public IActionResult Create([FromBody] Extrato extrato)
            {
                if (extrato == null)
                    return NotFound();

                return Execute(() => _baseExtratoService.Add(extrato).Id);
            }

            [HttpPut]
            public void Update([FromBody] Extrato extrato)
            {
                if (extrato != null)
                    Execute(() => _baseExtratoService.Update(extrato));
            }

            [HttpDelete("{id}")]
            public IActionResult Delete(int id)
            {
                if (id == 0)
                    return NotFound();

                Execute(() =>
                {
                    _baseExtratoService.Delete(id);
                    return true;
                });

                return new NoContentResult();
            }

            [HttpGet]
            public IActionResult Get()
            {
                return Execute(() => _baseExtratoService.Get());
            }

            [HttpGet("{id}")]
            public IActionResult Get(int id)
            {
                if (id == 0)
                    return NotFound();

                return Execute(() => _baseExtratoService.GetById(id));
            }

            private IActionResult Execute(Func<object> func)
            {
                try
                {
                    var result = func();

                    return Ok(result);
                }
                catch (Exception ex)
                {
                    return BadRequest(ex);
                }
            }
        }
    }
}
