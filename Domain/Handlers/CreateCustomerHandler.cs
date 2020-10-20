using System;
using CqrsSample.Domain.Commands.Requests;
using CqrsSample.Domain.Commands.Response;
using CqrsSample.Domain.Handlers.Contracts;

namespace CqrsSample.Domain.Handlers {
    public class CreateCustomerHandler : ICreateCustomerHandler {
        public CreateCustomerResponse Handle(CreateCustomerRequest request) {
            
            //TODO
            //verificar se o cliente já está cadastrado
            //validar os dados
            //inserir o cliente
            //enviar email de boas vindas

            return new CreateCustomerResponse {
                Id = Guid.NewGuid(),
                Name = "Gustavo César de Melo",
                Email = "delfino.cesar@gmail.com",
                Date = DateTime.Now
            };
        }
    }
}