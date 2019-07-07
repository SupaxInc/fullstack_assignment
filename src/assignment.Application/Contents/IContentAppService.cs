using Abp.Application.Services;
using assignment.Contents.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace assignment.Contents
{
    public interface IContentAppService: IApplicationService
    {
        IEnumerable<GetContentOutput> GetAll();
        Task<GetContentOutput> GetCMSContent(GetContentInput input);
        Task InsertOrUpdateCMSContent(InsertOrUpdateInput input);
        Task DeleteCMSContent(DeleteContentInput input);
    }
}
