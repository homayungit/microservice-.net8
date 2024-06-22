﻿using MediatR;

namespace BuildingBlocks.CQRS;

public interface ICommandhandler<in TCommand> : ICommandHandler<TCommand, Unit> where TCommand : ICommand<Unit>
{

}

public interface ICommandHandler<in TCommand, TResponse> : IRequestHandler<TCommand, TResponse> where TCommand : ICommand<TResponse> where TResponse : notnull
{
}

