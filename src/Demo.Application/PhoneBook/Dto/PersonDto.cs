using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Runtime.Validation;
using Demo.Configuration.Dto;
using Demo.PhoneBook.Person;

namespace Demo.PhoneBook.Dto
{
    public class GetPersonInputDto : PagedAndSortedInputDto, IShouldNormalize
    {
        /// <summary>
        /// 查询框
        /// </summary>
        public string Input { get; set; }
        public void Normalize()
        {
            if (string.IsNullOrEmpty(Sorting))
            {
                Sorting = "Id";
            }
        }
    }
    [AutoMapTo(typeof(PersonEntity))]
    public class PersonCreateDto : FullAuditedEntityDto
    {
        /// <summary>
        /// 姓名
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 邮箱地址
        /// </summary>
        public string EmailAddress { get; set; }
        /// <summary>
        /// 地址
        /// </summary>
        public string Address { get; set; }
    }

    public class PersonUpdateDto : PersonCreateDto
    {
    }
    [AutoMapFrom(typeof(PersonEntity))]
    public class PersonDto : PersonUpdateDto
    {
    }

}