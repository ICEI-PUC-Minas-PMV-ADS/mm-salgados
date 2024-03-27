using MMSalgados.Domain.Interfaces;
using System;

namespace MMSalgados.Domain.Entities
{
    public class Entity : IEntity
    {
        public Entity() { }

        public int Id { get; set; }
        public DateTime CreatedDate { get => DateTime.Now; }
        public DateTime UpdatedDate { get => DateTime.Now; }
    }
}
