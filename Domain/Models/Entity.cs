﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models
{
    public class Entity
    {
        public Guid Id { get; set; }
        [MaxLength(150), Required]
        public string Name { get; set; }

        //Audtiting
        [MaxLength(40)]
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        [MaxLength(40)]
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        [NotMapped]
        public bool IsModified
        {
            get
            {
                return ModifiedDate != null;
            }
        }
        [MaxLength(40)]
        public string? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }

        [NotMapped]
        public bool IsDeleted
        {
            get
            {
                return DeletedDate != null;
            }
        }
    }
}
