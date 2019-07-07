using Abp.Domain.Repositories;
using Abp.Domain.Services;
using Abp.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace assignment.Contents
{
    class ContentManager: DomainService, IContentManager
    {
        private readonly IRepository<Content> _repository;
        public ContentManager(IRepository<Content> repository)
        {
            _repository = repository;
        }

        public async Task DeleteCMSContent(int id)
        {
            var content = await _repository.FirstOrDefaultAsync(x => x.Id == id);
            if(content == null)
            {
                throw new UserFriendlyException("The content you are trying to delete does not exist!");
            } else
            {
                await _repository.DeleteAsync(content);
            }
        }

        public IEnumerable<Content> GetAll()
        {
            return _repository.GetAllList().ToList();
        }

        public async Task<Content> GetCMSContent(int id)
        {
            return await _repository.GetAsync(id);
        }

        public async Task<Content> InsertOrUpdateCMSContent(Content entity)
        {
            // Needs to be fixed
            var content = await _repository.FirstOrDefaultAsync(x => x.Id == entity.Id);
            if (content == null)
            {
                return await _repository.InsertOrUpdateAsync(entity);
            } else
            {
                
                return await _repository.InsertOrUpdateAsync(content);
            }
        }
    }
}
