using Agenda.PhoneBook;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Agenda.EntityFrameworkCore.Seed.Host
{
    public class InitialPeopleCreator
    {
        private readonly AgendaDbContext _context;

        public InitialPeopleCreator(AgendaDbContext context)
        {
            _context = context;
        }

        public void Create(){

            var douglas = _context.Persons.FirstOrDefault(
                     p => p.EmailAddress == "douglas.adams@fortytwo.com");

            if (douglas == null){

                _context.Persons.Add(
                new Person{
                    Name = "Douglas",
                    Surname = "Adams",
                    EmailAddress = "douglas.adams@fortytwo.com"
                });
            }
            var asimov = _context.Persons.FirstOrDefault(
                p => p.EmailAddress == "isaac.asimov@foundation.org");

            if (asimov == null){

                _context.Persons.Add(
                new Person{
                    Name = "Isaac",
                    Surname = "Asimov",
                    EmailAddress = "isaac.asimov@foundation.org"
                });
            }
        }
    }
}
