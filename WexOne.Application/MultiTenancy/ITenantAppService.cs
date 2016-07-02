using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using WexOne.MultiTenancy.Dto;

namespace WexOne.MultiTenancy
{
    public interface ITenantAppService : IApplicationService
    {
        ListResultOutput<TenantListDto> GetTenants();

        Task CreateTenant(CreateTenantInput input);
    }
}
