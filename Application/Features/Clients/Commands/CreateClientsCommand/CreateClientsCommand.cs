using Application.Wrappers;
using MediatR;

namespace Application.Features.Clients.Commands.CreateClientsCommand;
public class CreateClientsCommand : IRequest<Response<int>>
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public string Address { get; set; }
}

public class CreateClientsCommandHandler : IRequestHandler<CreateClientsCommand, Response<int>>
{
    public async Task<Response<int>> Handle(CreateClientsCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}