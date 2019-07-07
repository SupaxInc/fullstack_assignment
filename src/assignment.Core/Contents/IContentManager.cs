using Abp.Domain.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace assignment.Contents
{
    public interface IContentManager: IDomainService
    {
        // Interfaces are for the declaration of methods, NOT implementation
        IEnumerable<Content> GetAll();
        Task<Content> GetCMSContent(int id);
        Task<Content> InsertOrUpdateCMSContent(Content entity);
        Task DeleteCMSContent(int id);
    }
}
