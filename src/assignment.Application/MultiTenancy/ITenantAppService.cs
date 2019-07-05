using Abp.Application.Services;
using Abp.Application.Services.Dto;
using assignment.MultiTenancy.Dto;

namespace assignment.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

