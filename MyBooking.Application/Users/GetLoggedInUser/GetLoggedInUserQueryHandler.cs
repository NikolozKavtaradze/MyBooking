using System.Data;
using Dapper;
using MyBooking.Application.Abstractions.Authentication;
using MyBooking.Application.Abstractions.Data;
using MyBooking.Application.Abstractions.Messaging;
using MyBooking.Domain.Abstractions;

namespace MyBooking.Application.Users.GetLoggedInUser;

internal sealed class GetLoggedInUserQueryHandler : IQueryHandler<GetLoggedInUserQuery, UserResponse>
{
    private readonly ISqlConnectionFactory _sqlConnectionFactory;
    private readonly IUserContext _userContext;

    public GetLoggedInUserQueryHandler(
        ISqlConnectionFactory sqlConnectionFactory,
        IUserContext userContext)
    {
        _sqlConnectionFactory = sqlConnectionFactory;
        _userContext = userContext;
    }

    public async Task<Result<UserResponse>> Handle(
        GetLoggedInUserQuery request,
        CancellationToken cancellationToken)
    {
        using IDbConnection connection = _sqlConnectionFactory.CreateConnection();

        const string sql = """
                           SELECT
                            id as Id,
                            first_name as FirstName,
                            last_name as LastName,
                            email as Email
                           FROM users
                           WHERE identity_id = @IdentityId
                           """;

        UserResponse user = await connection.QuerySingleAsync<UserResponse>(
            sql,
            new
            {
                _userContext.IdentityId
            });

        return user;
    }
}