using CarBook.Application.Features.Mediator.Commands.AuthorCommads;
using CarBook.Application.Interfaces;
using MediatR;
using CarBook.Domain.Entities;



namespace CarBook.Application.Features.Mediator.Handlers.AuthorHandlers
{
    public class UpdateAuthorCommandHandler : IRequestHandler<UpdateAuthorCommand>
    {
        private readonly IRepository<Author> _repository;
        public UpdateAuthorCommandHandler(IRepository<Author> repository)
        {
            _repository = repository;
        }
        public async Task Handle(UpdateAuthorCommand request, CancellationToken cancellationToken)
        {
            var values= await _repository.GetByIdAsync(request.AuthorID);
           
            {
                values.Name = request.Name;
                values.Description = request.Description;
                values.AuthorID = request.AuthorID;
                values.ImageUrl = request.ImageUrl;
                values.Description = request.Description;
                await _repository.UpdateAsync(values);
            }

        }
    }
}
