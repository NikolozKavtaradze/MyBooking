using MediatR;
using MyBooking.Application.Abstractions.Authentication;
using MyBooking.Application.Abstractions.Messaging;
using MyBooking.Domain.Abstractions;
using MyBooking.Domain.Users;

namespace MyBooking.Application.Users.RegisterUser;

internal sealed class RegisterUserCommandHandler : ICommandHandler<RegisterUserCommand, Guid>
{
    private readonly IAuthenticationService _authenticationService;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IUserRepository _userRepository;

    public RegisterUserCommandHandler(
        IAuthenticationService authenticationService,
        IUnitOfWork unitOfWork,
        IUserRepository userRepository)
    {
        _authenticationService = authenticationService;
        _unitOfWork = unitOfWork;
        _userRepository = userRepository;
    }

    public async Task<Result<Guid>> Handle(RegisterUserCommand request, CancellationToken cancellationToken)
    {
        var user = User.Create(
        new FirstName(request.FirstName),
        new LastName(request.LastName),
        new Email(request.Email));

        var identityId = await _authenticationService.RegisterAsync(
            user,
            request.Password,
            cancellationToken);

        user.SetIdentityId(identityId);

        _userRepository.Add(user);

        await _unitOfWork.SaveChangesAsync(cancellationToken);

        return user.Id;
    }
}