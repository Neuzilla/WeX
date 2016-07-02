using System.Threading.Tasks;
using Abp.Application.Services;
using WexOne.Roles.Dto;

namespace WexOne.Roles
{
    public interface IRoleAppService : IApplicationService
    {
        Task UpdateRolePermissions(UpdateRolePermissionsInput input);
    }
}
