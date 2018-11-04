using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Agenda.PhoneBook.Dto
{
    //Clase para mapiar todas las acciones
    public class PersonMapProfile : Profile
    {
        public PersonMapProfile()
        {
            //            Person
            CreateMap<Person, PersonListDto>();
            CreateMap<PersonListDto, Person>();

            //            Create Person
            CreateMap<CreatePersonInput, Person>();
            CreateMap<Person, CreatePersonInput>();

            //            Edit Person
            CreateMap<GetPersonForEditOutput, Person>();
            CreateMap<Person, GetPersonForEditOutput>();

            //            Phone
            CreateMap<PhoneInPersonListDto, Phone>();
            CreateMap<Phone, PhoneInPersonListDto>();

            //           Create Phone
            CreateMap<AddPhoneInput, Phone>();
            CreateMap<Phone, AddPhoneInput>();
        }
    }
}
