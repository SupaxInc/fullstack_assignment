using Abp.Application.Services;
using Abp.Domain.Repositories;
using assignment.Contents.DTO;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace assignment.Contents
{
    public class ContentAppService: ApplicationService, IContentAppService
    {
        private readonly IContentManager _contentManager;
        public ContentAppService(IContentManager contentManager)
        {
            _contentManager = contentManager;
        }

        public async Task DeleteCMSContent(DeleteContentInput input)
        {
            await _contentManager.DeleteCMSContent(input.Id);
        }

        public IEnumerable<GetContentOutput> GetAll()
        {
            var getAll = _contentManager.GetAll().ToList();
            List<GetContentOutput> output = Mapper.Map<List<Content>, List<GetContentOutput>>(getAll);
            return output;
        }

        public async Task<GetContentOutput> GetCMSContent(GetContentInput input)
        {
            var getContent = await _contentManager.GetCMSContent(input.Id);
            GetContentOutput output = Mapper.Map<Content, GetContentOutput>(getContent);
            return output;
        }

        public async Task InsertOrUpdateCMSContent(InsertOrUpdateInput input)
        {
            Content output = Mapper.Map<InsertOrUpdateInput, Content>(input);
            await _contentManager.InsertOrUpdateCMSContent(output);
        }
    }
}
