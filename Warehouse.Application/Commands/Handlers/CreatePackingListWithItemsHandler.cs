﻿using Warehouse.Application.Exceptions;
using Warehouse.Application.Services;
using Warehouse.Domain.Factories;
using Warehouse.Domain.Repositories;
using Warehouse.Domain.ValueObjects;
using Warehouse.Shared.Abstractions.Commands;

namespace Warehouse.Application.Commands.Handlers
{
    public class CreatePackingListWithItemsHandler : ICommandHandler<CreatePackingListWithItems>
    {
        private readonly IPackingListRepository _repository;
        private readonly IPackingListFactory _factory;
        private readonly IPackingListReadService _readService;
        private readonly IWeatherService _weatherService;

        public CreatePackingListWithItemsHandler(
            IPackingListRepository repository,
            IPackingListFactory factory,
            IPackingListReadService readService,
            IWeatherService weatherService)
        {
            _repository = repository;
            _factory = factory;
            _readService = readService;
            _weatherService = weatherService;
        }

        public async Task HandleAsync(CreatePackingListWithItems command)
        {
            var (id, name, days, gender, localizationWriteModel) = command;

            if (await _readService.ExistsByNameAsync(name))
            {
                throw new PackingListAlreadyExistsException(name);
            }

            var localization = new Localization(localizationWriteModel.City, localizationWriteModel.Country);
            var weather = await _weatherService.GetWeatherAsync(localization);

            if (weather is null)
            {
                throw new MissingLocalizationWeatherException(localization);
            }

            var packingList = _factory.CreateWithDefaultItems(id, name, days, gender, weather.Temperature, localization);

            await _repository.AddAsync(packingList);
        }
    }
}