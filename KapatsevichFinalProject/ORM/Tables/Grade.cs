﻿using System.ComponentModel.DataAnnotations.Schema;

namespace ORM
{
    [Table("Grade")]
    public class Grade : IEntity
    {
        public int Id { get; set; }

        public int AppreiserId { get; set; }
        public User Appreiser { get; set; }

        public int BookId { get; set; }
        public Book Book { get; set; }

        public byte GradeValue { get; set; }

        public string Comment { get; set; }

        public bool IsBookHadRead { get; set; } 

    }
}