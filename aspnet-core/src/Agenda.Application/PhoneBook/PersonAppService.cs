using System;
using System.Collections.Generic;
using System.Text;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using Abp.Extensions;
using Agenda.PhoneBook.Dto;

namespace Agenda.PhoneBook
{
    public class PersonAppService : AgendaAppServiceBase, IPersonAppService
    {
        private readonly IRepository<Person> _personRepository;
        public PersonAppService(IRepository<Person> personRepository)
        {
            _personRepository = personRepository;
        }
        public ListResultDto<PersonListDto> GetPeople(GetPeopleInput input)
        {
            var people = _personRepository
                .GetAll()
                .WhereIf(!input.Filter.IsNullOrEmpty(),
                p => p.Name.Contains(input.Filter) ||
                p.Surname.Contains(input.Filter) ||
                p.EmailAddress.Contains(input.Filter)
            )
            .OrderBy(p => p.Name)
            .ThenBy(p => p.Surname)
            .ToList();
            return new ListResultDto<PersonListDto>(ObjectMapper.Map < List < PersonLi
            stDto >> (people));
        }

        public ListResultDto<PersonListDto> GetPeople(GetPeopleInput input)
        {
            throw new NotImplementedException();
        }
    }
}
