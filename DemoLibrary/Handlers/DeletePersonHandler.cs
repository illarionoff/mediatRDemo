using DemoLibrary.Commands;
using DemoLibrary.DataAccess;
using DemoLibrary.Models;
using DemoLibrary.Queries;
using MediatR;
namespace DemoLibrary.Handlers;

internal class DeletePersonHandler : IRequestHandler<DeletePersonCommand>
{
    private readonly IDataAccess _dataAccess;

    public DeletePersonHandler(IDataAccess dataAccess)
    {
        _dataAccess = dataAccess;
    }
    public Task<Unit> Handle(DeletePersonCommand request, CancellationToken cancellationToken)
    {
        _dataAccess.DeletePerson(request.id);
        return Task.FromResult(Unit.Value);
    }
}
