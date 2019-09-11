﻿using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Demo.PhoneBook.Dto;

namespace Demo.PhoneBook
{
    public interface IPersonAppService : IApplicationService
    {
        /// <summary>
        /// 获取联系人相关信息，支持分页
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task<PagedResultDto<PersonDto>> GetPagedPersonAsync(GetPersonInputDto input);
        /// <summary>
        /// 根据ID获取联系人信息
        /// </summary>
        /// <returns></returns>
        Task<PersonDto> GetPersonByIdAsync(NullableIdDto input);
        /// <summary>
        /// 新增或更新联系人信息
        /// </summary>
        /// <returns></returns>
        Task CreateOrUpdatePersonAsync(PersonUpdateDto input);
        /// <summary>
        /// 删除联系人信息
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task DeletePersonAsync(EntityDto input);
    }
}