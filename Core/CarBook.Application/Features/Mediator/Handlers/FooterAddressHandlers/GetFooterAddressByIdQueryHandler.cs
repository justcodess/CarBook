using CarBook.Application.Features.Mediator.Queries.FooterAddressQueries;
using CarBook.Application.Features.Mediator.Results.FooterAddressResults;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using MediatR;

public class GetFooterAddressByIdQueryHandler
    : IRequestHandler<GetFooterAddressByIdQuery, GetFooterAddressByIdQueryResult>
{
    private readonly IRepository<FooterAddress> _repository;

    public GetFooterAddressByIdQueryHandler(IRepository<FooterAddress> repository)
    {
        _repository = repository;
    }

    public async Task<GetFooterAddressByIdQueryResult> Handle(GetFooterAddressByIdQuery request, CancellationToken cancellationToken)
    {
        var value = await _repository.GetByIdAsync(request.Id);

        return new GetFooterAddressByIdQueryResult
        {
            FooterAddressID = value.FooterAddressID,
            Address = value.Address,
            Phone = value.Phone,
            Email = value.Email,
            Description = value.Description

        };
    }
}
