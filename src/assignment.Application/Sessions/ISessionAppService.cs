using System.Threading.Tasks;
using Abp.Application.Services;
using assignment.Sessions.Dto;

namespace assignment.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
