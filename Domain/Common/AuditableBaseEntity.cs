﻿namespace Domain.Common
{
    public abstract class AuditableBaseEntity
    {
        public virtual int Id { get; set; }
        public string CreatedBy { get; set; }
        public DateTime created { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModified { get; set; }

    }
}
