using MediatR;
using MyBooking.Domain.Abstractions;

namespace MyBooking.Application.Abstractions.Messaging;

public interface IQuery<TResponse> : IRequest<Result<TResponse>>
{
    
}