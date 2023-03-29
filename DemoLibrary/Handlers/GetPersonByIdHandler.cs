using DemoLibrary.DataAccess;
using DemoLibrary.Models;
using DemoLibrary.Queries;
using MediatR;

namespace DemoLibrary.Handlers;

public class GetPersonByIdHandler : IRequestHandler<GetPersonByIdQuery, PersonModel>
{
    private readonly IMediator _dmediator;

    public GetPersonByIdHandler(IMediator mediator)
    {
        _dmediator = mediator;
    }
    public async Task<PersonModel?> Handle(GetPersonByIdQuery request, CancellationToken cancellationToken)
    {
        var result = await _dmediator.Send(new GetPersonListQuery());
        return result.FirstOrDefault(x => x.Id == request.Id);
    }
}
