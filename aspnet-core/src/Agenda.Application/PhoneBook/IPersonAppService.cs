using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Agenda.PhoneBook.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Agenda.PhoneBook
{
    public interface IPersonAppService : IApplicationService
    {
        ListResultDto<PersonListDto> GetPeople(GetPeopleInput input);
    }
}
