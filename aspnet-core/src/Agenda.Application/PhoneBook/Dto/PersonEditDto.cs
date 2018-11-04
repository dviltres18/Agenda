using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Agenda.PhoneBook.Dto
{
    public class PersonEditDto : EntityDto<int>
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public string EmailAddress { get; set; }
    }
}
