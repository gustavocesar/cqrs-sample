using CqrsSample.Domain.Commands.Response;
using MediatR;

namespace CqrsSample.Domain.Commands.Requests
{
    public class CreateCustomerRequest : IRequest<CreateCustomerResponse>
    {
        public string Name { get; set; }
        public string Email { get; set; }
    }
}