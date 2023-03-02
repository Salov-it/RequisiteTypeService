using MediatR;
using Microsoft.AspNetCore.Mvc;
using RequisiteTypeService.Application.CQRS.Command.Create;
using RequisiteTypeService.Application.CQRS.Command.UpdateRequisiteType;
using RequisiteTypeService.Application.CQRS.Querries.Get;
using RequisiteTypeService.Application.CQRS.Querries.GetByIdQuerry;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RequisiteTypeService.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TradeController : ControllerBase
    {
        private readonly IMediator mediator;

        public TradeController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Create(int currencyId, string organisation, string description)
        {
            var content = new CreateRequisiteTypeСommand
            {
               currencyId = currencyId,
               organisation = organisation,
               description = description
            };
            var answer = await mediator.Send(content);
            return Ok(answer);
        }

        [HttpPost("Update")]
        public async Task<IActionResult> Update(int id, int currencyId, string organisation, string description)
        {
            var content = new UpdateRequisiteTypeCommand
            {
               id = id,
               currencyId = currencyId,
               organisation = organisation,
               description = description
            };

            var answer = await mediator.Send(content);
            return Ok(answer);
        }

        [HttpGet]
        public async Task<IActionResult> GetById(int Id)
        {
            var content = new GetByIdQuerry
            {
                Id = Id
            };
            var answer = await mediator.Send(content);
            return Ok(answer);
        }

        [HttpGet("GetBy")]
        public async Task<IActionResult> Get()
        {
            var content = new GetByQuerry
            {

            };
            var answer = await mediator.Send(content);
            return Ok(answer);
        }


    }

}
