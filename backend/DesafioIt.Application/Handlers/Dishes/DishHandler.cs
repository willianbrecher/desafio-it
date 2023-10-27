using AutoMapper;
using DesafioIt.Application.Commands.Dishes;
using DesafioIt.Application.Interfaces;
using DesafioIt.Application.Queries.Items;
using DesafioIt.Domain.Models;
using DesafioIt.Domain.Models.Dishes;
using DesafioIt.Domain.Repositories;
 
namespace DesafioIt.Application.Handlers.Dishes
{
    public class DishHandler : IApplicationCommandHandler<CreateDishCommand, DishModel>,
        IApplicationCommandHandler<UpdateDishCommand, DishModel>,
        IApplicationQueryHandler<DishPageableListQuery, PageableResult<DishModel>>
    {
        private readonly IDishRepository _dishRepository;
        private readonly IMapper _mapper;

        public DishHandler(IDishRepository dishRepository, IMapper mapper)
        {
            _dishRepository = dishRepository;
            _mapper = mapper;
        }

        public Task<PageableResult<DishModel>> Handle(DishPageableListQuery query, CancellationToken cancellationToken)
        {
            PageableResult<DishModel> results = _dishRepository.PageableList(query);

            var result = new PageableResult<DishModel>(
                pageSize: query.PageSize,
                currentPage: query.CurrentPage,
                results: results.Results
            );

            return Task.FromResult(result);
        }

        public Task<DishModel> Handle(UpdateDishCommand command, CancellationToken cancellationToken)
        {
            var dbItem = _dishRepository.Get(command.Id);
            dbItem.Update(command.Name, command.Description, command.Price, command.ServingSize, command.Type);

            _dishRepository.Save(dbItem);
            return Task.FromResult(dbItem);
        }

        public Task<DishModel> Handle(CreateDishCommand command, CancellationToken cancellationToken)
        {
            var model = _mapper.Map<DishModel>(command);
            _dishRepository.Insert(model);
            return Task.FromResult(model);
        }
    }
}
