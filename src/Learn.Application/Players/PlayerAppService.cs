using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using Learn.Data.Models;
using Learn.Players.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Learn.Players
{
    public class PlayerAppService : AsyncCrudAppService<Player, PlayerDto, int, PagedAndSortedResultRequestDto, CreatePlayerDto, UpdatePlayerDto>
    {
        public PlayerAppService(IRepository<Player, int> repository) : base(repository)
        {
        }
    }
}
