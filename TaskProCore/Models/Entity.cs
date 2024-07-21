using System;

namespace TaskProCore.Models;

public abstract class Entity
{
    public Guid Id { get; set; } = Guid.NewGuid();
}