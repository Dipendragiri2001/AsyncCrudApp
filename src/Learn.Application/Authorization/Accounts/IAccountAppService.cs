using System.Threading.Tasks;
using Abp.Application.Services;
using Learn.Authorization.Accounts.Dto;

namespace Learn.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
