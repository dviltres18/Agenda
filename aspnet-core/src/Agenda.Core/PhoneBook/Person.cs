﻿using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Agenda.PhoneBook
{
    [Table("PbPersons")]
    public class Person : FullAuditedEntity
    {
        public const int MaxNameLength = 32;
        public const int MaxSurnameLength = 32;
        public const int MaxEmailAddressLength = 255;
        [Required]
        [MaxLength(MaxNameLength)]
        public virtual string Name { get; set; }
        [Required]
        [MaxLength(MaxSurnameLength)]
        public virtual string Surname { get; set; }
        [MaxLength(MaxEmailAddressLength)]
        public virtual string EmailAddress { get; set; }
    }
}
