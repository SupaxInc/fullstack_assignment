using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace assignment.Contents
{
    public class Content: Entity<int>   // Entity class automatically adds primary ID key
    {
        public string PageName { get; set; }
        public string PageContent { get; set; }
    }
}
