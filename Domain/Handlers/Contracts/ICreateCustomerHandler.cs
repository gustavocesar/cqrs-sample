using System;
using CqrsSample.Domain.Commands.Requests;
using CqrsSample.Domain.Commands.Response;

namespace CqrsSample.Domain.Handlers.Contracts {
    public interface ICreateCustomerHandler {
        CreateCustomerResponse Handle(CreateCustomerRequest request);
    }
}