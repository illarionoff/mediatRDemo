using DemoLibrary.Models;
using MediatR;

namespace DemoLibrary.Commands;

public record DeletePersonCommand(int id) : IRequest;
