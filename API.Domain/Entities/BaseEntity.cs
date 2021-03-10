using System;
using System.ComponentModel.DataAnnotations;

namespace API.Domain.Entities
{
    public abstract class BaseEntity
    {
        [Key]
        public Guid Id { get; set; }

        private DateTime? _createAt;
        public DateTime? createAt
        {
            get { return _createAt; }
            set { _createAt = (value == null ? DateTime.Now : value); }
        }

        public DateTime UpdateAt { get; set; }
    }
}
