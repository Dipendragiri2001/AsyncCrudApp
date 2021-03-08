using System.Threading.Tasks;
using Abp.Application.Services;
using Learn.Sessions.Dto;

namespace Learn.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
