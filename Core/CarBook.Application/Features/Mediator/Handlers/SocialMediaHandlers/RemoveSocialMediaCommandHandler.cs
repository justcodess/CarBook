
using CarBook.Application.Features.Mediator.Commands.SocialMediaCommands;
using MediatR;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;

namespace CarBook.Application.Features.Mediator.Handlers.SocialMediaHandlers
{
    public class RemoveSocialMediaCommandHandler : IRequestHandler<RemoveSocialMediaCommand>
    {
        private readonly IRepository<SocialMedia> _repository;
        public RemoveSocialMediaCommandHandler(IRepository<SocialMedia> repository)
        {
            _repository = repository;
        }
        public async Task Handle(RemoveSocialMediaCommand request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.Id);
            await _repository.RemoveAsync(values);

        }
    }
}
