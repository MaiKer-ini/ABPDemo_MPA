using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Repositories;
using Abp.Linq.Extensions;
using Demo.PhoneBook.Dto;
using Demo.PhoneBook.Person;
using Microsoft.EntityFrameworkCore;

namespace Demo.PhoneBook
{
    public class PersonAppService : DemoAppServiceBase, IPersonAppService
    {
        private readonly IRepository<PersonEntity> _personRepository;

        public PersonAppService(IRepository<PersonEntity> personRepository)
        {
            _personRepository = personRepository;
        }

        public async Task<PagedResultDto<PersonDto>> GetPagedPersonAsync(GetPersonInputDto input)
        {
            var query = _personRepository.GetAll();
            var count = await query.CountAsync();
            var persons = await query.OrderBy(input.Sorting).PageBy(input).ToListAsync();
            var dtos = persons.MapTo<List<PersonDto>>();
            return new PagedResultDto<PersonDto>(count, dtos);
        }

        public Task<PersonDto> GetPersonByIdAsync()
        {
            throw new System.NotImplementedException();
        }

        public async Task CreateOrUpdatePersonAsync(PersonUpdateDto input)
        {
            if (input.Id.Equals(0))
            {
                await _personRepository.InsertAsync(input.MapTo<PersonEntity>());
            }
        }

        public async Task DeletePersonAsync(EntityDto input)
        {
            await _personRepository.DeleteAsync(input.Id);
        }

        public async Task<PersonDto> GetPersonByIdAsync(NullableIdDto input)
        {
            var person = await _personRepository.GetAsync(input.Id.Value);
            return person.MapTo<PersonDto>();
        }
    }
}