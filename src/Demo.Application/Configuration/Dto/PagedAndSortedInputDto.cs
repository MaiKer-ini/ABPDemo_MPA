using System;
using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;

namespace Demo.Configuration.Dto
{
    public class PagedAndSortedInputDto : IPagedAndSortedResultRequest
    {
        [Range(1, 100)]
        public int MaxResultCount { get; set; }
        [Range(0, Int32.MaxValue)]
        public int SkipCount { get; set; }
        public string Sorting { get; set; }
    }
}