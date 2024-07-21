using System;
using System.Collections.Generic;
using TaskProCore.Entities;
using TaskProCore.Entities.Enums;

namespace TaskProCore.Models;

public class Task : Entity
{
    public string Name { get; set; }
    
    public string Description { get; set; }
    
    public DateTime CreateDate { get; set; } = DateTime.Now;

    public DateTime StartDate { get; set; }
    
    public DateTime EndDate { get; set; }
    
    public Status Status { get; set; }
    
    public Priority Priority { get; set; }
    
    public int UserId { get; set; }
    
    public ICollection<Comment> Comments { get; set; }
}