using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using CarBook.Application.Features.CQRS.Commands.ContactCommands;


namespace CarBook.Application.Features.CQRS.Handlers.ContactHandlers
{
    public class UpdateContactCommandHandler
    {
        private readonly IRepository<Contact> _repository;
        public UpdateContactCommandHandler(IRepository<Contact> repository)
        {
            _repository = repository;
        }
        public async Task Handle(UpdateContactCommand command)
        {
            var values = await _repository.GetByIdAsync(command.ContactID);
            {
                values.Name = command.Name;
                values.Email = command.Email;
                values.Phone = command.Phone;
                values.CreatedDate = command.CreatedDate;

                values.Subject = command.Subject;
                values.Message = command.Message;
                await _repository.UpdateAsync(values);
            }
            
        }

    }
}
