using System.Threading.Tasks;
using CqrsSample.Domain.Commands.Requests;
using CqrsSample.Domain.Commands.Response;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CqrsSample.Controllers
{
  [ApiController]
  [Route("v1/customers")]
  public class CustomerController : ControllerBase
  {
    [HttpPost]
    [Route("")]
    public Task<CreateCustomerResponse> Create([FromServices] IMediator mediator, [FromBody] CreateCustomerRequest command)
    {
      return mediator.Send(command);
    }

    [HttpGet]
    [Route("")]
    public JsonResult Get()
    {
      return new JsonResult("success");
    }
  }
}