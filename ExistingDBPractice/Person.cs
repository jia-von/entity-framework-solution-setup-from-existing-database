﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExistingDBPractice
{
    [Table("person")]
    public partial class Person
    {
        public Person()
        {
            PhoneNumbers = new HashSet<Phonenumber>();
        }

        [Key]
        [Column("ID", TypeName = "int(10)")]
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "varchar(50)")]
        public string FirstName { get; set; }
        [Required]
        [Column(TypeName = "varchar(50)")]
        public string LastName { get; set; }

        [InverseProperty("Persons")]
        public virtual ICollection<Phonenumber> PhoneNumbers { get; set; }
    }
}
