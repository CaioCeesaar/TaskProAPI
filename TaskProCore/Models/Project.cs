using System;
using System.Collections.Generic;
using TaskProCore.Entities;
using TaskProCore.Entities.Enums;

namespace TaskProCore.Models;

public class Project : Entity
{
    public string Title { get; set; }
    
    public string Description { get; set; }
    
    public DateTime CreateDate { get; set; } = DateTime.UtcNow;
    
    public Status Status { get; set; }
    
    public Priority Priority { get; set; }
    
    public ICollection<ProjectTask> ProjectTasks { get; set; }
}