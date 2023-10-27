using AutoMapper;
using DesafioIt.Application.Commands.Items;
using DesafioIt.Application.Interfaces;
using DesafioIt.Application.Queries.Items;
using DesafioIt.Domain.Models;
using DesafioIt.Domain.Models.Items;
using DesafioIt.Domain.Repositories;
using Microsoft.VisualBasic.FileIO;

namespace DesafioIt.Application.Handlers.Items
{
    public class ItemHandler : IApplicationCommandHandler<CreateItemCommand, ItemModel>,
        IApplicationCommandHandler<UpdateItemCommand, ItemModel>,
        IApplicationQueryHandler<ItemPageableListQuery, PageableResult<ItemModel>>
    {
        private readonly IItemRepository _itemRepository;
        private readonly IMapper _mapper;

        public ItemHandler(IItemRepository itemRepository, IMapper mapper)
        {
            _itemRepository = itemRepository;
            _mapper = mapper;
        }

        public Task<PageableResult<ItemModel>> Handle(ItemPageableListQuery query, CancellationToken cancellationToken)
        {
            PageableResult<ItemModel> results = _itemRepository.PageableList(query);

            var result = new PageableResult<ItemModel>(
                pageSize: query.PageSize,
                currentPage: query.CurrentPage,
                results: results.Results
            );

            return Task.FromResult(result);
        }

        public Task<ItemModel> Handle(UpdateItemCommand command, CancellationToken cancellationToken)
        {
            var dbItem = _itemRepository.Get(command.Id);
            dbItem.Update(command.Name, command.Note, command.Code, command.Disabled);

            _itemRepository.Save(dbItem);
            return Task.FromResult(dbItem);
        }

        public Task<ItemModel> Handle(CreateItemCommand command, CancellationToken cancellationToken)
        {
            var model = _mapper.Map<ItemModel>(command);
            _itemRepository.Insert(model);
            return Task.FromResult(model);
        }
    }
}
