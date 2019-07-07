using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace assignment.Contents.DTO
{
    
    public class InsertOrUpdateInput
    {
        public int Id { get; set; }
        public string PageName { get; set; }
        public string PageContent { get; set; }
    }
}
