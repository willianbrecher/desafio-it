using AutoMapper;
using DesafioIt.Application.Commands.Dishes;
using DesafioIt.Application.Hubs;
using DesafioIt.Application.Interfaces;
using DesafioIt.Application.Queries.Dishes;
using DesafioIt.Domain.Models;
using DesafioIt.Domain.Models.Dishes;
using DesafioIt.Domain.Repositories;
using Microsoft.AspNet.SignalR;

namespace DesafioIt.Application.Handlers.Dishes
{
    public class DishHandler : IApplicationCommandHandler<CreateDishCommand, DishModel>,
        IApplicationCommandHandler<UpdateDishCommand, DishModel>,
        IApplicationQueryHandler<DishPageableListQuery, PageableResult<DishModel>>
    {
        private readonly IDishRepository _dishRepository;
        private readonly IMapper _mapper;

        public DishHandler(IDishRepository dishRepository, IMapper mapper, IHubContext hubContext)
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

        /// <summary>
        /// Handles the <see cref="DishPageableListQuery"/> by retrieving a pageable list of <see cref="DishModel"/> objects.
        /// </summary>
        /// <param name="query">The <see cref="DishPageableListQuery"/> object containing the query parameters.</param>
        /// <param name="cancellationToken">A cancellation token that can be used to cancel the operation.</param>
        /// <returns>A <see cref="Task"/> object representing the asynchronous operation. The task result contains a <see cref="PageableResult"/> of <see cref="DishModel"/> objects.</returns>
        public Task<DishModel> Handle(UpdateDishCommand command, CancellationToken cancellationToken)
        {
            var dbItem = _dishRepository.Get(command.Id);
            dbItem.Update(command.Name, command.Description, command.Price, command.ServingSize, command.Photo, command.Type);

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
