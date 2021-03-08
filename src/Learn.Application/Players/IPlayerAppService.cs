
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Learn.Players.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Learn.Players
{
    public interface IPlayerAppService : IAsyncCrudAppService<PlayerDto, int, PagedAndSortedResultRequestDto, CreatePlayerDto, UpdatePlayerDto>
    {

    }
}
