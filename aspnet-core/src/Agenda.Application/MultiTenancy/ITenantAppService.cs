using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Agenda.MultiTenancy.Dto;

namespace Agenda.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
