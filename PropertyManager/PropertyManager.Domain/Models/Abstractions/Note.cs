﻿using PropertyManager.Domain.Common;

namespace PropertyManager.Domain.Models
{
    public abstract class Note : AuditableEntity
    {
        public string Id { get; set; }
        public string Summary { get; set; }
        public string Text { get; set; }
    }
}
