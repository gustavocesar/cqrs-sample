using CqrsSample.Domain.Commands.Requests;
using CqrsSample.Domain.Commands.Response;
using CqrsSample.Domain.Handlers.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace CqrsSample.Controllers {
    public class CustomerControllers
    {
        [ApiController]
        [Route("customers")]
        public class CustomerController : ControllerBase
        {
            [HttpPost]
            [Route("")]
            public CreateCustomerResponse Create(
                [FromServices]ICreateCustomerHandler handler,
                [FromBody]CreateCustomerRequest command
            )
            {
                return handler.Handle(command);
            }
        }
    }
}