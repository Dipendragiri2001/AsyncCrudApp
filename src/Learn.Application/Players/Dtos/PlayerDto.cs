using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Learn.Players.Dtos
{
    [AutoMap(typeof(Task))]
    public class PlayerDto : EntityDto
    {        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
