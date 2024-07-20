using System;
using System.Collections.Generic;
using TaskProCore.Entities.Enums;

namespace TaskProCore.Entities;

public class Project : Entity
{
    public string Name { get; set; }
    
    public string Description { get; set; }
    
    public DateTime CreateDate { get; set; } = DateTime.UtcNow;

    public DateTime StartDate { get; set; }
    
    public DateTime EndDate { get; set; }
    
    public Status Status { get; set; }
    
    public int UserId { get; set; }
    
    public int CreatorId { get; set; }
    
    public ICollection<Task> Tasks { get; set; }
    
    public ICollection<User> Users { get; set; }
    
}