using MediatR;
using MyBooking.Domain.Abstractions;

namespace MyBooking.Application.Abstractions.Messaging;

public interface IQueryHandler<TQuery, TResponse> : IRequestHandler<TQuery,Result<TResponse>>
    where TQuery : IQuery<TResponse>
{
    
}