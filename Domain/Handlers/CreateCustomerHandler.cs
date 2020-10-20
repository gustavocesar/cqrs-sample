using System;
using System.Threading;
using System.Threading.Tasks;
using CqrsSample.Domain.Commands.Requests;
using CqrsSample.Domain.Commands.Response;
using MediatR;

namespace CqrsSample.Domain.Handlers
{
    public class CreateCustomerHandler : IRequestHandler<CreateCustomerRequest, CreateCustomerResponse>
    {
        public Task<CreateCustomerResponse> Handle(CreateCustomerRequest request, CancellationToken cancellationToken)
        {
            //TODO
            //verificar se o cliente já está cadastrado
            //validar os dados
            //inserir o cliente
            //enviar email de boas vindas

            var result = new CreateCustomerResponse
            {
                Id = Guid.NewGuid(),
                Name = "Gustavo César de Melo w",
                Email = "delfino.cesar@gmail.com",
                Date = DateTime.Now
            };

            return Task.FromResult(result);
        }
    }
}