using MassTransit;
using System;

namespace SharedModule.Core.Primitives
{
    public abstract class Entity
    {
        public string Id { get; set; } = NewId.Next().ToString();
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifyDate { get; set; }
    }
}
